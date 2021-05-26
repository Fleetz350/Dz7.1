
namespace SApp01
{
    partial class GMydvoitel
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
            this.Ydvoitel = new System.Windows.Forms.GroupBox();
            this.Exit = new System.Windows.Forms.Button();
            this.Game = new System.Windows.Forms.Button();
            this.Ydvoitel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ydvoitel
            // 
            this.Ydvoitel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Ydvoitel.Controls.Add(this.Exit);
            this.Ydvoitel.Controls.Add(this.Game);
            this.Ydvoitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ydvoitel.Location = new System.Drawing.Point(12, 12);
            this.Ydvoitel.Name = "Ydvoitel";
            this.Ydvoitel.Size = new System.Drawing.Size(308, 279);
            this.Ydvoitel.TabIndex = 0;
            this.Ydvoitel.TabStop = false;
            this.Ydvoitel.Text = "Удвоитель";
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(70, 127);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(150, 30);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Game
            // 
            this.Game.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Game.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Game.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Game.Location = new System.Drawing.Point(70, 100);
            this.Game.Name = "Game";
            this.Game.Size = new System.Drawing.Size(150, 30);
            this.Game.TabIndex = 0;
            this.Game.Text = "Начать игру";
            this.Game.UseVisualStyleBackColor = false;
            this.Game.Click += new System.EventHandler(this.Game_Click);
            // 
            // GMydvoitel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 298);
            this.Controls.Add(this.Ydvoitel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(345, 345);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(345, 345);
            this.Name = "GMydvoitel";
            this.Text = "Главное меню";
            this.Ydvoitel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Ydvoitel;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Game;
    }
}