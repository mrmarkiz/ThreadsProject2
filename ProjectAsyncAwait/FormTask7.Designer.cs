namespace ProjectAsyncAwait
{
    partial class FormTask7
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
            numericUpDownNumber = new NumericUpDown();
            numericUpDownStart = new NumericUpDown();
            listBox1 = new ListBox();
            button1 = new Button();
            numericUpDownEnd = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEnd).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownNumber
            // 
            numericUpDownNumber.Location = new Point(204, 52);
            numericUpDownNumber.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numericUpDownNumber.Minimum = new decimal(new int[] { 1000000000, 0, 0, int.MinValue });
            numericUpDownNumber.Name = "numericUpDownNumber";
            numericUpDownNumber.Size = new Size(150, 27);
            numericUpDownNumber.TabIndex = 0;
            // 
            // numericUpDownStart
            // 
            numericUpDownStart.Location = new Point(204, 126);
            numericUpDownStart.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numericUpDownStart.Minimum = new decimal(new int[] { 1000000000, 0, 0, int.MinValue });
            numericUpDownStart.Name = "numericUpDownStart";
            numericUpDownStart.Size = new Size(150, 27);
            numericUpDownStart.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(12, 32);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(175, 264);
            listBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(204, 237);
            button1.Name = "button1";
            button1.Size = new Size(150, 58);
            button1.TabIndex = 2;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numericUpDownEnd
            // 
            numericUpDownEnd.Location = new Point(204, 191);
            numericUpDownEnd.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numericUpDownEnd.Minimum = new decimal(new int[] { 1000000000, 0, 0, int.MinValue });
            numericUpDownEnd.Name = "numericUpDownEnd";
            numericUpDownEnd.Size = new Size(150, 27);
            numericUpDownEnd.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 9);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 3;
            label1.Text = "Result";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(246, 29);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 3;
            label2.Text = "Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(233, 103);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 3;
            label3.Text = "Start Degree";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(233, 168);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 3;
            label4.Text = "End Degree";
            // 
            // FormTask7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 307);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(numericUpDownEnd);
            Controls.Add(numericUpDownStart);
            Controls.Add(numericUpDownNumber);
            Name = "FormTask7";
            Text = "Task7";
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStart).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEnd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDownNumber;
        private NumericUpDown numericUpDownStart;
        private ListBox listBox1;
        private Button button1;
        private NumericUpDown numericUpDownEnd;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}