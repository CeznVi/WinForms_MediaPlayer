namespace WindowsMediaPlayer
{
    partial class PlayListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayListForm));
            this.menuStrip_PlayList = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.плейлистыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_PlayList = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonCreatePlayList = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditPlayList = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.panelMediaControls = new System.Windows.Forms.Panel();
            this.buttonRemoveMediaRecord = new System.Windows.Forms.Button();
            this.buttonEditMediaRecords = new System.Windows.Forms.Button();
            this.buttonAddMediaRecord = new System.Windows.Forms.Button();
            this.listBoxMediaRecords = new System.Windows.Forms.ListBox();
            this.menuStrip_PlayList.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panelMediaControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_PlayList
            // 
            this.menuStrip_PlayList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.плейлистыToolStripMenuItem});
            this.menuStrip_PlayList.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_PlayList.Name = "menuStrip_PlayList";
            this.menuStrip_PlayList.Size = new System.Drawing.Size(460, 24);
            this.menuStrip_PlayList.TabIndex = 0;
            this.menuStrip_PlayList.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // плейлистыToolStripMenuItem
            // 
            this.плейлистыToolStripMenuItem.Name = "плейлистыToolStripMenuItem";
            this.плейлистыToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.плейлистыToolStripMenuItem.Text = "Плейлисты";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_PlayList});
            this.statusStrip1.Location = new System.Drawing.Point(0, 454);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(460, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_PlayList
            // 
            this.toolStripStatusLabel_PlayList.Name = "toolStripStatusLabel_PlayList";
            this.toolStripStatusLabel_PlayList.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel_PlayList.Text = "Status";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonCreatePlayList,
            this.toolStripButtonEditPlayList,
            this.toolStripButtonDelete,
            this.toolStripComboBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(460, 43);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip_PlayList";
            // 
            // toolStripButtonCreatePlayList
            // 
            this.toolStripButtonCreatePlayList.AutoSize = false;
            this.toolStripButtonCreatePlayList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCreatePlayList.BackgroundImage")));
            this.toolStripButtonCreatePlayList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButtonCreatePlayList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCreatePlayList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCreatePlayList.Name = "toolStripButtonCreatePlayList";
            this.toolStripButtonCreatePlayList.Size = new System.Drawing.Size(40, 40);
            this.toolStripButtonCreatePlayList.Text = "toolStripButton1";
            // 
            // toolStripButtonEditPlayList
            // 
            this.toolStripButtonEditPlayList.AutoSize = false;
            this.toolStripButtonEditPlayList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEditPlayList.BackgroundImage")));
            this.toolStripButtonEditPlayList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButtonEditPlayList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditPlayList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditPlayList.Name = "toolStripButtonEditPlayList";
            this.toolStripButtonEditPlayList.Size = new System.Drawing.Size(40, 40);
            this.toolStripButtonEditPlayList.Text = "toolStripButton1";
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.AutoSize = false;
            this.toolStripButtonDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.BackgroundImage")));
            this.toolStripButtonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(40, 40);
            this.toolStripButtonDelete.Text = "toolStripButton1";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 43);
            // 
            // panelMediaControls
            // 
            this.panelMediaControls.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelMediaControls.Controls.Add(this.buttonRemoveMediaRecord);
            this.panelMediaControls.Controls.Add(this.buttonEditMediaRecords);
            this.panelMediaControls.Controls.Add(this.buttonAddMediaRecord);
            this.panelMediaControls.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMediaControls.Location = new System.Drawing.Point(366, 67);
            this.panelMediaControls.Name = "panelMediaControls";
            this.panelMediaControls.Size = new System.Drawing.Size(94, 387);
            this.panelMediaControls.TabIndex = 3;
            // 
            // buttonRemoveMediaRecord
            // 
            this.buttonRemoveMediaRecord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRemoveMediaRecord.BackgroundImage")));
            this.buttonRemoveMediaRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRemoveMediaRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRemoveMediaRecord.Location = new System.Drawing.Point(0, 180);
            this.buttonRemoveMediaRecord.Name = "buttonRemoveMediaRecord";
            this.buttonRemoveMediaRecord.Padding = new System.Windows.Forms.Padding(5);
            this.buttonRemoveMediaRecord.Size = new System.Drawing.Size(94, 90);
            this.buttonRemoveMediaRecord.TabIndex = 2;
            this.buttonRemoveMediaRecord.UseVisualStyleBackColor = true;
            // 
            // buttonEditMediaRecords
            // 
            this.buttonEditMediaRecords.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEditMediaRecords.BackgroundImage")));
            this.buttonEditMediaRecords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEditMediaRecords.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEditMediaRecords.Location = new System.Drawing.Point(0, 90);
            this.buttonEditMediaRecords.Name = "buttonEditMediaRecords";
            this.buttonEditMediaRecords.Padding = new System.Windows.Forms.Padding(5);
            this.buttonEditMediaRecords.Size = new System.Drawing.Size(94, 90);
            this.buttonEditMediaRecords.TabIndex = 1;
            this.buttonEditMediaRecords.UseVisualStyleBackColor = true;
            // 
            // buttonAddMediaRecord
            // 
            this.buttonAddMediaRecord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAddMediaRecord.BackgroundImage")));
            this.buttonAddMediaRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddMediaRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddMediaRecord.Location = new System.Drawing.Point(0, 0);
            this.buttonAddMediaRecord.Name = "buttonAddMediaRecord";
            this.buttonAddMediaRecord.Padding = new System.Windows.Forms.Padding(5);
            this.buttonAddMediaRecord.Size = new System.Drawing.Size(94, 90);
            this.buttonAddMediaRecord.TabIndex = 0;
            this.buttonAddMediaRecord.UseVisualStyleBackColor = true;
            // 
            // listBoxMediaRecords
            // 
            this.listBoxMediaRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxMediaRecords.FormattingEnabled = true;
            this.listBoxMediaRecords.Location = new System.Drawing.Point(0, 67);
            this.listBoxMediaRecords.Name = "listBoxMediaRecords";
            this.listBoxMediaRecords.Size = new System.Drawing.Size(366, 387);
            this.listBoxMediaRecords.TabIndex = 4;
            // 
            // PlayListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 476);
            this.Controls.Add(this.listBoxMediaRecords);
            this.Controls.Add(this.panelMediaControls);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip_PlayList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_PlayList;
            this.Name = "PlayListForm";
            this.Text = "PlayListForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlayListForm_FormClosing);
            this.Load += new System.EventHandler(this.PlayListForm_Load);
            this.menuStrip_PlayList.ResumeLayout(false);
            this.menuStrip_PlayList.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelMediaControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_PlayList;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_PlayList;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonCreatePlayList;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditPlayList;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem плейлистыToolStripMenuItem;
        private System.Windows.Forms.Panel panelMediaControls;
        private System.Windows.Forms.Button buttonRemoveMediaRecord;
        private System.Windows.Forms.Button buttonEditMediaRecords;
        private System.Windows.Forms.Button buttonAddMediaRecord;
        private System.Windows.Forms.ListBox listBoxMediaRecords;
    }
}