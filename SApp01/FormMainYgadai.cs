using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SApp01
{
    public partial class FormMainYgadai : Form
    {
        public FormMainYgadai()
        {
            InitializeComponent();
        }

        private void Ydvoitel_Enter(object sender, EventArgs e)
        {

        }

        private void Game_Click(object sender, EventArgs e)
        {
            var FormYgadai = new FormYgadai();
            FormYgadai.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
