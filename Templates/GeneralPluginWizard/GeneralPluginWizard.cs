using System;
using System.Collections.Generic;
using System.Xml;
using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;

namespace Daniel15.Sharpamp
{
	public class GeneralPluginWizard : IWizard
	{
		// The information we're sharing
		private static string _PluginGuid = string.Empty;
		private static string _PluginName;
		private static string _SafePluginName;

		public void RunStarted(object automationObject,
			Dictionary<string, string> replacementsDictionary,
			WizardRunKind runKind, object[] customParams)
		{
			// Store some stuff, so we can use it
			// in both projects. We have to add these only if runKind is 
			// "AsMultiProject" (ie. the first run).
			if (runKind == WizardRunKind.AsMultiProject)
			{
				// GUID is set below, in ProjectFinishedGenerating.
				//_PluginGuid = replacementsDictionary["$guid2$"];
				_PluginName = replacementsDictionary["$projectname$"];
				_SafePluginName = replacementsDictionary["$safeprojectname$"];
			}

			// Better add all our stuff.
			replacementsDictionary.Add("$PluginGuid$", _PluginGuid);
			replacementsDictionary.Add("$PluginName$", _PluginName);
			replacementsDictionary.Add("$SafePluginName$", _SafePluginName);
		}

		public void ProjectFinishedGenerating(Project project)
		{
			// TODO: THIS DOES NOT WORK!!! Need to fix it :(

			// If we already have a GUID, we don't need to be here. I'm 
			// assuming that the plugin itself will be the FIRST project, and
			// the wrapper will be the SECOND one. This'll break if that 
			// changes!
			if (_PluginGuid != string.Empty)
				return;

			// DTE does not expose the project GUID that exists at in the msbuild project file.
			// Cannot use MSBuild object model because it uses a static instance of the Engine, 
			// and using the Project will cause it to be unloaded from the engine when the 
			// GC collects the variable that we declare.
			// Source: http://www.clariusconsulting.net/blogs/kzu/archive/2006/01/06/DteToVSIP.aspx
			using (XmlReader projectReader = XmlReader.Create(project.FileName))
			{
				projectReader.MoveToContent();
				object nodeName = projectReader.NameTable.Add("ProjectGuid");
				while (projectReader.Read())
				{
					if (Object.Equals(projectReader.LocalName, nodeName))
					//if (projectReader.LocalName.Equals(nodeName))
					{
						//projectGuid = projectReader.ReadContentAsString();
						//projectGuid = (string)projectReader.ReadContentAs(typeof(string), null);
						_PluginGuid = projectReader.ReadElementContentAsString();
						break;
					}
				}
			}
		}

		public bool ShouldAddProjectItem(string filePath)
		{
			return true;
		}

		public void RunFinished()
		{
		}

		public void BeforeOpeningFile(ProjectItem projectItem)
		{
		}

		public void ProjectItemFinishedGenerating(ProjectItem projectItem)
		{
		}
	}
}
