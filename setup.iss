[Setup]
OutputDir=C:\Users\Daniel\Documents\Visual Studio 2008\Projects\Winamp\Setup
VersionInfoVersion=1.0.0.0
VersionInfoCompany=Daniel15
VersionInfoDescription=Sharpamp
VersionInfoCopyright=©2009 Daniel15
VersionInfoProductName=Sharpamp
VersionInfoProductVersion=1.0.0.0
AppCopyright=©2009 Daniel15
AppName=Sharpamp
AppVerName=Sharpamp 1.0 Beta
DefaultDirName={pf}\Sharpamp
DefaultGroupName=Winamp\Sharpamp
AppPublisher=Daniel15
AppPublisherURL=http://d15.biz/
AppSupportURL=http://code.google.com/p/sharpamp/
AppUpdatesURL=http://code.google.com/p/sharpamp/
AppVersion=1.0 Beta
AppID=Sharpamp 1.0 Beta
UninstallDisplayName=Sharpamp
[Files]
Source: Sharpamp\bin\Release\Daniel15.Sharpamp.dll; DestDir: {app}; Flags: gacinstall; StrongAssemblyName: Daniel15.Sharpamp
Source: Samples\HelloWorldGUI\Debug\gen_HelloWorldGUI.dll; DestDir: {app}\Samples\HelloWorldGUI\Debug
Source: Samples\HelloWorldGUI\Debug\HelloWorldGUI.dll; DestDir: {app}\Samples\HelloWorldGUI\Debug
Source: Samples\HelloWorldGUI\HelloWorldGUI\gen_HelloWorldGUI\AssemblyInfo.cpp; DestDir: {app}\Samples\HelloWorldGUI\HelloWorldGUI\gen_HelloWorldGUI
Source: Samples\HelloWorldGUI\HelloWorldGUI\gen_HelloWorldGUI\gen_HelloWorldGUI.cpp; DestDir: {app}\Samples\HelloWorldGUI\HelloWorldGUI\gen_HelloWorldGUI
Source: Samples\HelloWorldGUI\HelloWorldGUI\gen_HelloWorldGUI\gen_HelloWorldGUI.h; DestDir: {app}\Samples\HelloWorldGUI\HelloWorldGUI\gen_HelloWorldGUI
Source: Samples\HelloWorldGUI\HelloWorldGUI\gen_HelloWorldGUI\gen_HelloWorldGUI.vcproj; DestDir: {app}\Samples\HelloWorldGUI\HelloWorldGUI\gen_HelloWorldGUI
Source: Samples\HelloWorldGUI\HelloWorldGUI\gen_HelloWorldGUI\PluginWrapper.cpp; DestDir: {app}\Samples\HelloWorldGUI\HelloWorldGUI\gen_HelloWorldGUI
Source: Samples\HelloWorldGUI\HelloWorldGUI\gen_HelloWorldGUI\PluginWrapper.h; DestDir: {app}\Samples\HelloWorldGUI\HelloWorldGUI\gen_HelloWorldGUI
Source: Samples\HelloWorldGUI\HelloWorldGUI\gen_HelloWorldGUI\Stdafx.cpp; DestDir: {app}\Samples\HelloWorldGUI\HelloWorldGUI\gen_HelloWorldGUI
Source: Samples\HelloWorldGUI\HelloWorldGUI\gen_HelloWorldGUI\Stdafx.h; DestDir: {app}\Samples\HelloWorldGUI\HelloWorldGUI\gen_HelloWorldGUI
Source: Samples\HelloWorldGUI\HelloWorldGUI\HelloWorldGUI\Properties\AssemblyInfo.cs; DestDir: {app}\Samples\HelloWorldGUI\HelloWorldGUI\HelloWorldGUI\Properties
Source: Samples\HelloWorldGUI\HelloWorldGUI\HelloWorldGUI\frmTest.cs; DestDir: {app}\Samples\HelloWorldGUI\HelloWorldGUI\HelloWorldGUI
Source: Samples\HelloWorldGUI\HelloWorldGUI\HelloWorldGUI\frmTest.Designer.cs; DestDir: {app}\Samples\HelloWorldGUI\HelloWorldGUI\HelloWorldGUI
Source: Samples\HelloWorldGUI\HelloWorldGUI\HelloWorldGUI\frmTest.resx; DestDir: {app}\Samples\HelloWorldGUI\HelloWorldGUI\HelloWorldGUI
Source: Samples\HelloWorldGUI\HelloWorldGUI\HelloWorldGUI\HelloWorldGUI.cs; DestDir: {app}\Samples\HelloWorldGUI\HelloWorldGUI\HelloWorldGUI
Source: Samples\HelloWorldGUI\HelloWorldGUI\HelloWorldGUI\HelloWorldGUI.csproj; DestDir: {app}\Samples\HelloWorldGUI\HelloWorldGUI\HelloWorldGUI
Source: Samples\HelloWorldGUI\HelloWorldGUI.sln; DestDir: {app}\Samples\HelloWorldGUI
Source: Templates\GeneralPluginTemplate\WinampPlugin.zip; DestDir: {userdocs}\Visual Studio 2008\Templates\ProjectTemplates\Visual C#
Source: Templates\GeneralPluginTemplate\WinampPlugin.zip; DestDir: {userdocs}\Visual Studio 2005\Templates\ProjectTemplates\Visual C#
Source: Templates\GeneralPluginTemplate\WinampPlugin.zip; DestDir: {userdocs}\Visual Studio 2010\Templates\ProjectTemplates\Visual C#
Source: Templates\GeneralPluginWizard\bin\Release\Daniel15.Sharpamp.GeneralPluginWizard.dll; DestDir: {app}; StrongAssemblyName: Daniel15.Sharpamp.GeneralPluginWizard; Flags: gacinstall
[Dirs]
Name: {app}\Samples
[Registry]
Root: HKLM; Subkey: SOFTWARE\Microsoft\.NETFramework\AssemblyFolders\Sharpamp; ValueType: string; ValueData: {app}
Root: HKLM; Subkey: SOFTWARE\Wow6432Node\Microsoft\.NETFramework\AssemblyFolders\Sharpamp; ValueType: string; ValueData: {app}
