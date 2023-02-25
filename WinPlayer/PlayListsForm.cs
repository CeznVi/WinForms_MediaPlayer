using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinPlayer.Playlist;

namespace WinPlayer
{
    public partial class PlayListsForm : Form
    {
        private MainForm _parentForm;
        private ToolStripMenuItem _currentToolStripMenuItem;
        public PlayListsForm(MainForm mainForm)
        {
            this._parentForm = mainForm;
            InitializeComponent();
        }

        private void PlayListsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void PlayListsForm_Load(object sender, EventArgs e)
        {
            foreach (var onePlayList in _parentForm.PlayListsController.PlayLists)
            {
                плейлистыToolStripMenuItem.DropDownItems.Add(onePlayList.Name);
                toolStripComboBoxPlayList.Items.Add(onePlayList);
            }
            foreach (ToolStripDropDownItem item in плейлистыToolStripMenuItem.DropDownItems)
            {
                item.Click += Item_Click;
            }
        }

        private void Item_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tmp = (ToolStripMenuItem)sender;

            if (_currentToolStripMenuItem != null)
            {
                _currentToolStripMenuItem.Checked = false;
            }
            tmp.Checked = true;
            _currentToolStripMenuItem = tmp;
            toolStripStatusLabelInfo.Text = $"Текущий плейлист: {tmp.Text}";
            listBoxMediaRecords.Items.Clear();

            foreach (PlayList item in _parentForm.PlayListsController.PlayLists)
            {
                if (item.Name == tmp.Text)
                {
                    foreach (var oneRecord in item.MediaRecords)
                    {
                        listBoxMediaRecords.Items.Add(oneRecord);
                    }
                    toolStripComboBoxPlayList.SelectedItem = item;
                }
            }
        }

        private void toolStripComboBoxPlayList_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlayList tmp = ((PlayList)toolStripComboBoxPlayList.SelectedItem);

            listBoxMediaRecords.Items.Clear();
            foreach (var oneRecord in tmp.MediaRecords)
            {
                listBoxMediaRecords.Items.Add(oneRecord);
            }
            toolStripStatusLabelInfo.Text = $"Текущий плейлист: {tmp.Name}";

            foreach (ToolStripMenuItem item in плейлистыToolStripMenuItem.DropDownItems)
            {
                if (item.Text == tmp.Name)
                {
                    item.Checked = true;
                    if (_currentToolStripMenuItem != null)
                    {
                        _currentToolStripMenuItem.Checked = false;
                    }
                    _currentToolStripMenuItem = item;
                }
            }
        }

        private void listBoxMediaRecords_DoubleClick(object sender, EventArgs e)
        {
            _parentForm.MediaPlayer.URL = ((MediaRecord)listBoxMediaRecords.SelectedItem).Path;
        }

        private void toolStripButtonCreatePlayList_Click(object sender, EventArgs e)
        {
            NewEditPlayListForm newEditPlayListForm = new NewEditPlayListForm();
            if (newEditPlayListForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(newEditPlayListForm.PlayListName);
            }
        }

        private void toolStripButtonEditPlayList_Click(object sender, EventArgs e)
        {
            if (toolStripComboBoxPlayList.SelectedItem != null)
            {
                NewEditPlayListForm newEditPlayListForm = new NewEditPlayListForm(toolStripComboBoxPlayList.SelectedItem.ToString());
                if (newEditPlayListForm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show(newEditPlayListForm.PlayListName);
                }
            }
        }

        private void buttonAddMediaRecord_Click(object sender, EventArgs e)
        {
            if (toolStripComboBoxPlayList.SelectedItem != null)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                //openFileDialog.Filter = "All Media Files|*.wav;*.aac;*.wma;*.wmv;*.avi;*.mpg;*.mpeg;*.m1v;*.mp2;*.mp3;*.mpa;*.mpe;*.m3u;*.mp4;*.mov;*.3g2;*.3gp2;*.3gp;*.3gpp;*.m4a;*.cda;*.aif;*.aifc;*.aiff;*.mid;*.midi;*.rmi;*.mkv;*.WAV;*.AAC;*.WMA;*.WMV;*.AVI;*.MPG;*.MPEG;*.M1V;*.MP2;*.MP3;*.MPA;*.MPE;*.M3U;*.MP4;*.MOV;*.3G2;*.3GP2;*.3GP;*.3GPP;*.M4A;*.CDA;*.AIF;*.AIFC;*.AIFF;*.MID;*.MIDI;*.RMI;*.MKV"; 
                //openFileDialog.InitialDirectory
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //MessageBox.Show(openFileDialog.FileName);
                    PlayList tmp = ((PlayList)toolStripComboBoxPlayList.SelectedItem);
                    tmp.MediaRecords.Add(new MediaRecord(openFileDialog.FileName));
                    listBoxMediaRecords.Items.Add(tmp.MediaRecords.Last());
                    _parentForm.PlayListsController.AddNewMediaRecord(tmp.MediaRecords.Last(), tmp);
                }
            }
        }
    }
}
