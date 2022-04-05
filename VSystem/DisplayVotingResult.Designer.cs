namespace VSystem
{
    partial class DisplayVotingResult
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
            this.lblParishR = new System.Windows.Forms.Label();
            this.lblCommunityR = new System.Windows.Forms.Label();
            this.lblProblemsR = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblParishR
            // 
            this.lblParishR.AutoSize = true;
            this.lblParishR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParishR.ForeColor = System.Drawing.Color.Indigo;
            this.lblParishR.Location = new System.Drawing.Point(128, 37);
            this.lblParishR.Name = "lblParishR";
            this.lblParishR.Size = new System.Drawing.Size(114, 24);
            this.lblParishR.TabIndex = 0;
            this.lblParishR.Text = "ParishResult";
            // 
            // lblCommunityR
            // 
            this.lblCommunityR.AutoSize = true;
            this.lblCommunityR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommunityR.ForeColor = System.Drawing.Color.Indigo;
            this.lblCommunityR.Location = new System.Drawing.Point(129, 137);
            this.lblCommunityR.Name = "lblCommunityR";
            this.lblCommunityR.Size = new System.Drawing.Size(157, 24);
            this.lblCommunityR.TabIndex = 1;
            this.lblCommunityR.Text = "CommunityResult";
            // 
            // lblProblemsR
            // 
            this.lblProblemsR.AutoSize = true;
            this.lblProblemsR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProblemsR.ForeColor = System.Drawing.Color.Indigo;
            this.lblProblemsR.Location = new System.Drawing.Point(129, 232);
            this.lblProblemsR.Name = "lblProblemsR";
            this.lblProblemsR.Size = new System.Drawing.Size(133, 24);
            this.lblProblemsR.TabIndex = 2;
            this.lblProblemsR.Text = "ProblemResult";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Indigo;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(150, 301);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 27);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // DisplayVotingResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(497, 356);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblProblemsR);
            this.Controls.Add(this.lblCommunityR);
            this.Controls.Add(this.lblParishR);
            this.Name = "DisplayVotingResult";
            this.Text = "DisplayVotingResult";
            this.Load += new System.EventHandler(this.DisplayVotingResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblParishR;
        private System.Windows.Forms.Label lblCommunityR;
        private System.Windows.Forms.Label lblProblemsR;
        private System.Windows.Forms.Button btnExit;
    }
}