namespace VSFolderCleanup
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.builderTextBox1 = new WinForms.Library.Controls.BuilderTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbFolders = new System.Windows.Forms.ListBox();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Use this to reclaim disk space used unnecessarily by Visual Studio projects.";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(389, 279);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // builderTextBox1
            // 
            this.builderTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.builderTextBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.builderTextBox1.Location = new System.Drawing.Point(15, 60);
            this.builderTextBox1.Name = "builderTextBox1";
            this.builderTextBox1.Size = new System.Drawing.Size(449, 26);
            this.builderTextBox1.Suggestions = null;
            this.builderTextBox1.TabIndex = 2;
            this.builderTextBox1.Value = "";
            this.builderTextBox1.BuilderClicked += new WinForms.Library.Controls.BuilderEventHandler(this.builderTextBox1_BuilderClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select a path containing Visual Studio projects:";
            // 
            // lbFolders
            // 
            this.lbFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFolders.FormattingEnabled = true;
            this.lbFolders.Location = new System.Drawing.Point(15, 92);
            this.lbFolders.Name = "lbFolders";
            this.lbFolders.Size = new System.Drawing.Size(449, 173);
            this.lbFolders.TabIndex = 4;
            this.lbFolders.DoubleClick += new System.EventHandler(this.lbFolders_DoubleClick);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteAll.Location = new System.Drawing.Point(266, 279);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(117, 23);
            this.btnDeleteAll.TabIndex = 5;
            this.btnDeleteAll.Text = "Delete Folders";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 314);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.lbFolders);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.builderTextBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VS Folder Cleanup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private WinForms.Library.Controls.BuilderTextBox builderTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbFolders;
        private System.Windows.Forms.Button btnDeleteAll;
    }
}

