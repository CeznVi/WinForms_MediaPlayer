namespace WinPlayer
{
    partial class PlayListsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayListsForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.плейлистыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripPlaylists = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonCreatePlayList = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditPlayList = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRemovePlayList = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBoxPlayList = new System.Windows.Forms.ToolStripComboBox();
            this.panelMediaControls = new System.Windows.Forms.Panel();
            this.buttonRemoveMediaRecord = new System.Windows.Forms.Button();
            this.buttonEditMediaRecord = new System.Windows.Forms.Button();
            this.buttonAddMediaRecord = new System.Windows.Forms.Button();
            this.listBoxMediaRecords = new System.Windows.Forms.ListBox();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.toolStripPlaylists.SuspendLayout();
            this.panelMediaControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.плейлистыToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(384, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
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
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelInfo});
            this.statusStrip.Location = new System.Drawing.Point(0, 451);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(384, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelInfo
            // 
            this.toolStripStatusLabelInfo.Name = "toolStripStatusLabelInfo";
            this.toolStripStatusLabelInfo.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabelInfo.Text = "Status";
            // 
            // toolStripPlaylists
            // 
            this.toolStripPlaylists.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonCreatePlayList,
            this.toolStripButtonEditPlayList,
            this.toolStripButtonRemovePlayList,
            this.toolStripComboBoxPlayList});
            this.toolStripPlaylists.Location = new System.Drawing.Point(0, 24);
            this.toolStripPlaylists.Name = "toolStripPlaylists";
            this.toolStripPlaylists.Size = new System.Drawing.Size(384, 46);
            this.toolStripPlaylists.TabIndex = 2;
            this.toolStripPlaylists.Text = "toolStrip1";
            // 
            // toolStripButtonCreatePlayList
            // 
            this.toolStripButtonCreatePlayList.AutoSize = false;
            this.toolStripButtonCreatePlayList.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonCreatePlayList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCreatePlayList.BackgroundImage")));
            this.toolStripButtonCreatePlayList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButtonCreatePlayList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCreatePlayList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCreatePlayList.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripButtonCreatePlayList.Name = "toolStripButtonCreatePlayList";
            this.toolStripButtonCreatePlayList.Size = new System.Drawing.Size(40, 40);
            this.toolStripButtonCreatePlayList.Text = "Создать плейлист";
            this.toolStripButtonCreatePlayList.Click += new System.EventHandler(this.toolStripButtonCreatePlayList_Click);
            // 
            // toolStripButtonEditPlayList
            // 
            this.toolStripButtonEditPlayList.AutoSize = false;
            this.toolStripButtonEditPlayList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEditPlayList.BackgroundImage")));
            this.toolStripButtonEditPlayList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButtonEditPlayList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditPlayList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditPlayList.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripButtonEditPlayList.Name = "toolStripButtonEditPlayList";
            this.toolStripButtonEditPlayList.Size = new System.Drawing.Size(40, 40);
            this.toolStripButtonEditPlayList.Text = "Переименовать плейлист";
            this.toolStripButtonEditPlayList.Click += new System.EventHandler(this.toolStripButtonEditPlayList_Click);
            // 
            // toolStripButtonRemovePlayList
            // 
            this.toolStripButtonRemovePlayList.AutoSize = false;
            this.toolStripButtonRemovePlayList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRemovePlayList.BackgroundImage")));
            this.toolStripButtonRemovePlayList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButtonRemovePlayList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRemovePlayList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRemovePlayList.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripButtonRemovePlayList.Name = "toolStripButtonRemovePlayList";
            this.toolStripButtonRemovePlayList.Size = new System.Drawing.Size(40, 40);
            this.toolStripButtonRemovePlayList.Text = "Удалить плейлист";
            this.toolStripButtonRemovePlayList.Click += new System.EventHandler(this.toolStripButtonRemovePlayList_Click);
            // 
            // toolStripComboBoxPlayList
            // 
            this.toolStripComboBoxPlayList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxPlayList.Name = "toolStripComboBoxPlayList";
            this.toolStripComboBoxPlayList.Size = new System.Drawing.Size(121, 46);
            this.toolStripComboBoxPlayList.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxPlayList_SelectedIndexChanged);
            // 
            // panelMediaControls
            // 
            this.panelMediaControls.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelMediaControls.Controls.Add(this.buttonRemoveMediaRecord);
            this.panelMediaControls.Controls.Add(this.buttonEditMediaRecord);
            this.panelMediaControls.Controls.Add(this.buttonAddMediaRecord);
            this.panelMediaControls.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMediaControls.Location = new System.Drawing.Point(314, 70);
            this.panelMediaControls.Name = "panelMediaControls";
            this.panelMediaControls.Padding = new System.Windows.Forms.Padding(3);
            this.panelMediaControls.Size = new System.Drawing.Size(70, 381);
            this.panelMediaControls.TabIndex = 3;
            // 
            // buttonRemoveMediaRecord
            // 
            this.buttonRemoveMediaRecord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRemoveMediaRecord.BackgroundImage")));
            this.buttonRemoveMediaRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRemoveMediaRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRemoveMediaRecord.Location = new System.Drawing.Point(3, 131);
            this.buttonRemoveMediaRecord.Name = "buttonRemoveMediaRecord";
            this.buttonRemoveMediaRecord.Size = new System.Drawing.Size(64, 64);
            this.buttonRemoveMediaRecord.TabIndex = 2;
            this.buttonRemoveMediaRecord.UseVisualStyleBackColor = true;
            this.buttonRemoveMediaRecord.Click += new System.EventHandler(this.buttonRemoveMediaRecord_Click);
            // 
            // buttonEditMediaRecord
            // 
            this.buttonEditMediaRecord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEditMediaRecord.BackgroundImage")));
            this.buttonEditMediaRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEditMediaRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEditMediaRecord.Location = new System.Drawing.Point(3, 67);
            this.buttonEditMediaRecord.Name = "buttonEditMediaRecord";
            this.buttonEditMediaRecord.Size = new System.Drawing.Size(64, 64);
            this.buttonEditMediaRecord.TabIndex = 1;
            this.buttonEditMediaRecord.UseVisualStyleBackColor = true;
            // 
            // buttonAddMediaRecord
            // 
            this.buttonAddMediaRecord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAddMediaRecord.BackgroundImage")));
            this.buttonAddMediaRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddMediaRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddMediaRecord.Location = new System.Drawing.Point(3, 3);
            this.buttonAddMediaRecord.Name = "buttonAddMediaRecord";
            this.buttonAddMediaRecord.Size = new System.Drawing.Size(64, 64);
            this.buttonAddMediaRecord.TabIndex = 0;
            this.buttonAddMediaRecord.UseVisualStyleBackColor = true;
            this.buttonAddMediaRecord.Click += new System.EventHandler(this.buttonAddMediaRecord_Click);
            // 
            // listBoxMediaRecords
            // 
            this.listBoxMediaRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxMediaRecords.FormattingEnabled = true;
            this.listBoxMediaRecords.Location = new System.Drawing.Point(0, 70);
            this.listBoxMediaRecords.Name = "listBoxMediaRecords";
            this.listBoxMediaRecords.Size = new System.Drawing.Size(314, 381);
            this.listBoxMediaRecords.TabIndex = 4;
            this.listBoxMediaRecords.DoubleClick += new System.EventHandler(this.listBoxMediaRecords_DoubleClick);
            // 
            // PlayListsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 473);
            this.Controls.Add(this.listBoxMediaRecords);
            this.Controls.Add(this.panelMediaControls);
            this.Controls.Add(this.toolStripPlaylists);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "PlayListsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PlayListsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlayListsForm_FormClosing);
            this.Load += new System.EventHandler(this.PlayListsForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStripPlaylists.ResumeLayout(false);
            this.toolStripPlaylists.PerformLayout();
            this.panelMediaControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem плейлистыToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelInfo;
        private System.Windows.Forms.ToolStrip toolStripPlaylists;
        private System.Windows.Forms.ToolStripButton toolStripButtonCreatePlayList;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditPlayList;
        private System.Windows.Forms.ToolStripButton toolStripButtonRemovePlayList;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxPlayList;
        private System.Windows.Forms.Panel panelMediaControls;
        private System.Windows.Forms.Button buttonRemoveMediaRecord;
        private System.Windows.Forms.Button buttonEditMediaRecord;
        private System.Windows.Forms.Button buttonAddMediaRecord;
        private System.Windows.Forms.ListBox listBoxMediaRecords;
    }
}