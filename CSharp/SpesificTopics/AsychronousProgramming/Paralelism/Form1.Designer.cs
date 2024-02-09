namespace Paralelism
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
            buttonParallel1 = new Button();
            listBoxNumbers = new ListBox();
            SuspendLayout();
            // 
            // buttonParallel1
            // 
            buttonParallel1.Location = new Point(59, 109);
            buttonParallel1.Name = "buttonParallel1";
            buttonParallel1.Size = new Size(75, 23);
            buttonParallel1.TabIndex = 0;
            buttonParallel1.Text = "ForEach";
            buttonParallel1.UseVisualStyleBackColor = true;
            buttonParallel1.Click += buttonParallel1_Click;
            // 
            // listBoxNumbers
            // 
            listBoxNumbers.FormattingEnabled = true;
            listBoxNumbers.ItemHeight = 15;
            listBoxNumbers.Location = new Point(288, 40);
            listBoxNumbers.Name = "listBoxNumbers";
            listBoxNumbers.Size = new Size(235, 379);
            listBoxNumbers.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 444);
            Controls.Add(listBoxNumbers);
            Controls.Add(buttonParallel1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonParallel1;
        private ListBox listBoxNumbers;
    }
}
