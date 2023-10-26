namespace ProjectAsyncAwait
{
    partial class FormTask2_3
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
            buttonFrom = new Button();
            buttonTo = new Button();
            labelFrom = new Label();
            labelTo = new Label();
            buttonCopy = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // buttonFrom
            // 
            buttonFrom.Location = new Point(12, 53);
            buttonFrom.Name = "buttonFrom";
            buttonFrom.Size = new Size(128, 45);
            buttonFrom.TabIndex = 0;
            buttonFrom.Text = "Source";
            buttonFrom.UseVisualStyleBackColor = true;
            buttonFrom.Click += buttonFrom_Click;
            // 
            // buttonTo
            // 
            buttonTo.Location = new Point(12, 143);
            buttonTo.Name = "buttonTo";
            buttonTo.Size = new Size(128, 45);
            buttonTo.TabIndex = 0;
            buttonTo.Text = "Destination";
            buttonTo.UseVisualStyleBackColor = true;
            buttonTo.Click += buttonTo_Click;
            // 
            // labelFrom
            // 
            labelFrom.AutoSize = true;
            labelFrom.Location = new Point(12, 30);
            labelFrom.Name = "labelFrom";
            labelFrom.Size = new Size(0, 20);
            labelFrom.TabIndex = 1;
            // 
            // labelTo
            // 
            labelTo.AutoSize = true;
            labelTo.Location = new Point(12, 120);
            labelTo.Name = "labelTo";
            labelTo.Size = new Size(0, 20);
            labelTo.TabIndex = 1;
            // 
            // buttonCopy
            // 
            buttonCopy.Location = new Point(12, 224);
            buttonCopy.Name = "buttonCopy";
            buttonCopy.Size = new Size(128, 48);
            buttonCopy.TabIndex = 2;
            buttonCopy.Text = "Copy";
            buttonCopy.UseVisualStyleBackColor = true;
            buttonCopy.Click += buttonCopy_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(255, 155);
            label1.Name = "label1";
            label1.Size = new Size(205, 120);
            label1.TabIndex = 3;
            label1.Text = "Я не знаю як копіювти один\r\n файл в кількох потоках\r\nі в інтернеті я не знайшов\r\n подібного тому завдання\r\nвиконане лише частково\r\n\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(315, 130);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 4;
            label2.Text = "Ремарка";
            // 
            // FormTask2_3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 282);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCopy);
            Controls.Add(labelTo);
            Controls.Add(labelFrom);
            Controls.Add(buttonTo);
            Controls.Add(buttonFrom);
            Name = "FormTask2_3";
            Text = "FormTask2_3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonFrom;
        private Button buttonTo;
        private Label labelFrom;
        private Label labelTo;
        private Button buttonCopy;
        private Label label1;
        private Label label2;
    }
}