using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using WinPlayer.Playlist;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;


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
                    if (_currentToolStripMenuItem != null && item != _currentToolStripMenuItem)
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

        /// <summary>
        /// Создать плейлист
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButtonCreatePlayList_Click(object sender, EventArgs e)
        {
            NewEditPlayListForm newEditPlayListForm = new NewEditPlayListForm();
            if (newEditPlayListForm.ShowDialog() == DialogResult.OK)
            {
                PlayList tmp = new PlayList();
                tmp.Name = newEditPlayListForm.PlayListName;
                tmp.MediaRecords = new List<MediaRecord>();
                _parentForm.PlayListsController.AddNewPlayList(tmp);

                toolStripComboBoxPlayList.Items.Add(tmp);

                плейлистыToolStripMenuItem.DropDownItems.Add(tmp.Name);
                плейлистыToolStripMenuItem.DropDownItems[плейлистыToolStripMenuItem.DropDownItems.Count - 1].Click += Item_Click;


                toolStripComboBoxPlayList.SelectedIndex = toolStripComboBoxPlayList.Items.Count - 1;
            }
        }

        /// <summary>
        /// Переименовать плейлист
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButtonEditPlayList_Click(object sender, EventArgs e)
        {
            if (toolStripComboBoxPlayList.SelectedItem != null)
            {
                NewEditPlayListForm newEditPlayListForm = new NewEditPlayListForm(toolStripComboBoxPlayList.SelectedItem.ToString());
                if (newEditPlayListForm.ShowDialog() == DialogResult.OK)
                {
                    _parentForm.PlayListsController.RenamePlayList(_currentToolStripMenuItem.Text, newEditPlayListForm.PlayListName);

                    _currentToolStripMenuItem.Text = newEditPlayListForm.PlayListName;

                    PlayList current = (PlayList)toolStripComboBoxPlayList.SelectedItem;
                    toolStripComboBoxPlayList.Items.Remove(current);

                    current.Name = newEditPlayListForm.PlayListName;
                    toolStripComboBoxPlayList.Items.Add(current);
                    toolStripComboBoxPlayList.SelectedItem = current;
                }
            }
            else
            {
                MessageBox.Show("Выберите плейлист для редактирования.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Удалить плейлист
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButtonRemovePlayList_Click(object sender, EventArgs e)
        {
            if (_currentToolStripMenuItem == null)
            {
                MessageBox.Show("Выберите плейлист для удаления.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Вы действительно хотите удалить плейлист?", "Уведомление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                PlayList rem = (PlayList)toolStripComboBoxPlayList.SelectedItem;
                _parentForm.PlayListsController.RemovePlayList(rem.Name);
                плейлистыToolStripMenuItem.DropDownItems.Remove(_currentToolStripMenuItem);
                toolStripComboBoxPlayList.Items.Remove(rem);
                listBoxMediaRecords.Items.Clear();
                _currentToolStripMenuItem = null;
            }
        }

        /// <summary>
        /// Добавить медиафайл в текущий плейлист
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddMediaRecord_Click(object sender, EventArgs e)
        {
            if (toolStripComboBoxPlayList.SelectedItem != null)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = MediaFilter.GetOpenFileDialogFilter();
                //Директория которая откроется по умолчанию
                openFileDialog.InitialDirectory = @"C:\Users\Public\Music";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    PlayList tmp = ((PlayList)toolStripComboBoxPlayList.SelectedItem);
                    tmp.MediaRecords.Add(new MediaRecord(openFileDialog.FileName));
                    listBoxMediaRecords.Items.Add(tmp.MediaRecords.Last());
                    _parentForm.PlayListsController.AddNewMediaRecord(tmp.MediaRecords.Last(), tmp);
                }
            }
        }

        private void buttonEditMediaRecord_Click(object sender, EventArgs e)
        {

        }

        private void buttonRemoveMediaRecord_Click(object sender, EventArgs e)
        {
            if (toolStripComboBoxPlayList.SelectedItem != null)
            {
                if(listBoxMediaRecords.SelectedItem != null) 
                {
                    string question = "Вы действительно желеаете удалить из плейлиста \n" 
                                        + listBoxMediaRecords.SelectedItem.ToString();
                    string caption = "Удаление записи из плейлиста";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;

                    result = MessageBox.Show(question, caption, buttons);

                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {

                        _parentForm.PlayListsController.RemoveMediaRecord(
                                                            (MediaRecord)listBoxMediaRecords.SelectedItem,
                                                            (PlayList)toolStripComboBoxPlayList.SelectedItem);

                        listBoxMediaRecords.Items.Remove(listBoxMediaRecords.SelectedItem);
                    }
                }
            }
        }
    }
}