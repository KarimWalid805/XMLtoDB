namespace XMLtoDB

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
            btnBrowse = new Button();
            txtimport = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(563, 56);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(194, 43);
            btnBrowse.TabIndex = 0;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_click;
            // 
            // txtimport
            // 
            txtimport.Location = new Point(557, 120);
            txtimport.Name = "txtimport";
            txtimport.Size = new Size(200, 32);
            txtimport.TabIndex = 1;
            txtimport.Text = "Import";
            txtimport.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(512, 23);
            textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 217);
            Controls.Add(textBox1);
            Controls.Add(txtimport);
            Controls.Add(btnBrowse);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBrowse;
        private Button txtimport;
        private TextBox textBox1;
    }
}
