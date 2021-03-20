
namespace AxySnake_Trainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.HPSet = new System.Windows.Forms.Button();
            this.ScoreSet = new System.Windows.Forms.Button();
            this.GameProcessInfo = new System.Windows.Forms.Label();
            this.GameProcessStatus = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.Label();
            this.GitHubProjectLink = new System.Windows.Forms.Label();
            this.HPText = new System.Windows.Forms.TextBox();
            this.ScoreText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // HPSet
            // 
            this.HPSet.Location = new System.Drawing.Point(183, 56);
            this.HPSet.Name = "HPSet";
            this.HPSet.Size = new System.Drawing.Size(158, 23);
            this.HPSet.TabIndex = 0;
            this.HPSet.Text = "Set HP";
            this.HPSet.UseVisualStyleBackColor = true;
            this.HPSet.Visible = false;
            this.HPSet.Click += new System.EventHandler(this.HPSet_Click);
            // 
            // ScoreSet
            // 
            this.ScoreSet.Location = new System.Drawing.Point(183, 99);
            this.ScoreSet.Name = "ScoreSet";
            this.ScoreSet.Size = new System.Drawing.Size(158, 23);
            this.ScoreSet.TabIndex = 1;
            this.ScoreSet.Text = "Set score";
            this.ScoreSet.UseVisualStyleBackColor = true;
            this.ScoreSet.Visible = false;
            this.ScoreSet.Click += new System.EventHandler(this.ScoreSet_Click);
            // 
            // GameProcessInfo
            // 
            this.GameProcessInfo.AutoSize = true;
            this.GameProcessInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GameProcessInfo.Location = new System.Drawing.Point(8, 9);
            this.GameProcessInfo.Name = "GameProcessInfo";
            this.GameProcessInfo.Size = new System.Drawing.Size(172, 24);
            this.GameProcessInfo.TabIndex = 2;
            this.GameProcessInfo.Text = "AxySnake process:";
            // 
            // GameProcessStatus
            // 
            this.GameProcessStatus.AutoSize = true;
            this.GameProcessStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GameProcessStatus.ForeColor = System.Drawing.Color.Red;
            this.GameProcessStatus.Location = new System.Drawing.Point(186, 9);
            this.GameProcessStatus.Name = "GameProcessStatus";
            this.GameProcessStatus.Size = new System.Drawing.Size(155, 24);
            this.GameProcessStatus.TabIndex = 3;
            this.GameProcessStatus.Text = "NOT STARTED";
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.ForeColor = System.Drawing.SystemColors.Control;
            this.Author.Location = new System.Drawing.Point(12, 146);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(89, 13);
            this.Author.TabIndex = 6;
            this.Author.Text = "Created by Ereno";
            // 
            // GitHubProjectLink
            // 
            this.GitHubProjectLink.AutoSize = true;
            this.GitHubProjectLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GitHubProjectLink.ForeColor = System.Drawing.Color.MediumBlue;
            this.GitHubProjectLink.Location = new System.Drawing.Point(277, 146);
            this.GitHubProjectLink.Name = "GitHubProjectLink";
            this.GitHubProjectLink.Size = new System.Drawing.Size(75, 13);
            this.GitHubProjectLink.TabIndex = 7;
            this.GitHubProjectLink.Text = "GitHub project";
            this.GitHubProjectLink.Click += new System.EventHandler(this.GitHubProjectLink_Click);
            // 
            // HPText
            // 
            this.HPText.Location = new System.Drawing.Point(15, 58);
            this.HPText.Name = "HPText";
            this.HPText.Size = new System.Drawing.Size(152, 20);
            this.HPText.TabIndex = 8;
            this.HPText.Text = "99";
            this.HPText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HPText.Visible = false;
            // 
            // ScoreText
            // 
            this.ScoreText.Location = new System.Drawing.Point(15, 99);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(152, 20);
            this.ScoreText.TabIndex = 9;
            this.ScoreText.Text = "999999";
            this.ScoreText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ScoreText.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(364, 168);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.HPText);
            this.Controls.Add(this.GitHubProjectLink);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.GameProcessStatus);
            this.Controls.Add(this.GameProcessInfo);
            this.Controls.Add(this.ScoreSet);
            this.Controls.Add(this.HPSet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "AxySnake Trainer v1.0";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button HPSet;
        private System.Windows.Forms.Button ScoreSet;
        private System.Windows.Forms.Label GameProcessInfo;
        private System.Windows.Forms.Label GameProcessStatus;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.Label GitHubProjectLink;
        private System.Windows.Forms.TextBox HPText;
        private System.Windows.Forms.TextBox ScoreText;
    }
}

