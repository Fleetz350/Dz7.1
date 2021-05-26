
namespace SApp01
{
    partial class FormYgadai
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
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelMessage2 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.buttonInput = new System.Windows.Forms.Button();
            this.LabelReaction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMessage
            // 
            this.labelMessage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMessage.Location = new System.Drawing.Point(186, 119);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(261, 25);
            this.labelMessage.TabIndex = 2;
            this.labelMessage.Text = "Введите число от 1 до 100";
            // 
            // labelMessage2
            // 
            this.labelMessage2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMessage2.AutoSize = true;
            this.labelMessage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMessage2.Location = new System.Drawing.Point(186, 75);
            this.labelMessage2.Name = "labelMessage2";
            this.labelMessage2.Size = new System.Drawing.Size(251, 25);
            this.labelMessage2.TabIndex = 3;
            this.labelMessage2.Text = "Вам нужно угадать число";
            // 
            // Back
            // 
            this.Back.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(228, 262);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(150, 38);
            this.Back.TabIndex = 4;
            this.Back.Text = "Выход";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // tbInput
            // 
            this.tbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInput.Location = new System.Drawing.Point(215, 157);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(63, 30);
            this.tbInput.TabIndex = 5;
            // 
            // buttonInput
            // 
            this.buttonInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInput.Location = new System.Drawing.Point(306, 157);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(72, 30);
            this.buttonInput.TabIndex = 6;
            this.buttonInput.Text = "Ввод ";
            this.buttonInput.UseVisualStyleBackColor = true;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // LabelReaction
            // 
            this.LabelReaction.Location = new System.Drawing.Point(120, 190);
            this.LabelReaction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelReaction.Name = "LabelReaction";
            this.LabelReaction.Size = new System.Drawing.Size(376, 49);
            this.LabelReaction.TabIndex = 8;
            this.LabelReaction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormYgadai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 351);
            this.Controls.Add(this.LabelReaction);
            this.Controls.Add(this.buttonInput);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.labelMessage2);
            this.Controls.Add(this.labelMessage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(632, 398);
            this.MinimumSize = new System.Drawing.Size(632, 398);
            this.Name = "FormYgadai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра угадай число";
            this.Load += new System.EventHandler(this.FormYgadai_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelMessage2;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.Label LabelReaction;
    }
}