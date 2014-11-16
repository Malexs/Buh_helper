namespace Buh_Helper
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.EnterTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PrevNumb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.LangGroupBox = new System.Windows.Forms.GroupBox();
            this.ENGradioButton = new System.Windows.Forms.RadioButton();
            this.RUradioButton = new System.Windows.Forms.RadioButton();
            this.CurrencyGroupBox = new System.Windows.Forms.GroupBox();
            this.EuroRadioButton = new System.Windows.Forms.RadioButton();
            this.DollarsRadioButton = new System.Windows.Forms.RadioButton();
            this.RUBradioButton = new System.Windows.Forms.RadioButton();
            this.StartButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.Copy_Button = new System.Windows.Forms.Button();
            this.Paste_Button = new System.Windows.Forms.Button();
            this.LangGroupBox.SuspendLayout();
            this.CurrencyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnterTextBox
            // 
            this.EnterTextBox.AllowDrop = true;
            this.EnterTextBox.Location = new System.Drawing.Point(109, 12);
            this.EnterTextBox.MaxLength = 100;
            this.EnterTextBox.Name = "EnterTextBox";
            this.EnterTextBox.Size = new System.Drawing.Size(93, 20);
            this.EnterTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ввод/Enter:";
            // 
            // PrevNumb
            // 
            this.PrevNumb.Location = new System.Drawing.Point(109, 60);
            this.PrevNumb.MaxLength = 12;
            this.PrevNumb.Name = "PrevNumb";
            this.PrevNumb.ReadOnly = true;
            this.PrevNumb.Size = new System.Drawing.Size(93, 20);
            this.PrevNumb.TabIndex = 2;
            this.PrevNumb.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Текущее/Current:";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(12, 107);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(97, 13);
            this.ResultLabel.TabIndex = 8;
            this.ResultLabel.Text = "Результат/Result:";
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(109, 104);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.ReadOnly = true;
            this.ResultBox.Size = new System.Drawing.Size(756, 20);
            this.ResultBox.TabIndex = 9;
            this.ResultBox.TabStop = false;
            // 
            // LangGroupBox
            // 
            this.LangGroupBox.Controls.Add(this.ENGradioButton);
            this.LangGroupBox.Controls.Add(this.RUradioButton);
            this.LangGroupBox.Location = new System.Drawing.Point(724, 16);
            this.LangGroupBox.Name = "LangGroupBox";
            this.LangGroupBox.Size = new System.Drawing.Size(120, 64);
            this.LangGroupBox.TabIndex = 10;
            this.LangGroupBox.TabStop = false;
            this.LangGroupBox.Text = "Язык/Language";
            // 
            // ENGradioButton
            // 
            this.ENGradioButton.AutoSize = true;
            this.ENGradioButton.Location = new System.Drawing.Point(6, 43);
            this.ENGradioButton.Name = "ENGradioButton";
            this.ENGradioButton.Size = new System.Drawing.Size(59, 17);
            this.ENGradioButton.TabIndex = 1;
            this.ENGradioButton.Text = "English";
            this.ENGradioButton.UseVisualStyleBackColor = true;
            this.ENGradioButton.CheckedChanged += new System.EventHandler(this.ENGradioButton_CheckedChanged);
            // 
            // RUradioButton
            // 
            this.RUradioButton.AutoSize = true;
            this.RUradioButton.Checked = true;
            this.RUradioButton.Location = new System.Drawing.Point(6, 19);
            this.RUradioButton.Name = "RUradioButton";
            this.RUradioButton.Size = new System.Drawing.Size(67, 17);
            this.RUradioButton.TabIndex = 0;
            this.RUradioButton.TabStop = true;
            this.RUradioButton.Text = "Русский";
            this.RUradioButton.UseVisualStyleBackColor = true;
            this.RUradioButton.CheckedChanged += new System.EventHandler(this.RUradioButton_CheckedChanged);
            // 
            // CurrencyGroupBox
            // 
            this.CurrencyGroupBox.Controls.Add(this.EuroRadioButton);
            this.CurrencyGroupBox.Controls.Add(this.DollarsRadioButton);
            this.CurrencyGroupBox.Controls.Add(this.RUBradioButton);
            this.CurrencyGroupBox.Location = new System.Drawing.Point(523, 6);
            this.CurrencyGroupBox.Name = "CurrencyGroupBox";
            this.CurrencyGroupBox.Size = new System.Drawing.Size(125, 86);
            this.CurrencyGroupBox.TabIndex = 11;
            this.CurrencyGroupBox.TabStop = false;
            this.CurrencyGroupBox.Text = "Валюта/Currency";
            // 
            // EuroRadioButton
            // 
            this.EuroRadioButton.AutoSize = true;
            this.EuroRadioButton.Location = new System.Drawing.Point(6, 63);
            this.EuroRadioButton.Name = "EuroRadioButton";
            this.EuroRadioButton.Size = new System.Drawing.Size(77, 17);
            this.EuroRadioButton.TabIndex = 2;
            this.EuroRadioButton.Text = "Евро/Euro";
            this.EuroRadioButton.UseVisualStyleBackColor = true;
            this.EuroRadioButton.CheckedChanged += new System.EventHandler(this.EuroRadioButton_CheckedChanged);
            // 
            // DollarsRadioButton
            // 
            this.DollarsRadioButton.AutoSize = true;
            this.DollarsRadioButton.Location = new System.Drawing.Point(6, 40);
            this.DollarsRadioButton.Name = "DollarsRadioButton";
            this.DollarsRadioButton.Size = new System.Drawing.Size(109, 17);
            this.DollarsRadioButton.TabIndex = 1;
            this.DollarsRadioButton.Text = "Доллары/Dollars";
            this.DollarsRadioButton.UseVisualStyleBackColor = true;
            this.DollarsRadioButton.CheckedChanged += new System.EventHandler(this.DollarsRadioButton_CheckedChanged);
            // 
            // RUBradioButton
            // 
            this.RUBradioButton.AutoSize = true;
            this.RUBradioButton.Checked = true;
            this.RUBradioButton.Location = new System.Drawing.Point(6, 17);
            this.RUBradioButton.Name = "RUBradioButton";
            this.RUBradioButton.Size = new System.Drawing.Size(93, 17);
            this.RUBradioButton.TabIndex = 0;
            this.RUBradioButton.TabStop = true;
            this.RUBradioButton.Text = "Рубли/Rubles";
            this.RUBradioButton.UseVisualStyleBackColor = true;
            this.RUBradioButton.CheckedChanged += new System.EventHandler(this.RUBradioButton_CheckedChanged);
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.Location = new System.Drawing.Point(222, 11);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(132, 40);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Перевести / Transfer";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReturnButton.Location = new System.Drawing.Point(360, 57);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(132, 40);
            this.ReturnButton.TabIndex = 12;
            this.ReturnButton.Text = "Вернуть значение / Return value";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // Copy_Button
            // 
            this.Copy_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Copy_Button.Location = new System.Drawing.Point(222, 57);
            this.Copy_Button.Name = "Copy_Button";
            this.Copy_Button.Size = new System.Drawing.Size(132, 40);
            this.Copy_Button.TabIndex = 13;
            this.Copy_Button.Text = "Копировать  / Copy";
            this.Copy_Button.UseVisualStyleBackColor = true;
            this.Copy_Button.Click += new System.EventHandler(this.Copy_Button_Click);
            // 
            // Paste_Button
            // 
            this.Paste_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Paste_Button.Location = new System.Drawing.Point(361, 12);
            this.Paste_Button.Name = "Paste_Button";
            this.Paste_Button.Size = new System.Drawing.Size(130, 38);
            this.Paste_Button.TabIndex = 14;
            this.Paste_Button.Text = "Вставить / Paste";
            this.Paste_Button.UseVisualStyleBackColor = true;
            this.Paste_Button.Click += new System.EventHandler(this.Paste_Button_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.StartButton;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 145);
            this.Controls.Add(this.Paste_Button);
            this.Controls.Add(this.Copy_Button);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.CurrencyGroupBox);
            this.Controls.Add(this.LangGroupBox);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PrevNumb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnterTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Buh. Helper";
            this.LangGroupBox.ResumeLayout(false);
            this.LangGroupBox.PerformLayout();
            this.CurrencyGroupBox.ResumeLayout(false);
            this.CurrencyGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EnterTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PrevNumb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.GroupBox LangGroupBox;
        private System.Windows.Forms.RadioButton ENGradioButton;
        private System.Windows.Forms.RadioButton RUradioButton;
        private System.Windows.Forms.GroupBox CurrencyGroupBox;
        private System.Windows.Forms.RadioButton EuroRadioButton;
        private System.Windows.Forms.RadioButton DollarsRadioButton;
        private System.Windows.Forms.RadioButton RUBradioButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button Copy_Button;
        private System.Windows.Forms.Button Paste_Button;
    }
}

