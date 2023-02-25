using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsMediaPlayer
{
    public partial class PlayListForm : Form
    {
        private MainForm _parentForm;

        //public PlayListForm()
        //{

        //}

        public PlayListForm(MainForm mainForm)
        {
            this._parentForm = mainForm;
            InitializeComponent();

        }

        private void PlayListForm_Load(object sender, EventArgs e)
        {
            foreach(var item in _parentForm.PlayListController.PlayLists)
            {
                плейлистыToolStripMenuItem.DropDownItems.Add(item.Name);
                ////ШО ЄТО???
                //ToolStripComboBoxPlayList.Items.Add(item);
            }
            foreach(ToolStripDropDownItem item in плейлистыToolStripMenuItem.DropDownItems)
            {
                ///SHO ETO???
                item.Click += Item_Click;
            }

        }

        private void Item_Click(object sender, EventArgs e)
        {
            ////3^19 смотреть и делать паралельно
            ToolStripMenuItem tmp = (ToolStripMenuItem)sender;

            
        }


        private void PlayListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel= true;
        }
    }
}
