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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void удвоительToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Ydvoitel = new GMydvoitel();
            Ydvoitel.Show();
        }

        private void угадайЧислоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormMainYgadai = new FormMainYgadai();
            FormMainYgadai.Show();
        }
    }
}
