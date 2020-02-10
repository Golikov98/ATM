namespace ATM_UI
{
    partial class MainForm
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
            this.MainListBox = new System.Windows.Forms.ListBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ConditionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainListBox
            // 
            this.MainListBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.MainListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainListBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainListBox.ForeColor = System.Drawing.SystemColors.Window;
            this.MainListBox.FormattingEnabled = true;
            this.MainListBox.ItemHeight = 24;
            this.MainListBox.Items.AddRange(new object[] {
            "-Внести деньги",
            "-Снять деньги"});
            this.MainListBox.Location = new System.Drawing.Point(12, 132);
            this.MainListBox.Name = "MainListBox";
            this.MainListBox.Size = new System.Drawing.Size(776, 48);
            this.MainListBox.TabIndex = 0;
            this.MainListBox.SelectedIndexChanged += new System.EventHandler(this.MainListBox_SelectedIndexChanged);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Green;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.Window;
            this.ExitButton.Location = new System.Drawing.Point(713, 401);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 37);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ConditionButton
            // 
            this.ConditionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ConditionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConditionButton.ForeColor = System.Drawing.SystemColors.Window;
            this.ConditionButton.Location = new System.Drawing.Point(12, 401);
            this.ConditionButton.Name = "ConditionButton";
            this.ConditionButton.Size = new System.Drawing.Size(217, 37);
            this.ConditionButton.TabIndex = 2;
            this.ConditionButton.Text = "Состояние банкомата";
            this.ConditionButton.UseVisualStyleBackColor = false;
            this.ConditionButton.Click += new System.EventHandler(this.ConditionButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConditionButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.MainListBox);
            this.Name = "MainForm";
            this.Text = "ATM";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox MainListBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ConditionButton;
    }
}

