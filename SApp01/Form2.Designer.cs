
namespace SApp01
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удвоительToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.угадайЧислоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(302, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удвоительToolStripMenuItem,
            this.угадайЧислоToolStripMenuItem});
            this.менюToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(87, 36);
            this.менюToolStripMenuItem.Text = "Игры";
            // 
            // удвоительToolStripMenuItem
            // 
            this.удвоительToolStripMenuItem.Name = "удвоительToolStripMenuItem";
            this.удвоительToolStripMenuItem.Size = new System.Drawing.Size(251, 36);
            this.удвоительToolStripMenuItem.Text = "Удвоитель";
            this.удвоительToolStripMenuItem.Click += new System.EventHandler(this.удвоительToolStripMenuItem_Click);
            // 
            // угадайЧислоToolStripMenuItem
            // 
            this.угадайЧислоToolStripMenuItem.Name = "угадайЧислоToolStripMenuItem";
            this.угадайЧислоToolStripMenuItem.Size = new System.Drawing.Size(251, 36);
            this.угадайЧислоToolStripMenuItem.Text = "Угадай число";
            this.угадайЧислоToolStripMenuItem.Click += new System.EventHandler(this.угадайЧислоToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 213);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(320, 260);
            this.MinimumSize = new System.Drawing.Size(320, 260);
            this.Name = "Menu";
            this.Text = "ДЗ7";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удвоительToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem угадайЧислоToolStripMenuItem;
    }
}