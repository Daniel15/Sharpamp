namespace HelloWorldGUI
{
	partial class frmTest
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtLog = new System.Windows.Forms.TextBox();
			this.grpCurrentlyPlaying = new System.Windows.Forms.GroupBox();
			this.lblHasMetadata = new System.Windows.Forms.Label();
			this.lblFilename = new System.Windows.Forms.Label();
			this.lblYear = new System.Windows.Forms.Label();
			this.lblAlbum = new System.Windows.Forms.Label();
			this.lblArtist = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.tableButtons = new System.Windows.Forms.TableLayoutPanel();
			this.cmdStop = new System.Windows.Forms.Button();
			this.cmdPlay = new System.Windows.Forms.Button();
			this.cmdNext = new System.Windows.Forms.Button();
			this.cmdPrev = new System.Windows.Forms.Button();
			this.lblLog = new System.Windows.Forms.Label();
			this.lblStatus = new System.Windows.Forms.Label();
			this.cmdPlayPause = new System.Windows.Forms.Button();
			this.grpCurrentlyPlaying.SuspendLayout();
			this.tableButtons.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtLog
			// 
			this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtLog.Location = new System.Drawing.Point(12, 192);
			this.txtLog.Multiline = true;
			this.txtLog.Name = "txtLog";
			this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtLog.Size = new System.Drawing.Size(488, 161);
			this.txtLog.TabIndex = 2;
			// 
			// grpCurrentlyPlaying
			// 
			this.grpCurrentlyPlaying.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.grpCurrentlyPlaying.Controls.Add(this.lblStatus);
			this.grpCurrentlyPlaying.Controls.Add(this.lblHasMetadata);
			this.grpCurrentlyPlaying.Controls.Add(this.lblFilename);
			this.grpCurrentlyPlaying.Controls.Add(this.lblYear);
			this.grpCurrentlyPlaying.Controls.Add(this.lblAlbum);
			this.grpCurrentlyPlaying.Controls.Add(this.lblArtist);
			this.grpCurrentlyPlaying.Controls.Add(this.lblTitle);
			this.grpCurrentlyPlaying.Location = new System.Drawing.Point(12, 39);
			this.grpCurrentlyPlaying.Name = "grpCurrentlyPlaying";
			this.grpCurrentlyPlaying.Size = new System.Drawing.Size(487, 129);
			this.grpCurrentlyPlaying.TabIndex = 5;
			this.grpCurrentlyPlaying.TabStop = false;
			this.grpCurrentlyPlaying.Text = "Currently Playing";
			// 
			// lblHasMetadata
			// 
			this.lblHasMetadata.AutoSize = true;
			this.lblHasMetadata.Location = new System.Drawing.Point(6, 16);
			this.lblHasMetadata.Name = "lblHasMetadata";
			this.lblHasMetadata.Size = new System.Drawing.Size(97, 13);
			this.lblHasMetadata.TabIndex = 5;
			this.lblHasMetadata.Text = "Has Metadata? No";
			// 
			// lblFilename
			// 
			this.lblFilename.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lblFilename.Location = new System.Drawing.Point(6, 86);
			this.lblFilename.Name = "lblFilename";
			this.lblFilename.Size = new System.Drawing.Size(475, 40);
			this.lblFilename.TabIndex = 4;
			this.lblFilename.Text = "Filename";
			// 
			// lblYear
			// 
			this.lblYear.AutoSize = true;
			this.lblYear.Location = new System.Drawing.Point(6, 73);
			this.lblYear.Name = "lblYear";
			this.lblYear.Size = new System.Drawing.Size(29, 13);
			this.lblYear.TabIndex = 3;
			this.lblYear.Text = "Year";
			// 
			// lblAlbum
			// 
			this.lblAlbum.AutoSize = true;
			this.lblAlbum.Location = new System.Drawing.Point(6, 60);
			this.lblAlbum.Name = "lblAlbum";
			this.lblAlbum.Size = new System.Drawing.Size(36, 13);
			this.lblAlbum.TabIndex = 2;
			this.lblAlbum.Text = "Album";
			// 
			// lblArtist
			// 
			this.lblArtist.AutoSize = true;
			this.lblArtist.Location = new System.Drawing.Point(6, 47);
			this.lblArtist.Name = "lblArtist";
			this.lblArtist.Size = new System.Drawing.Size(30, 13);
			this.lblArtist.TabIndex = 1;
			this.lblArtist.Text = "Artist";
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Location = new System.Drawing.Point(6, 34);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(27, 13);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Title";
			// 
			// tableButtons
			// 
			this.tableButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tableButtons.ColumnCount = 5;
			this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableButtons.Controls.Add(this.cmdStop, 0, 0);
			this.tableButtons.Controls.Add(this.cmdPlay, 0, 0);
			this.tableButtons.Controls.Add(this.cmdNext, 4, 0);
			this.tableButtons.Controls.Add(this.cmdPrev, 3, 0);
			this.tableButtons.Controls.Add(this.cmdPlayPause, 2, 0);
			this.tableButtons.Location = new System.Drawing.Point(12, 7);
			this.tableButtons.Name = "tableButtons";
			this.tableButtons.RowCount = 1;
			this.tableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableButtons.Size = new System.Drawing.Size(488, 32);
			this.tableButtons.TabIndex = 6;
			// 
			// cmdStop
			// 
			this.cmdStop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.cmdStop.Location = new System.Drawing.Point(100, 3);
			this.cmdStop.Name = "cmdStop";
			this.cmdStop.Size = new System.Drawing.Size(91, 26);
			this.cmdStop.TabIndex = 2;
			this.cmdStop.Text = "Stop";
			this.cmdStop.UseVisualStyleBackColor = true;
			this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
			// 
			// cmdPlay
			// 
			this.cmdPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.cmdPlay.Location = new System.Drawing.Point(3, 3);
			this.cmdPlay.Name = "cmdPlay";
			this.cmdPlay.Size = new System.Drawing.Size(91, 26);
			this.cmdPlay.TabIndex = 1;
			this.cmdPlay.Text = "Play";
			this.cmdPlay.UseVisualStyleBackColor = true;
			this.cmdPlay.Click += new System.EventHandler(this.cmdPlay_Click);
			// 
			// cmdNext
			// 
			this.cmdNext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.cmdNext.Location = new System.Drawing.Point(391, 3);
			this.cmdNext.Name = "cmdNext";
			this.cmdNext.Size = new System.Drawing.Size(94, 26);
			this.cmdNext.TabIndex = 6;
			this.cmdNext.Text = "Next Track";
			this.cmdNext.UseVisualStyleBackColor = true;
			this.cmdNext.Click += new System.EventHandler(this.cmdNext_Click);
			// 
			// cmdPrev
			// 
			this.cmdPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.cmdPrev.Location = new System.Drawing.Point(294, 3);
			this.cmdPrev.Name = "cmdPrev";
			this.cmdPrev.Size = new System.Drawing.Size(91, 26);
			this.cmdPrev.TabIndex = 4;
			this.cmdPrev.Text = "Previous Track";
			this.cmdPrev.UseVisualStyleBackColor = true;
			this.cmdPrev.Click += new System.EventHandler(this.cmdPrev_Click);
			// 
			// lblLog
			// 
			this.lblLog.AutoSize = true;
			this.lblLog.Location = new System.Drawing.Point(12, 175);
			this.lblLog.Name = "lblLog";
			this.lblLog.Size = new System.Drawing.Size(28, 13);
			this.lblLog.TabIndex = 7;
			this.lblLog.Text = "Log:";
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new System.Drawing.Point(130, 16);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(37, 13);
			this.lblStatus.TabIndex = 6;
			this.lblStatus.Text = "Status";
			// 
			// cmdPlayPause
			// 
			this.cmdPlayPause.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.cmdPlayPause.Location = new System.Drawing.Point(197, 3);
			this.cmdPlayPause.Name = "cmdPlayPause";
			this.cmdPlayPause.Size = new System.Drawing.Size(91, 26);
			this.cmdPlayPause.TabIndex = 7;
			this.cmdPlayPause.Text = "Play/Pause";
			this.cmdPlayPause.UseVisualStyleBackColor = true;
			this.cmdPlayPause.Click += new System.EventHandler(this.cmdPlayPause_Click);
			// 
			// frmTest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(511, 365);
			this.Controls.Add(this.lblLog);
			this.Controls.Add(this.tableButtons);
			this.Controls.Add(this.grpCurrentlyPlaying);
			this.Controls.Add(this.txtLog);
			this.Name = "frmTest";
			this.Text = "Test Winamp Plugin";
			this.Load += new System.EventHandler(this.frmTest_Load);
			this.grpCurrentlyPlaying.ResumeLayout(false);
			this.grpCurrentlyPlaying.PerformLayout();
			this.tableButtons.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtLog;
		private System.Windows.Forms.GroupBox grpCurrentlyPlaying;
		private System.Windows.Forms.Label lblArtist;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblYear;
		private System.Windows.Forms.Label lblAlbum;
		private System.Windows.Forms.Label lblHasMetadata;
		private System.Windows.Forms.Label lblFilename;
		private System.Windows.Forms.TableLayoutPanel tableButtons;
		private System.Windows.Forms.Button cmdPrev;
		private System.Windows.Forms.Button cmdStop;
		private System.Windows.Forms.Button cmdPlay;
		private System.Windows.Forms.Button cmdNext;
		private System.Windows.Forms.Label lblLog;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.Button cmdPlayPause;
	}
}