using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsMediaPlayer.PlayList;

namespace WindowsMediaPlayer
{
    public partial class MainForm : Form
    {
        private PlayListForm _playListForm;
        public PlayListController PlayListController;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //string pathFile = @"C:\Users\Admin\Desktop\Програмирование\source\repos\ItStep_HW_OOP\WindowsMedia Player\WindowsMediaPlayer\Media\Video1.mp4";
            //WindowsMediaPlayer.URL = pathFile;
            PlayListController = new PlayListController(PlayListXmlMap.Path);
        }

        private void playlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(_playListForm == null)
            {
                _playListForm = new PlayListForm(this);
            }
            
            //ТОДУ окно отображается сбоку 

            _playListForm.Show();
        }
    }
}
