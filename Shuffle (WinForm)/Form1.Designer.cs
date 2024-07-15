namespace Shuffle_WinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbNums = new ListBox();
            lbAfter = new ListBox();
            toolStrip1 = new ToolStrip();
            tssbOpenFolder = new ToolStripSplitButton();
            tsmiOpenFolder = new ToolStripMenuItem();
            tsmiOpenFile = new ToolStripMenuItem();
            tsbGenerateNums = new ToolStripButton();
            tsbConcat = new ToolStripButton();
            tssbSave = new ToolStripSplitButton();
            saveToolStripMenuItem = new ToolStripMenuItem();
            tsmiSaveAs = new ToolStripMenuItem();
            lbLoaded = new ListBox();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lbNums
            // 
            lbNums.FormattingEnabled = true;
            lbNums.ItemHeight = 15;
            lbNums.Location = new Point(138, 28);
            lbNums.Name = "lbNums";
            lbNums.Size = new Size(120, 409);
            lbNums.TabIndex = 2;
            // 
            // lbAfter
            // 
            lbAfter.FormattingEnabled = true;
            lbAfter.HorizontalScrollbar = true;
            lbAfter.ItemHeight = 15;
            lbAfter.Location = new Point(264, 28);
            lbAfter.Name = "lbAfter";
            lbAfter.Size = new Size(120, 409);
            lbAfter.TabIndex = 3;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tssbOpenFolder, tsbGenerateNums, tsbConcat, tssbSave });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(396, 25);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // tssbOpenFolder
            // 
            tssbOpenFolder.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tssbOpenFolder.DropDownItems.AddRange(new ToolStripItem[] { tsmiOpenFolder, tsmiOpenFile });
            tssbOpenFolder.Image = (Image)resources.GetObject("tssbOpenFolder.Image");
            tssbOpenFolder.ImageTransparentColor = Color.Magenta;
            tssbOpenFolder.Name = "tssbOpenFolder";
            tssbOpenFolder.Size = new Size(32, 22);
            tssbOpenFolder.Text = "Open Folder";
            tssbOpenFolder.ButtonClick += tsmiOpenFolder_Click;
            // 
            // tsmiOpenFolder
            // 
            tsmiOpenFolder.Name = "tsmiOpenFolder";
            tsmiOpenFolder.Size = new Size(139, 22);
            tsmiOpenFolder.Text = "Open Folder";
            tsmiOpenFolder.Click += tsmiOpenFolder_Click;
            // 
            // tsmiOpenFile
            // 
            tsmiOpenFile.Name = "tsmiOpenFile";
            tsmiOpenFile.Size = new Size(139, 22);
            tsmiOpenFile.Text = "Open Files";
            tsmiOpenFile.Click += tsmiOpenFile_Click;
            // 
            // tsbGenerateNums
            // 
            tsbGenerateNums.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbGenerateNums.Enabled = false;
            tsbGenerateNums.Image = (Image)resources.GetObject("tsbGenerateNums.Image");
            tsbGenerateNums.ImageTransparentColor = Color.Magenta;
            tsbGenerateNums.Name = "tsbGenerateNums";
            tsbGenerateNums.Size = new Size(23, 22);
            tsbGenerateNums.Text = "Generate Numbers";
            tsbGenerateNums.Click += tsbGenerateNums_Click;
            // 
            // tsbConcat
            // 
            tsbConcat.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbConcat.Enabled = false;
            tsbConcat.Image = (Image)resources.GetObject("tsbConcat.Image");
            tsbConcat.ImageTransparentColor = Color.Magenta;
            tsbConcat.Name = "tsbConcat";
            tsbConcat.Size = new Size(23, 22);
            tsbConcat.Text = "Concat";
            tsbConcat.Click += tsbConcat_Click;
            // 
            // tssbSave
            // 
            tssbSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tssbSave.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, tsmiSaveAs });
            tssbSave.Enabled = false;
            tssbSave.Image = (Image)resources.GetObject("tssbSave.Image");
            tssbSave.ImageTransparentColor = Color.Magenta;
            tssbSave.Name = "tssbSave";
            tssbSave.Size = new Size(32, 22);
            tssbSave.Text = "Save";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(180, 22);
            saveToolStripMenuItem.Text = "Replace";
            saveToolStripMenuItem.Click += tsmiSave_Click;
            // 
            // tsmiSaveAs
            // 
            tsmiSaveAs.Name = "tsmiSaveAs";
            tsmiSaveAs.Size = new Size(180, 22);
            tsmiSaveAs.Text = "Copy";
            tsmiSaveAs.Click += tsmiSaveAs_Click;
            // 
            // lbLoaded
            // 
            lbLoaded.DataSource = lbNums.CustomTabOffsets;
            lbLoaded.FormattingEnabled = true;
            lbLoaded.HorizontalScrollbar = true;
            lbLoaded.ItemHeight = 15;
            lbLoaded.Location = new Point(12, 28);
            lbLoaded.Name = "lbLoaded";
            lbLoaded.Size = new Size(120, 409);
            lbLoaded.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 450);
            Controls.Add(lbLoaded);
            Controls.Add(toolStrip1);
            Controls.Add(lbAfter);
            Controls.Add(lbNums);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Shuffle";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox lbNums;
        private ListBox lbAfter;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton tsddbOpenFolder;
        private ToolStripMenuItem tsmiOpenFolder;
        private ToolStripMenuItem tsmiOpenFile;
        private ToolStripButton tsbGenerateNums;
        private ToolStripButton tsbConcat;
        private ToolStripSplitButton tssbOpenFolder;
        private ListBox lbLoaded;
        private ToolStripSplitButton tssbSave;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem tsmiSaveAs;
    }
}
