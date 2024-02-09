namespace MultiThreading
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
            labelCounter = new Label();
            buttonStart = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // labelCounter
            // 
            labelCounter.AutoSize = true;
            labelCounter.Location = new Point(208, 239);
            labelCounter.Name = "labelCounter";
            labelCounter.Size = new Size(19, 15);
            labelCounter.TabIndex = 0;
            labelCounter.Text = "....";
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(178, 202);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(75, 23);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "Başlat";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // button1
            // 
            button1.Location = new Point(363, 28);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 450);
            Controls.Add(button1);
            Controls.Add(buttonStart);
            Controls.Add(labelCounter);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCounter;
        private Button buttonStart;
        private Button button1;
    }
}
