namespace ProjectAsyncAwait
{
    partial class FormTask1
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
            numericUpDown1 = new NumericUpDown();
            listBoxNums = new ListBox();
            listBoxLett = new ListBox();
            listBoxSymb = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonNums = new Button();
            buttonLett = new Button();
            buttonSymbols = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(312, 28);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 0;
            // 
            // listBoxNums
            // 
            listBoxNums.FormattingEnabled = true;
            listBoxNums.ItemHeight = 20;
            listBoxNums.Location = new Point(12, 28);
            listBoxNums.Name = "listBoxNums";
            listBoxNums.Size = new Size(90, 304);
            listBoxNums.TabIndex = 1;
            // 
            // listBoxLett
            // 
            listBoxLett.FormattingEnabled = true;
            listBoxLett.ItemHeight = 20;
            listBoxLett.Location = new Point(108, 28);
            listBoxLett.Name = "listBoxLett";
            listBoxLett.Size = new Size(90, 304);
            listBoxLett.TabIndex = 1;
            // 
            // listBoxSymb
            // 
            listBoxSymb.FormattingEnabled = true;
            listBoxSymb.ItemHeight = 20;
            listBoxSymb.Location = new Point(204, 28);
            listBoxSymb.Name = "listBoxSymb";
            listBoxSymb.Size = new Size(90, 304);
            listBoxSymb.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 5);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 2;
            label1.Text = "Numbers";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 5);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 2;
            label2.Text = "Letters";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(217, 5);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 2;
            label3.Text = "Symbols";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(360, 5);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 3;
            label4.Text = "Count";
            // 
            // buttonNums
            // 
            buttonNums.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNums.Location = new Point(312, 72);
            buttonNums.Name = "buttonNums";
            buttonNums.Size = new Size(148, 73);
            buttonNums.TabIndex = 4;
            buttonNums.Tag = "n";
            buttonNums.Text = "Generate numbers";
            buttonNums.UseVisualStyleBackColor = true;
            buttonNums.Click += buttonGenerate_Click;
            // 
            // buttonLett
            // 
            buttonLett.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLett.Location = new Point(312, 165);
            buttonLett.Name = "buttonLett";
            buttonLett.Size = new Size(148, 73);
            buttonLett.TabIndex = 4;
            buttonLett.Tag = "l";
            buttonLett.Text = "Generate letters";
            buttonLett.UseVisualStyleBackColor = true;
            buttonLett.Click += buttonGenerate_Click;
            // 
            // buttonSymbols
            // 
            buttonSymbols.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSymbols.Location = new Point(314, 259);
            buttonSymbols.Name = "buttonSymbols";
            buttonSymbols.Size = new Size(148, 73);
            buttonSymbols.TabIndex = 4;
            buttonSymbols.Tag = "s";
            buttonSymbols.Text = "Generate symbols";
            buttonSymbols.UseVisualStyleBackColor = true;
            buttonSymbols.Click += buttonGenerate_Click;
            // 
            // FormTask1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 341);
            Controls.Add(buttonSymbols);
            Controls.Add(buttonLett);
            Controls.Add(buttonNums);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxSymb);
            Controls.Add(listBoxLett);
            Controls.Add(listBoxNums);
            Controls.Add(numericUpDown1);
            Name = "FormTask1";
            Text = "FormTask1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private ListBox listBoxNums;
        private ListBox listBoxLett;
        private ListBox listBoxSymb;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonNums;
        private Button buttonLett;
        private Button buttonSymbols;
    }
}