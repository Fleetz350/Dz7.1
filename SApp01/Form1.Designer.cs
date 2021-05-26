
namespace SApp01
{
    partial class Yvelichitel
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Raise1 = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Raise2 = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.labelcounter = new System.Windows.Forms.Label();
            this.counterCommand = new System.Windows.Forms.Label();
            this.labelCounterCommand = new System.Windows.Forms.Label();
            this.labelmessage = new System.Windows.Forms.Label();
            this.labelRandom = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.undo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Raise1
            // 
            this.Raise1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Raise1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Raise1.Location = new System.Drawing.Point(567, 31);
            this.Raise1.Name = "Raise1";
            this.Raise1.Size = new System.Drawing.Size(149, 57);
            this.Raise1.TabIndex = 0;
            this.Raise1.Text = "Увеличить на 1";
            this.Raise1.UseVisualStyleBackColor = true;
            this.Raise1.Click += new System.EventHandler(this.Raise1_Click);
            // 
            // Reset
            // 
            this.Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reset.Location = new System.Drawing.Point(567, 112);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(149, 60);
            this.Reset.TabIndex = 1;
            this.Reset.Text = "Сбросить значение";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Raise2
            // 
            this.Raise2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Raise2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Raise2.Location = new System.Drawing.Point(567, 198);
            this.Raise2.Name = "Raise2";
            this.Raise2.Size = new System.Drawing.Size(149, 58);
            this.Raise2.TabIndex = 2;
            this.Raise2.Text = "Умножить на 2";
            this.Raise2.UseVisualStyleBackColor = true;
            this.Raise2.Click += new System.EventHandler(this.Raise2_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label.Location = new System.Drawing.Point(112, 124);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(123, 29);
            this.Label.TabIndex = 3;
            this.Label.Text = "Счетчик: ";
            // 
            // labelcounter
            // 
            this.labelcounter.AutoSize = true;
            this.labelcounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelcounter.Location = new System.Drawing.Point(224, 124);
            this.labelcounter.Name = "labelcounter";
            this.labelcounter.Size = new System.Drawing.Size(55, 29);
            this.labelcounter.TabIndex = 5;
            this.labelcounter.Text = "123";
            // 
            // counterCommand
            // 
            this.counterCommand.AutoSize = true;
            this.counterCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.counterCommand.Location = new System.Drawing.Point(20, 171);
            this.counterCommand.Name = "counterCommand";
            this.counterCommand.Size = new System.Drawing.Size(259, 29);
            this.counterCommand.TabIndex = 6;
            this.counterCommand.Text = "Количество команд: ";
            // 
            // labelCounterCommand
            // 
            this.labelCounterCommand.AutoSize = true;
            this.labelCounterCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCounterCommand.Location = new System.Drawing.Point(285, 171);
            this.labelCounterCommand.Name = "labelCounterCommand";
            this.labelCounterCommand.Size = new System.Drawing.Size(55, 29);
            this.labelCounterCommand.TabIndex = 7;
            this.labelCounterCommand.Text = "123";
            // 
            // labelmessage
            // 
            this.labelmessage.AutoSize = true;
            this.labelmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelmessage.Location = new System.Drawing.Point(53, 31);
            this.labelmessage.Name = "labelmessage";
            this.labelmessage.Size = new System.Drawing.Size(284, 26);
            this.labelmessage.TabIndex = 8;
            this.labelmessage.Text = "Вам надо дойти до числа: ";
            // 
            // labelRandom
            // 
            this.labelRandom.AutoSize = true;
            this.labelRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRandom.Location = new System.Drawing.Point(346, 31);
            this.labelRandom.Name = "labelRandom";
            this.labelRandom.Size = new System.Drawing.Size(48, 26);
            this.labelRandom.TabIndex = 9;
            this.labelRandom.Text = "124";
            // 
            // Back
            // 
            this.Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(567, 310);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(149, 54);
            this.Back.TabIndex = 10;
            this.Back.Text = "Вернуться назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // undo
            // 
            this.undo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.undo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.undo.Location = new System.Drawing.Point(567, 262);
            this.undo.Name = "undo";
            this.undo.Size = new System.Drawing.Size(149, 42);
            this.undo.TabIndex = 11;
            this.undo.Text = "1 ход назад";
            this.undo.UseVisualStyleBackColor = true;
            this.undo.Click += new System.EventHandler(this.undo_Click);
            // 
            // Yvelichitel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 388);
            this.Controls.Add(this.undo);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.labelRandom);
            this.Controls.Add(this.labelmessage);
            this.Controls.Add(this.labelCounterCommand);
            this.Controls.Add(this.counterCommand);
            this.Controls.Add(this.labelcounter);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.Raise2);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Raise1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(810, 435);
            this.MinimumSize = new System.Drawing.Size(810, 435);
            this.Name = "Yvelichitel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Увеличитель";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Raise1;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Raise2;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label labelcounter;
        private System.Windows.Forms.Label counterCommand;
        private System.Windows.Forms.Label labelCounterCommand;
        private System.Windows.Forms.Label labelmessage;
        private System.Windows.Forms.Label labelRandom;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button undo;
    }
}

