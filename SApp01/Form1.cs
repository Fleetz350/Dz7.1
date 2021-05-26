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
    public partial class Yvelichitel : Form
    {
        private int countercommand = 0;
        private int counter = 0;
        private int target = 0;
        bool CheckEnd = false;
        Stack<int> StackCounter;      
        public Yvelichitel()
        {
            Random rnd = new Random();
            target = rnd.Next(6, 150);
            StackCounter = new Stack<int>();
            InitializeComponent();
            UpdateUI();

        }
        public void Check()
        {
            string Text = "";            
            undo.Enabled = (counter > 0 );
            CheckEnd = (counter >= target);
            if (counter == target)
                Text = "Вы достигли заданного значения";
            else if (counter > target)
                Text = "Вы превысили значение";
            
            if(CheckEnd)  MessageBox.Show(Text);
        }
       
        private void UpdateUI()
        {
            labelcounter.Text = counter.ToString();
            labelCounterCommand.Text = countercommand.ToString();
            labelRandom.Text = target.ToString();
            Check(); 
        }
        private void Raise1_Click(object sender, EventArgs e)
        {

            if (!CheckEnd)
            {
                StackCounter.Push(counter);
                counter++;
                countercommand++;               
            }
            UpdateUI();
        }

        private void Raise2_Click(object sender, EventArgs e)
        {
            if (!CheckEnd)
            {
                StackCounter.Push(counter);
                counter = counter * 2;
                countercommand++;               
            }
            UpdateUI();

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            counter = 0;
            countercommand = 0;
            StackCounter.Clear();
            UpdateUI();
        }
        private void undo_Click(object sender, EventArgs e)
        {
            
            counter = StackCounter.Pop();
            countercommand--;
            UpdateUI();

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
    
}
