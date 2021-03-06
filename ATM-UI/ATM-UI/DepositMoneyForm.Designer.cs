﻿namespace ATM_UI
{
    partial class DepositMoneyForm
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
            this.DepositSumLabel = new System.Windows.Forms.Label();
            this.SumTextBox = new System.Windows.Forms.TextBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.DepositMoneyGroupBox = new System.Windows.Forms.GroupBox();
            this.Amount5000Button = new System.Windows.Forms.Button();
            this.Amount2000Button = new System.Windows.Forms.Button();
            this.Amount1000Button = new System.Windows.Forms.Button();
            this.Amount500Button = new System.Windows.Forms.Button();
            this.Amount200Button = new System.Windows.Forms.Button();
            this.Amount100Button = new System.Windows.Forms.Button();
            this.Amount50Button = new System.Windows.Forms.Button();
            this.Amount10Button = new System.Windows.Forms.Button();
            this.DepositMoneyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DepositSumLabel
            // 
            this.DepositSumLabel.AutoSize = true;
            this.DepositSumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DepositSumLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.DepositSumLabel.Location = new System.Drawing.Point(5, 16);
            this.DepositSumLabel.Name = "DepositSumLabel";
            this.DepositSumLabel.Size = new System.Drawing.Size(360, 24);
            this.DepositSumLabel.TabIndex = 0;
            this.DepositSumLabel.Text = "Какую сумму вы бы хотели внести?";
            // 
            // SumTextBox
            // 
            this.SumTextBox.Enabled = false;
            this.SumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumTextBox.Location = new System.Drawing.Point(5, 50);
            this.SumTextBox.Name = "SumTextBox";
            this.SumTextBox.Size = new System.Drawing.Size(356, 22);
            this.SumTextBox.TabIndex = 1;
            this.SumTextBox.Text = "0";
            this.SumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SumTextBox.TextChanged += new System.EventHandler(this.SumTextBox_TextChanged);
            // 
            // InsertButton
            // 
            this.InsertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InsertButton.BackColor = System.Drawing.Color.Green;
            this.InsertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsertButton.ForeColor = System.Drawing.SystemColors.Window;
            this.InsertButton.Location = new System.Drawing.Point(9, 322);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(75, 37);
            this.InsertButton.TabIndex = 2;
            this.InsertButton.Text = "Внести";
            this.InsertButton.UseVisualStyleBackColor = false;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.ForeColor = System.Drawing.SystemColors.Window;
            this.CancelButton.Location = new System.Drawing.Point(284, 322);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 37);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // DepositMoneyGroupBox
            // 
            this.DepositMoneyGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DepositMoneyGroupBox.Controls.Add(this.Amount5000Button);
            this.DepositMoneyGroupBox.Controls.Add(this.Amount2000Button);
            this.DepositMoneyGroupBox.Controls.Add(this.Amount1000Button);
            this.DepositMoneyGroupBox.Controls.Add(this.Amount500Button);
            this.DepositMoneyGroupBox.Controls.Add(this.Amount200Button);
            this.DepositMoneyGroupBox.Controls.Add(this.Amount100Button);
            this.DepositMoneyGroupBox.Controls.Add(this.Amount50Button);
            this.DepositMoneyGroupBox.Controls.Add(this.Amount10Button);
            this.DepositMoneyGroupBox.Controls.Add(this.SumTextBox);
            this.DepositMoneyGroupBox.Controls.Add(this.CancelButton);
            this.DepositMoneyGroupBox.Controls.Add(this.DepositSumLabel);
            this.DepositMoneyGroupBox.Controls.Add(this.InsertButton);
            this.DepositMoneyGroupBox.Location = new System.Drawing.Point(12, 12);
            this.DepositMoneyGroupBox.Name = "DepositMoneyGroupBox";
            this.DepositMoneyGroupBox.Size = new System.Drawing.Size(366, 365);
            this.DepositMoneyGroupBox.TabIndex = 4;
            this.DepositMoneyGroupBox.TabStop = false;
            // 
            // Amount5000Button
            // 
            this.Amount5000Button.BackColor = System.Drawing.Color.Blue;
            this.Amount5000Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Amount5000Button.ForeColor = System.Drawing.SystemColors.Window;
            this.Amount5000Button.Location = new System.Drawing.Point(284, 178);
            this.Amount5000Button.Name = "Amount5000Button";
            this.Amount5000Button.Size = new System.Drawing.Size(75, 37);
            this.Amount5000Button.TabIndex = 11;
            this.Amount5000Button.Text = "5000";
            this.Amount5000Button.UseVisualStyleBackColor = false;
            this.Amount5000Button.Click += new System.EventHandler(this.Amount5000Button_Click);
            // 
            // Amount2000Button
            // 
            this.Amount2000Button.BackColor = System.Drawing.Color.Blue;
            this.Amount2000Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Amount2000Button.ForeColor = System.Drawing.SystemColors.Window;
            this.Amount2000Button.Location = new System.Drawing.Point(192, 178);
            this.Amount2000Button.Name = "Amount2000Button";
            this.Amount2000Button.Size = new System.Drawing.Size(75, 37);
            this.Amount2000Button.TabIndex = 10;
            this.Amount2000Button.Text = "2000";
            this.Amount2000Button.UseVisualStyleBackColor = false;
            this.Amount2000Button.Click += new System.EventHandler(this.Amount2000Button_Click);
            // 
            // Amount1000Button
            // 
            this.Amount1000Button.BackColor = System.Drawing.Color.Blue;
            this.Amount1000Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Amount1000Button.ForeColor = System.Drawing.SystemColors.Window;
            this.Amount1000Button.Location = new System.Drawing.Point(100, 178);
            this.Amount1000Button.Name = "Amount1000Button";
            this.Amount1000Button.Size = new System.Drawing.Size(75, 37);
            this.Amount1000Button.TabIndex = 9;
            this.Amount1000Button.Text = "1000";
            this.Amount1000Button.UseVisualStyleBackColor = false;
            this.Amount1000Button.Click += new System.EventHandler(this.Amount1000Button_Click);
            // 
            // Amount500Button
            // 
            this.Amount500Button.BackColor = System.Drawing.Color.Blue;
            this.Amount500Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Amount500Button.ForeColor = System.Drawing.SystemColors.Window;
            this.Amount500Button.Location = new System.Drawing.Point(9, 178);
            this.Amount500Button.Name = "Amount500Button";
            this.Amount500Button.Size = new System.Drawing.Size(75, 37);
            this.Amount500Button.TabIndex = 8;
            this.Amount500Button.Text = "500";
            this.Amount500Button.UseVisualStyleBackColor = false;
            this.Amount500Button.Click += new System.EventHandler(this.Amount500Button_Click);
            // 
            // Amount200Button
            // 
            this.Amount200Button.BackColor = System.Drawing.Color.Blue;
            this.Amount200Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Amount200Button.ForeColor = System.Drawing.SystemColors.Window;
            this.Amount200Button.Location = new System.Drawing.Point(284, 135);
            this.Amount200Button.Name = "Amount200Button";
            this.Amount200Button.Size = new System.Drawing.Size(75, 37);
            this.Amount200Button.TabIndex = 7;
            this.Amount200Button.Text = "200";
            this.Amount200Button.UseVisualStyleBackColor = false;
            this.Amount200Button.Click += new System.EventHandler(this.Amount200Button_Click);
            // 
            // Amount100Button
            // 
            this.Amount100Button.BackColor = System.Drawing.Color.Blue;
            this.Amount100Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Amount100Button.ForeColor = System.Drawing.SystemColors.Window;
            this.Amount100Button.Location = new System.Drawing.Point(192, 135);
            this.Amount100Button.Name = "Amount100Button";
            this.Amount100Button.Size = new System.Drawing.Size(75, 37);
            this.Amount100Button.TabIndex = 6;
            this.Amount100Button.Text = "100";
            this.Amount100Button.UseVisualStyleBackColor = false;
            this.Amount100Button.Click += new System.EventHandler(this.Amount100Button_Click);
            // 
            // Amount50Button
            // 
            this.Amount50Button.BackColor = System.Drawing.Color.Blue;
            this.Amount50Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Amount50Button.ForeColor = System.Drawing.SystemColors.Window;
            this.Amount50Button.Location = new System.Drawing.Point(100, 135);
            this.Amount50Button.Name = "Amount50Button";
            this.Amount50Button.Size = new System.Drawing.Size(75, 37);
            this.Amount50Button.TabIndex = 5;
            this.Amount50Button.Text = "50";
            this.Amount50Button.UseVisualStyleBackColor = false;
            this.Amount50Button.Click += new System.EventHandler(this.Amount50Button_Click);
            // 
            // Amount10Button
            // 
            this.Amount10Button.BackColor = System.Drawing.Color.Blue;
            this.Amount10Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Amount10Button.ForeColor = System.Drawing.SystemColors.Window;
            this.Amount10Button.Location = new System.Drawing.Point(9, 135);
            this.Amount10Button.Name = "Amount10Button";
            this.Amount10Button.Size = new System.Drawing.Size(75, 37);
            this.Amount10Button.TabIndex = 4;
            this.Amount10Button.Text = "10";
            this.Amount10Button.UseVisualStyleBackColor = false;
            this.Amount10Button.Click += new System.EventHandler(this.Amount10Button_Click);
            // 
            // DepositMoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(390, 393);
            this.Controls.Add(this.DepositMoneyGroupBox);
            this.Name = "DepositMoneyForm";
            this.Text = "DepositMoney";
            this.Load += new System.EventHandler(this.DepositMoneyForm_Load);
            this.DepositMoneyGroupBox.ResumeLayout(false);
            this.DepositMoneyGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DepositSumLabel;
        private System.Windows.Forms.TextBox SumTextBox;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.GroupBox DepositMoneyGroupBox;
        private System.Windows.Forms.Button Amount5000Button;
        private System.Windows.Forms.Button Amount2000Button;
        private System.Windows.Forms.Button Amount1000Button;
        private System.Windows.Forms.Button Amount500Button;
        private System.Windows.Forms.Button Amount200Button;
        private System.Windows.Forms.Button Amount100Button;
        private System.Windows.Forms.Button Amount50Button;
        private System.Windows.Forms.Button Amount10Button;
    }
}