namespace Task7Form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            labelVowels = new Label();
            labelConsonants = new Label();
            labelSymbols = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(161, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter text to work with:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 42);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 396);
            textBox1.TabIndex = 1;
            // 
            // labelVowels
            // 
            labelVowels.AutoSize = true;
            labelVowels.Location = new Point(202, 81);
            labelVowels.Name = "labelVowels";
            labelVowels.Size = new Size(58, 20);
            labelVowels.TabIndex = 2;
            labelVowels.Text = "Vowels:";
            // 
            // labelConsonants
            // 
            labelConsonants.AutoSize = true;
            labelConsonants.Location = new Point(202, 255);
            labelConsonants.Name = "labelConsonants";
            labelConsonants.Size = new Size(88, 20);
            labelConsonants.TabIndex = 2;
            labelConsonants.Text = "Consonants:";
            // 
            // labelSymbols
            // 
            labelSymbols.AutoSize = true;
            labelSymbols.Location = new Point(202, 418);
            labelSymbols.Name = "labelSymbols";
            labelSymbols.Size = new Size(49, 20);
            labelSymbols.TabIndex = 2;
            labelSymbols.Text = "Other:";
            // 
            // button1
            // 
            button1.Location = new Point(218, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
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
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label labelVowels;
        private Label labelConsonants;
        private Label labelSymbols;
        private Button button1;
    }
}