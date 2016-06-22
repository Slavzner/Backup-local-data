namespace BackupLocalData
{
    partial class BackupForm
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
            this.lblSource = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.textBoxSource = new System.Windows.Forms.TextBox();
            this.textBoxTarget = new System.Windows.Forms.TextBox();
            this.btnBrowseSource = new System.Windows.Forms.Button();
            this.btnBrowseTarget = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(12, 9);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(66, 13);
            this.lblSource.TabIndex = 0;
            this.lblSource.Text = "Source Path";
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(12, 38);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(63, 13);
            this.lblTarget.TabIndex = 1;
            this.lblTarget.Text = "Target Path";
            // 
            // textBoxSource
            // 
            this.textBoxSource.Location = new System.Drawing.Point(84, 6);
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.Size = new System.Drawing.Size(350, 20);
            this.textBoxSource.TabIndex = 2;
            // 
            // textBoxTarget
            // 
            this.textBoxTarget.Location = new System.Drawing.Point(84, 35);
            this.textBoxTarget.Name = "textBoxTarget";
            this.textBoxTarget.Size = new System.Drawing.Size(350, 20);
            this.textBoxTarget.TabIndex = 3;
            // 
            // btnBrowseSource
            // 
            this.btnBrowseSource.Location = new System.Drawing.Point(440, 4);
            this.btnBrowseSource.Name = "btnBrowseSource";
            this.btnBrowseSource.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseSource.TabIndex = 4;
            this.btnBrowseSource.Text = "Browse";
            this.btnBrowseSource.UseVisualStyleBackColor = true;
            // 
            // btnBrowseTarget
            // 
            this.btnBrowseTarget.Location = new System.Drawing.Point(440, 33);
            this.btnBrowseTarget.Name = "btnBrowseTarget";
            this.btnBrowseTarget.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseTarget.TabIndex = 5;
            this.btnBrowseTarget.Text = "Browse";
            this.btnBrowseTarget.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(84, 75);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(350, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // BackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 110);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnBrowseTarget);
            this.Controls.Add(this.btnBrowseSource);
            this.Controls.Add(this.textBoxTarget);
            this.Controls.Add(this.textBoxSource);
            this.Controls.Add(this.lblTarget);
            this.Controls.Add(this.lblSource);
            this.Name = "BackupForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.TextBox textBoxSource;
        private System.Windows.Forms.TextBox textBoxTarget;
        private System.Windows.Forms.Button btnBrowseSource;
        private System.Windows.Forms.Button btnBrowseTarget;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

