﻿namespace Links.Forms
{
    partial class frmGeneralSettings
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
            this.lblApplicationBehaviour = new System.Windows.Forms.Label();
            this.chkTopMost = new System.Windows.Forms.CheckBox();
            this.chkWaitForNetwork = new System.Windows.Forms.CheckBox();
            this.lblStartupOptions = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGeneralSettingsTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblGeneralSettingsText = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpSeparator1 = new System.Windows.Forms.GroupBox();
            this.grpSeparator2 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblApplicationBehaviour
            // 
            this.lblApplicationBehaviour.AutoSize = true;
            this.lblApplicationBehaviour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationBehaviour.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationBehaviour.Location = new System.Drawing.Point(19, 90);
            this.lblApplicationBehaviour.Name = "lblApplicationBehaviour";
            this.lblApplicationBehaviour.Size = new System.Drawing.Size(131, 13);
            this.lblApplicationBehaviour.TabIndex = 3;
            this.lblApplicationBehaviour.Text = "Application Behaviour";
            // 
            // chkTopMost
            // 
            this.chkTopMost.AutoSize = true;
            this.chkTopMost.Checked = true;
            this.chkTopMost.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTopMost.Location = new System.Drawing.Point(36, 124);
            this.chkTopMost.Name = "chkTopMost";
            this.chkTopMost.Size = new System.Drawing.Size(165, 17);
            this.chkTopMost.TabIndex = 0;
            this.chkTopMost.Text = "The Links window is top most";
            this.chkTopMost.UseVisualStyleBackColor = true;
            // 
            // chkWaitForNetwork
            // 
            this.chkWaitForNetwork.AutoSize = true;
            this.chkWaitForNetwork.Checked = true;
            this.chkWaitForNetwork.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWaitForNetwork.Location = new System.Drawing.Point(36, 42);
            this.chkWaitForNetwork.Name = "chkWaitForNetwork";
            this.chkWaitForNetwork.Size = new System.Drawing.Size(104, 17);
            this.chkWaitForNetwork.TabIndex = 4;
            this.chkWaitForNetwork.Text = "Wait for network";
            this.chkWaitForNetwork.UseVisualStyleBackColor = true;
            // 
            // lblStartupOptions
            // 
            this.lblStartupOptions.AutoSize = true;
            this.lblStartupOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartupOptions.ForeColor = System.Drawing.Color.Black;
            this.lblStartupOptions.Location = new System.Drawing.Point(19, 13);
            this.lblStartupOptions.Name = "lblStartupOptions";
            this.lblStartupOptions.Size = new System.Drawing.Size(95, 13);
            this.lblStartupOptions.TabIndex = 5;
            this.lblStartupOptions.Text = "Startup Options";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblGeneralSettingsText);
            this.panel1.Controls.Add(this.lblGeneralSettingsTitle);
            this.panel1.Location = new System.Drawing.Point(6, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 50);
            this.panel1.TabIndex = 1;
            // 
            // lblGeneralSettingsTitle
            // 
            this.lblGeneralSettingsTitle.AutoSize = true;
            this.lblGeneralSettingsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneralSettingsTitle.ForeColor = System.Drawing.Color.Black;
            this.lblGeneralSettingsTitle.Location = new System.Drawing.Point(11, 16);
            this.lblGeneralSettingsTitle.Name = "lblGeneralSettingsTitle";
            this.lblGeneralSettingsTitle.Size = new System.Drawing.Size(103, 13);
            this.lblGeneralSettingsTitle.TabIndex = 6;
            this.lblGeneralSettingsTitle.Text = "General settings:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.grpSeparator2);
            this.panel2.Controls.Add(this.grpSeparator1);
            this.panel2.Controls.Add(this.lblStartupOptions);
            this.panel2.Controls.Add(this.chkWaitForNetwork);
            this.panel2.Controls.Add(this.chkTopMost);
            this.panel2.Controls.Add(this.lblApplicationBehaviour);
            this.panel2.Location = new System.Drawing.Point(6, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(398, 211);
            this.panel2.TabIndex = 2;
            // 
            // lblGeneralSettingsText
            // 
            this.lblGeneralSettingsText.AutoSize = true;
            this.lblGeneralSettingsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneralSettingsText.ForeColor = System.Drawing.Color.Black;
            this.lblGeneralSettingsText.Location = new System.Drawing.Point(114, 17);
            this.lblGeneralSettingsText.Name = "lblGeneralSettingsText";
            this.lblGeneralSettingsText.Size = new System.Drawing.Size(209, 13);
            this.lblGeneralSettingsText.TabIndex = 7;
            this.lblGeneralSettingsText.Text = "Set up all the basics you need to use Links";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(310, 280);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 24);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Cancel";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(210, 280);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 24);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpSeparator1
            // 
            this.grpSeparator1.Location = new System.Drawing.Point(22, 25);
            this.grpSeparator1.Name = "grpSeparator1";
            this.grpSeparator1.Size = new System.Drawing.Size(355, 10);
            this.grpSeparator1.TabIndex = 6;
            this.grpSeparator1.TabStop = false;
            // 
            // grpSeparator2
            // 
            this.grpSeparator2.Location = new System.Drawing.Point(22, 103);
            this.grpSeparator2.Name = "grpSeparator2";
            this.grpSeparator2.Size = new System.Drawing.Size(355, 10);
            this.grpSeparator2.TabIndex = 7;
            this.grpSeparator2.TabStop = false;
            // 
            // frmGeneralSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 310);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGeneralSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox chkTopMost;
        private System.Windows.Forms.Label lblApplicationBehaviour;
        private System.Windows.Forms.CheckBox chkWaitForNetwork;
        private System.Windows.Forms.Label lblStartupOptions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblGeneralSettingsTitle;
        private System.Windows.Forms.Label lblGeneralSettingsText;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpSeparator2;
        private System.Windows.Forms.GroupBox grpSeparator1;
    }
}