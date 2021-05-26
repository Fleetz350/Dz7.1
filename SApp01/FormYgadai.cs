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
    public partial class FormYgadai : Form
    {
        private int target;
        private int input;

        public FormYgadai()
        {
            Random rnd = new Random();
            target = rnd.Next(1, 100);
            InitializeComponent();
        }
       public void Check()
        {
            if (int.TryParse(tbInput.Text, out int number))
            {
                input = number;
                if (input == target)
                    LabelReaction.Text = "Вы достигли заданного числа, УРА!!!!!!!";
                else if (input > target)
                    LabelReaction.Text = "Ваше число больше";
                else
                    LabelReaction.Text = "Ваше число меньше";

                //  if (CheckEnd);
                //MessageBox.Show(Text);
            }
            else input = 0;
            tbInput.Text = "";
            //LabelReaction.Text = "";
        }
        private void Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        private void buttonInput_Click(object sender, EventArgs e)
        {
            Check();
        }
        private void tbInput_KeyDown(object sender, KeyEventArgs e)
        {
            Check();
        }

       

        private void FormYgadai_Load(object sender, EventArgs e)
        {

        }

       

    }
}
