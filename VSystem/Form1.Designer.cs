namespace VSystem
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
            this.ParishesCBox = new System.Windows.Forms.ComboBox();
            this.CommunityCBox = new System.Windows.Forms.ComboBox();
            this.ProblemCLBox = new System.Windows.Forms.CheckedListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblProblems = new System.Windows.Forms.Label();
            this.lblParish = new System.Windows.Forms.Label();
            this.lblCommnity = new System.Windows.Forms.Label();
            this.lblVotingSystem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ParishesCBox
            // 
            this.ParishesCBox.BackColor = System.Drawing.Color.Indigo;
            this.ParishesCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ParishesCBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ParishesCBox.ForeColor = System.Drawing.SystemColors.Window;
            this.ParishesCBox.FormattingEnabled = true;
            this.ParishesCBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ParishesCBox.Items.AddRange(new object[] {
            "Kingston",
            "Hanover",
            "Westmoreland",
            "St.Mary",
            "St.Catherine"});
            this.ParishesCBox.Location = new System.Drawing.Point(86, 74);
            this.ParishesCBox.Name = "ParishesCBox";
            this.ParishesCBox.Size = new System.Drawing.Size(121, 21);
            this.ParishesCBox.TabIndex = 0;
            this.ParishesCBox.SelectedIndexChanged += new System.EventHandler(this.ParishesCBox_SelectedIndexChanged);
            // 
            // CommunityCBox
            // 
            this.CommunityCBox.BackColor = System.Drawing.Color.Indigo;
            this.CommunityCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CommunityCBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CommunityCBox.ForeColor = System.Drawing.SystemColors.Window;
            this.CommunityCBox.FormattingEnabled = true;
            this.CommunityCBox.Location = new System.Drawing.Point(654, 64);
            this.CommunityCBox.Name = "CommunityCBox";
            this.CommunityCBox.Size = new System.Drawing.Size(121, 21);
            this.CommunityCBox.TabIndex = 1;
            this.CommunityCBox.SelectedIndexChanged += new System.EventHandler(this.CommunityCBox_SelectedIndexChanged);
            // 
            // ProblemCLBox
            // 
            this.ProblemCLBox.BackColor = System.Drawing.Color.MediumOrchid;
            this.ProblemCLBox.FormattingEnabled = true;
            this.ProblemCLBox.Location = new System.Drawing.Point(310, 121);
            this.ProblemCLBox.Name = "ProblemCLBox";
            this.ProblemCLBox.Size = new System.Drawing.Size(171, 199);
            this.ProblemCLBox.TabIndex = 2;
            this.ProblemCLBox.SelectedIndexChanged += new System.EventHandler(this.ProblemCLBox_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkViolet;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSave.Location = new System.Drawing.Point(164, 331);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 34);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkViolet;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnExit.Location = new System.Drawing.Point(547, 331);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 34);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblProblems
            // 
            this.lblProblems.AutoSize = true;
            this.lblProblems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProblems.ForeColor = System.Drawing.Color.Indigo;
            this.lblProblems.Location = new System.Drawing.Point(323, 84);
            this.lblProblems.Name = "lblProblems";
            this.lblProblems.Size = new System.Drawing.Size(158, 20);
            this.lblProblems.TabIndex = 5;
            this.lblProblems.Text = "Select your Problems";
            // 
            // lblParish
            // 
            this.lblParish.AutoSize = true;
            this.lblParish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParish.ForeColor = System.Drawing.Color.Indigo;
            this.lblParish.Location = new System.Drawing.Point(12, 72);
            this.lblParish.Name = "lblParish";
            this.lblParish.Size = new System.Drawing.Size(53, 20);
            this.lblParish.TabIndex = 6;
            this.lblParish.Text = "Parish";
            // 
            // lblCommnity
            // 
            this.lblCommnity.AutoSize = true;
            this.lblCommnity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommnity.ForeColor = System.Drawing.Color.Indigo;
            this.lblCommnity.Location = new System.Drawing.Point(534, 67);
            this.lblCommnity.Name = "lblCommnity";
            this.lblCommnity.Size = new System.Drawing.Size(92, 20);
            this.lblCommnity.TabIndex = 7;
            this.lblCommnity.Text = " Community";
            // 
            // lblVotingSystem
            // 
            this.lblVotingSystem.AutoSize = true;
            this.lblVotingSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVotingSystem.ForeColor = System.Drawing.Color.Indigo;
            this.lblVotingSystem.Location = new System.Drawing.Point(326, 15);
            this.lblVotingSystem.Name = "lblVotingSystem";
            this.lblVotingSystem.Size = new System.Drawing.Size(156, 25);
            this.lblVotingSystem.TabIndex = 8;
            this.lblVotingSystem.Text = "VotingSystem";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblVotingSystem);
            this.Controls.Add(this.lblCommnity);
            this.Controls.Add(this.lblParish);
            this.Controls.Add(this.lblProblems);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ProblemCLBox);
            this.Controls.Add(this.CommunityCBox);
            this.Controls.Add(this.ParishesCBox);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ParishesCBox;
        private System.Windows.Forms.ComboBox CommunityCBox;
        private System.Windows.Forms.CheckedListBox ProblemCLBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblProblems;
        private System.Windows.Forms.Label lblParish;
        private System.Windows.Forms.Label lblCommnity;
        private System.Windows.Forms.Label lblVotingSystem;
    }
}

