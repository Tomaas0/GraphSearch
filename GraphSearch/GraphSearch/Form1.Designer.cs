namespace GraphSearch
{
    partial class Form1
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
            this.fakeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fakeButton
            // 
            this.fakeButton.Location = new System.Drawing.Point(947, 1639);
            this.fakeButton.Name = "fakeButton";
            this.fakeButton.Size = new System.Drawing.Size(267, 36);
            this.fakeButton.TabIndex = 0;
            this.fakeButton.Text = "Start";
            this.fakeButton.UseVisualStyleBackColor = true;
            this.fakeButton.Click += new System.EventHandler(this.fakeButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.fakeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1492, 2113);
            this.Controls.Add(this.fakeButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fakeButton;
    }
}

