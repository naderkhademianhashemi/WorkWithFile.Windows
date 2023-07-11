namespace WorkWithFile.Windows
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSlctFLDR = new System.Windows.Forms.Button();
            this.btnLstFLDR = new System.Windows.Forms.Button();
            this.btnMergeFileFldr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(402, 22);
            this.textBox1.TabIndex = 0;
            // 
            // btnSlctFLDR
            // 
            this.btnSlctFLDR.Location = new System.Drawing.Point(484, 29);
            this.btnSlctFLDR.Name = "btnSlctFLDR";
            this.btnSlctFLDR.Size = new System.Drawing.Size(105, 23);
            this.btnSlctFLDR.TabIndex = 1;
            this.btnSlctFLDR.Text = "select FLDR";
            this.btnSlctFLDR.UseVisualStyleBackColor = true;
            this.btnSlctFLDR.Click += new System.EventHandler(this.btnSlctFLDR_Click);
            // 
            // btnLstFLDR
            // 
            this.btnLstFLDR.Location = new System.Drawing.Point(484, 123);
            this.btnLstFLDR.Name = "btnLstFLDR";
            this.btnLstFLDR.Size = new System.Drawing.Size(151, 23);
            this.btnLstFLDR.TabIndex = 3;
            this.btnLstFLDR.Text = "save list FLDRs";
            this.btnLstFLDR.UseVisualStyleBackColor = true;
            this.btnLstFLDR.Click += new System.EventHandler(this.btnLstFLDR_Click);
            // 
            // btnMergeFileFldr
            // 
            this.btnMergeFileFldr.Location = new System.Drawing.Point(507, 193);
            this.btnMergeFileFldr.Name = "btnMergeFileFldr";
            this.btnMergeFileFldr.Size = new System.Drawing.Size(112, 53);
            this.btnMergeFileFldr.TabIndex = 4;
            this.btnMergeFileFldr.Text = "merge file content of fldr";
            this.btnMergeFileFldr.UseVisualStyleBackColor = true;
            this.btnMergeFileFldr.Click += new System.EventHandler(this.btnMergeFileFldr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMergeFileFldr);
            this.Controls.Add(this.btnLstFLDR);
            this.Controls.Add(this.btnSlctFLDR);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSlctFLDR;
        private System.Windows.Forms.Button btnLstFLDR;
        private System.Windows.Forms.Button btnMergeFileFldr;
    }
}

