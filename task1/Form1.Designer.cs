namespace task1
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
            btnRefill = new Button();
            txtInfo = new RichTextBox();
            txtOut = new RichTextBox();
            btnGet = new Button();
            txtLine = new RichTextBox();
            SuspendLayout();
            // 
            // btnRefill
            // 
            btnRefill.Location = new Point(25, 12);
            btnRefill.Name = "btnRefill";
            btnRefill.Size = new Size(316, 23);
            btnRefill.TabIndex = 0;
            btnRefill.Text = "Перезаполнить";
            btnRefill.UseVisualStyleBackColor = true;
            btnRefill.Click += btnRefill_Click;
            // 
            // txtInfo
            // 
            txtInfo.BorderStyle = BorderStyle.None;
            txtInfo.Location = new Point(25, 51);
            txtInfo.Name = "txtInfo";
            txtInfo.ReadOnly = true;
            txtInfo.Size = new Size(155, 69);
            txtInfo.TabIndex = 1;
            txtInfo.Text = "";
            // 
            // txtOut
            // 
            txtOut.Location = new Point(12, 495);
            txtOut.Name = "txtOut";
            txtOut.Size = new Size(364, 96);
            txtOut.TabIndex = 2;
            txtOut.Text = "";
            // 
            // btnGet
            // 
            btnGet.Location = new Point(382, 495);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(104, 96);
            btnGet.TabIndex = 3;
            btnGet.Text = "Взять";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // txtLine
            // 
            txtLine.Location = new Point(186, 48);
            txtLine.Name = "txtLine";
            txtLine.Size = new Size(300, 441);
            txtLine.TabIndex = 4;
            txtLine.Text = "";
            
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 603);
            Controls.Add(txtLine);
            Controls.Add(btnGet);
            Controls.Add(txtOut);
            Controls.Add(txtInfo);
            Controls.Add(btnRefill);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRefill;
        private RichTextBox txtInfo;
        private RichTextBox txtOut;
        private Button btnGet;
        private RichTextBox txtLine;
    }
}
