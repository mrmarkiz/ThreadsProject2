namespace ProjectAsyncAwait
{
    partial class FormTask4_5
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
            label1 = new Label();
            label2 = new Label();
            labelTotal = new Label();
            labelCopied = new Label();
            labelSource = new Label();
            buttonSource = new Button();
            labelDest = new Label();
            buttonDest = new Button();
            buttonCopy = new Button();
            buttonStop = new Button();
            buttonPause = new Button();
            buttonContinue = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Total: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 68);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 0;
            label2.Text = "Copied: ";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(68, 33);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(21, 20);
            labelTotal.TabIndex = 0;
            labelTotal.Text = " 0";
            // 
            // labelCopied
            // 
            labelCopied.AutoSize = true;
            labelCopied.Location = new Point(82, 68);
            labelCopied.Name = "labelCopied";
            labelCopied.Size = new Size(17, 20);
            labelCopied.TabIndex = 0;
            labelCopied.Text = "0";
            // 
            // labelSource
            // 
            labelSource.AutoSize = true;
            labelSource.Location = new Point(12, 91);
            labelSource.Name = "labelSource";
            labelSource.Size = new Size(0, 20);
            labelSource.TabIndex = 1;
            // 
            // buttonSource
            // 
            buttonSource.Location = new Point(12, 114);
            buttonSource.Name = "buttonSource";
            buttonSource.Size = new Size(94, 29);
            buttonSource.TabIndex = 2;
            buttonSource.Text = "Source dir";
            buttonSource.UseVisualStyleBackColor = true;
            buttonSource.Click += buttonSource_Click;
            // 
            // labelDest
            // 
            labelDest.AutoSize = true;
            labelDest.Location = new Point(12, 152);
            labelDest.Name = "labelDest";
            labelDest.Size = new Size(0, 20);
            labelDest.TabIndex = 1;
            // 
            // buttonDest
            // 
            buttonDest.Location = new Point(12, 175);
            buttonDest.Name = "buttonDest";
            buttonDest.Size = new Size(94, 29);
            buttonDest.TabIndex = 2;
            buttonDest.Text = "Dest dir";
            buttonDest.UseVisualStyleBackColor = true;
            buttonDest.Click += buttonDest_Click;
            // 
            // buttonCopy
            // 
            buttonCopy.Location = new Point(12, 236);
            buttonCopy.Name = "buttonCopy";
            buttonCopy.Size = new Size(94, 54);
            buttonCopy.TabIndex = 3;
            buttonCopy.Text = "Copy";
            buttonCopy.UseVisualStyleBackColor = true;
            buttonCopy.Click += buttonCopy_Click;
            // 
            // buttonStop
            // 
            buttonStop.Location = new Point(123, 236);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(94, 54);
            buttonStop.TabIndex = 3;
            buttonStop.Text = "Stop";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // buttonPause
            // 
            buttonPause.Location = new Point(241, 236);
            buttonPause.Name = "buttonPause";
            buttonPause.Size = new Size(94, 54);
            buttonPause.TabIndex = 3;
            buttonPause.Text = "Pause";
            buttonPause.UseVisualStyleBackColor = true;
            buttonPause.Click += buttonPause_Click;
            // 
            // buttonContinue
            // 
            buttonContinue.Location = new Point(356, 236);
            buttonContinue.Name = "buttonContinue";
            buttonContinue.Size = new Size(94, 54);
            buttonContinue.TabIndex = 3;
            buttonContinue.Text = "Continue";
            buttonContinue.UseVisualStyleBackColor = true;
            buttonContinue.Click += buttonContinue_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(31, 9);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 4;
            label4.Text = "Files";
            // 
            // FormTask4_5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 302);
            Controls.Add(label4);
            Controls.Add(buttonContinue);
            Controls.Add(buttonPause);
            Controls.Add(buttonStop);
            Controls.Add(buttonCopy);
            Controls.Add(buttonDest);
            Controls.Add(labelDest);
            Controls.Add(buttonSource);
            Controls.Add(labelSource);
            Controls.Add(labelCopied);
            Controls.Add(label2);
            Controls.Add(labelTotal);
            Controls.Add(label1);
            Name = "FormTask4_5";
            Text = "FormTask4_5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label labelTotal;
        private Label labelCopied;
        private Label labelSource;
        private Button buttonSource;
        private Label labelDest;
        private Button buttonDest;
        private Button buttonCopy;
        private Button buttonStop;
        private Button buttonPause;
        private Button buttonContinue;
        private Label label4;
    }
}