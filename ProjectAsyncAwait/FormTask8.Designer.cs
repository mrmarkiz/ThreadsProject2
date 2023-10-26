namespace ProjectAsyncAwait
{
    partial class FormTask8
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
            button1 = new Button();
            labelSymbols = new Label();
            labelConsonants = new Label();
            labelVowels = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(218, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelSymbols
            // 
            labelSymbols.AutoSize = true;
            labelSymbols.Location = new Point(202, 418);
            labelSymbols.Name = "labelSymbols";
            labelSymbols.Size = new Size(49, 20);
            labelSymbols.TabIndex = 6;
            labelSymbols.Text = "Other:";
            // 
            // labelConsonants
            // 
            labelConsonants.AutoSize = true;
            labelConsonants.Location = new Point(202, 255);
            labelConsonants.Name = "labelConsonants";
            labelConsonants.Size = new Size(88, 20);
            labelConsonants.TabIndex = 7;
            labelConsonants.Text = "Consonants:";
            // 
            // labelVowels
            // 
            labelVowels.AutoSize = true;
            labelVowels.Location = new Point(202, 81);
            labelVowels.Name = "labelVowels";
            labelVowels.Size = new Size(58, 20);
            labelVowels.TabIndex = 8;
            labelVowels.Text = "Vowels:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 42);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 396);
            textBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(161, 20);
            label1.TabIndex = 4;
            label1.Text = "Enter text to work with:";
            // 
            // FormTask8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 450);
            Controls.Add(button1);
            Controls.Add(labelSymbols);
            Controls.Add(labelConsonants);
            Controls.Add(labelVowels);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "FormTask8";
            Text = "Task8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label labelSymbols;
        private Label labelConsonants;
        private Label labelVowels;
        private TextBox textBox1;
        private Label label1;
    }
}