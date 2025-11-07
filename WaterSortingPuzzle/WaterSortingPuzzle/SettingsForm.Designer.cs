namespace PotionMaster
{
    partial class SettingsForm
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
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            darkRadioButton = new RadioButton();
            lightRadioButton = new RadioButton();
            okButton = new Button();
            cancelButton = new Button();
            difficultyLabel = new Label();
            segmentsCountLabel = new Label();
            vialsCountLabel = new Label();
            colorThemeLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Easy", "Medium", "Hard" });
            comboBox1.Location = new Point(211, 30);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(330, 33);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "Easy";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(211, 125);
            numericUpDown1.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(330, 31);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(211, 79);
            numericUpDown2.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(330, 31);
            numericUpDown2.TabIndex = 2;
            numericUpDown2.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // darkRadioButton
            // 
            darkRadioButton.AutoSize = true;
            darkRadioButton.Location = new Point(398, 177);
            darkRadioButton.Name = "darkRadioButton";
            darkRadioButton.Size = new Size(74, 29);
            darkRadioButton.TabIndex = 3;
            darkRadioButton.TabStop = true;
            darkRadioButton.Text = "Dark";
            darkRadioButton.UseVisualStyleBackColor = true;
            // 
            // lightRadioButton
            // 
            lightRadioButton.AutoSize = true;
            lightRadioButton.Location = new Point(301, 177);
            lightRadioButton.Name = "lightRadioButton";
            lightRadioButton.Size = new Size(76, 29);
            lightRadioButton.TabIndex = 4;
            lightRadioButton.TabStop = true;
            lightRadioButton.Text = "Light";
            lightRadioButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            okButton.Location = new Point(429, 234);
            okButton.Name = "okButton";
            okButton.Size = new Size(112, 34);
            okButton.TabIndex = 5;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(211, 234);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(112, 34);
            cancelButton.TabIndex = 6;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // difficultyLabel
            // 
            difficultyLabel.AutoSize = true;
            difficultyLabel.Location = new Point(93, 33);
            difficultyLabel.Name = "difficultyLabel";
            difficultyLabel.Size = new Size(82, 25);
            difficultyLabel.TabIndex = 7;
            difficultyLabel.Text = "Difficulty";
            // 
            // segmentsCountLabel
            // 
            segmentsCountLabel.AutoSize = true;
            segmentsCountLabel.Location = new Point(31, 85);
            segmentsCountLabel.Name = "segmentsCountLabel";
            segmentsCountLabel.Size = new Size(144, 25);
            segmentsCountLabel.TabIndex = 8;
            segmentsCountLabel.Text = "Segments Count";
            // 
            // vialsCountLabel
            // 
            vialsCountLabel.AutoSize = true;
            vialsCountLabel.Location = new Point(74, 131);
            vialsCountLabel.Name = "vialsCountLabel";
            vialsCountLabel.Size = new Size(101, 25);
            vialsCountLabel.TabIndex = 9;
            vialsCountLabel.Text = "Vials Count";
            // 
            // colorThemeLabel
            // 
            colorThemeLabel.AutoSize = true;
            colorThemeLabel.Location = new Point(62, 177);
            colorThemeLabel.Name = "colorThemeLabel";
            colorThemeLabel.Size = new Size(113, 25);
            colorThemeLabel.TabIndex = 10;
            colorThemeLabel.Text = "Color Theme";
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 294);
            Controls.Add(colorThemeLabel);
            Controls.Add(vialsCountLabel);
            Controls.Add(segmentsCountLabel);
            Controls.Add(difficultyLabel);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(lightRadioButton);
            Controls.Add(darkRadioButton);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(comboBox1);
            MaximumSize = new Size(600, 350);
            MinimumSize = new Size(600, 350);
            Name = "SettingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Potion Master - Settings";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private RadioButton darkRadioButton;
        private RadioButton lightRadioButton;
        private Button okButton;
        private Button cancelButton;
        private Label difficultyLabel;
        private Label segmentsCountLabel;
        private Label vialsCountLabel;
        private Label colorThemeLabel;
    }
}