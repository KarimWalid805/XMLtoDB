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
            btnImport = new Button();
            txtFilePath = new TextBox();
            OFD = new OpenFileDialog();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(643, 75);
            btnBrowse.Margin = new Padding(3, 4, 3, 4);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(222, 57);
            btnBrowse.TabIndex = 0;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_click;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(637, 160);
            btnImport.Margin = new Padding(3, 4, 3, 4);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(229, 43);
            btnImport.TabIndex = 1;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(24, 75);
            txtFilePath.Margin = new Padding(3, 4, 3, 4);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(570, 27);
            txtFilePath.TabIndex = 2;
            // 
            // OFD
            // 
            OFD.FileName = "openFileDialog1";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(24, 166);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(570, 29);
            progressBar1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 289);
            Controls.Add(progressBar1);
            Controls.Add(txtFilePath);
            Controls.Add(btnImport);
            Controls.Add(btnBrowse);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBrowse;
        private Button btnImport;
        private TextBox txtFilePath;
        private OpenFileDialog OFD;
        private ProgressBar progressBar1;
    }
}
