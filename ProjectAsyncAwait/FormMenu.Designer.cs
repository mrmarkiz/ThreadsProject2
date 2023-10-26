namespace ProjectAsyncAwait
{
    partial class FormMenu
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(103, 51);
            button1.TabIndex = 0;
            button1.Tag = "1";
            button1.Text = "Task1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonTask_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(12, 69);
            button2.Name = "button2";
            button2.Size = new Size(103, 51);
            button2.TabIndex = 0;
            button2.Tag = "2";
            button2.Text = "Task2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonTask_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(12, 126);
            button3.Name = "button3";
            button3.Size = new Size(103, 51);
            button3.TabIndex = 0;
            button3.Tag = "3";
            button3.Text = "Task3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonTask_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(12, 183);
            button4.Name = "button4";
            button4.Size = new Size(103, 51);
            button4.TabIndex = 0;
            button4.Tag = "4";
            button4.Text = "Task4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += buttonTask_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(121, 12);
            button5.Name = "button5";
            button5.Size = new Size(103, 51);
            button5.TabIndex = 0;
            button5.Tag = "5";
            button5.Text = "Task5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += buttonTask_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(121, 69);
            button6.Name = "button6";
            button6.Size = new Size(103, 51);
            button6.TabIndex = 0;
            button6.Tag = "6";
            button6.Text = "Task6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += buttonTask_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(121, 126);
            button7.Name = "button7";
            button7.Size = new Size(103, 51);
            button7.TabIndex = 0;
            button7.Tag = "7";
            button7.Text = "Task7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += buttonTask_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(121, 183);
            button8.Name = "button8";
            button8.Size = new Size(103, 51);
            button8.TabIndex = 0;
            button8.Tag = "8";
            button8.Text = "Task8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += buttonTask_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(236, 246);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormMenu";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}