using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPlayer
{
    public partial class NewEditPlayListForm : Form
    {
        public string PlayListName { get; private set; }
        public NewEditPlayListForm()                    //добавление нового плейлиста
        {
            InitializeComponent();
        }
        public NewEditPlayListForm(string oldPlayListName)                    //редактируем нового плейлиста
        {
            InitializeComponent();
            textBox_PlayListName.Text = oldPlayListName;
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if(textBox_PlayListName.Text.Length >= 3)
            {
                PlayListName = textBox_PlayListName.Text;
                DialogResult = DialogResult.OK;
            } else
            {
                MessageBox.Show("Заполните поле для ввода", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
