namespace MultiTasking
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
            button1 = new Button();
            buttonStart = new Button();
            labelCounter = new Label();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(426, 29);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(241, 203);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(75, 23);
            buttonStart.TabIndex = 4;
            buttonStart.Text = "Başlat";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // labelCounter
            // 
            labelCounter.AutoSize = true;
            labelCounter.Location = new Point(271, 240);
            labelCounter.Name = "labelCounter";
            labelCounter.Size = new Size(19, 15);
            labelCounter.TabIndex = 3;
            labelCounter.Text = "....";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(229, 269);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(100, 23);
            progressBar1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 494);
            Controls.Add(progressBar1);
            Controls.Add(button1);
            Controls.Add(buttonStart);
            Controls.Add(labelCounter);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button buttonStart;
        private Label labelCounter;
        private ProgressBar progressBar1;
    }
}
