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
    public partial class GMydvoitel : Form
    {
        
        public GMydvoitel()
        {
            InitializeComponent();
        }

        private void Game_Click(object sender, EventArgs e)
        {
            var Yvelichitel = new Yvelichitel();
            Yvelichitel.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
