namespace MonetarWin
{
    partial class FormConfig
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
            this.lblPasswordUnlock = new System.Windows.Forms.Label();
            this.txtPasswordUnlock = new System.Windows.Forms.TextBox();
            this.btnUnlockConfig = new System.Windows.Forms.Button();
            this.grpConfig = new System.Windows.Forms.GroupBox();
            this.btnResetConfig = new System.Windows.Forms.Button();
            this.lblWarnMsg = new System.Windows.Forms.Label();
            this.txtWarnMsg = new System.Windows.Forms.TextBox();
            this.lblBranchAddress = new System.Windows.Forms.Label();
            this.txtBranchAddress = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblBranchName = new System.Windows.Forms.Label();
            this.txtBranchName = new System.Windows.Forms.TextBox();
            this.grpConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPasswordUnlock
            // 
            this.lblPasswordUnlock.AutoSize = true;
            this.lblPasswordUnlock.Location = new System.Drawing.Point(22, 16);
            this.lblPasswordUnlock.Name = "lblPasswordUnlock";
            this.lblPasswordUnlock.Size = new System.Drawing.Size(122, 13);
            this.lblPasswordUnlock.TabIndex = 9;
            this.lblPasswordUnlock.Text = "Parolă deblocare config.";
            // 
            // txtPasswordUnlock
            // 
            this.txtPasswordUnlock.Location = new System.Drawing.Point(154, 13);
            this.txtPasswordUnlock.MaxLength = 30;
            this.txtPasswordUnlock.Name = "txtPasswordUnlock";
            this.txtPasswordUnlock.PasswordChar = '*';
            this.txtPasswordUnlock.Size = new System.Drawing.Size(185, 20);
            this.txtPasswordUnlock.TabIndex = 10;
            // 
            // btnUnlockConfig
            // 
            this.btnUnlockConfig.Location = new System.Drawing.Point(345, 12);
            this.btnUnlockConfig.Name = "btnUnlockConfig";
            this.btnUnlockConfig.Size = new System.Drawing.Size(156, 23);
            this.btnUnlockConfig.TabIndex = 11;
            this.btnUnlockConfig.Text = "Deblocare configurare";
            this.btnUnlockConfig.UseVisualStyleBackColor = true;
            this.btnUnlockConfig.Click += new System.EventHandler(this.btnUnlockConfig_Click);
            // 
            // grpConfig
            // 
            this.grpConfig.Controls.Add(this.btnResetConfig);
            this.grpConfig.Controls.Add(this.lblWarnMsg);
            this.grpConfig.Controls.Add(this.txtWarnMsg);
            this.grpConfig.Controls.Add(this.lblBranchAddress);
            this.grpConfig.Controls.Add(this.txtBranchAddress);
            this.grpConfig.Controls.Add(this.btnCancel);
            this.grpConfig.Controls.Add(this.btnOK);
            this.grpConfig.Controls.Add(this.lblBranchName);
            this.grpConfig.Controls.Add(this.txtBranchName);
            this.grpConfig.Enabled = false;
            this.grpConfig.Location = new System.Drawing.Point(16, 44);
            this.grpConfig.Name = "grpConfig";
            this.grpConfig.Size = new System.Drawing.Size(485, 187);
            this.grpConfig.TabIndex = 12;
            this.grpConfig.TabStop = false;
            this.grpConfig.Text = "Configurare";
            // 
            // btnResetConfig
            // 
            this.btnResetConfig.Location = new System.Drawing.Point(6, 158);
            this.btnResetConfig.Name = "btnResetConfig";
            this.btnResetConfig.Size = new System.Drawing.Size(130, 23);
            this.btnResetConfig.TabIndex = 17;
            this.btnResetConfig.Text = "Resetare configurație";
            this.btnResetConfig.UseVisualStyleBackColor = true;
            this.btnResetConfig.Click += new System.EventHandler(this.btnResetConfig_Click);
            // 
            // lblWarnMsg
            // 
            this.lblWarnMsg.AutoSize = true;
            this.lblWarnMsg.Location = new System.Drawing.Point(6, 77);
            this.lblWarnMsg.Name = "lblWarnMsg";
            this.lblWarnMsg.Size = new System.Drawing.Size(91, 13);
            this.lblWarnMsg.TabIndex = 15;
            this.lblWarnMsg.Text = "Mesaj atenționare";
            // 
            // txtWarnMsg
            // 
            this.txtWarnMsg.AcceptsReturn = true;
            this.txtWarnMsg.Location = new System.Drawing.Point(138, 74);
            this.txtWarnMsg.MaxLength = 512;
            this.txtWarnMsg.Multiline = true;
            this.txtWarnMsg.Name = "txtWarnMsg";
            this.txtWarnMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtWarnMsg.Size = new System.Drawing.Size(342, 46);
            this.txtWarnMsg.TabIndex = 16;
            // 
            // lblBranchAddress
            // 
            this.lblBranchAddress.AutoSize = true;
            this.lblBranchAddress.Location = new System.Drawing.Point(6, 50);
            this.lblBranchAddress.Name = "lblBranchAddress";
            this.lblBranchAddress.Size = new System.Drawing.Size(66, 13);
            this.lblBranchAddress.TabIndex = 11;
            this.lblBranchAddress.Text = "Adresă filială";
            // 
            // txtBranchAddress
            // 
            this.txtBranchAddress.Location = new System.Drawing.Point(138, 47);
            this.txtBranchAddress.MaxLength = 512;
            this.txtBranchAddress.Name = "txtBranchAddress";
            this.txtBranchAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBranchAddress.Size = new System.Drawing.Size(342, 20);
            this.txtBranchAddress.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(405, 158);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Renunță";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(322, 158);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblBranchName
            // 
            this.lblBranchName.AutoSize = true;
            this.lblBranchName.Location = new System.Drawing.Point(6, 24);
            this.lblBranchName.Name = "lblBranchName";
            this.lblBranchName.Size = new System.Drawing.Size(61, 13);
            this.lblBranchName.TabIndex = 10;
            this.lblBranchName.Text = "Nume filială";
            // 
            // txtBranchName
            // 
            this.txtBranchName.Location = new System.Drawing.Point(138, 21);
            this.txtBranchName.MaxLength = 512;
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBranchName.Size = new System.Drawing.Size(342, 20);
            this.txtBranchName.TabIndex = 9;
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 243);
            this.Controls.Add(this.grpConfig);
            this.Controls.Add(this.btnUnlockConfig);
            this.Controls.Add(this.txtPasswordUnlock);
            this.Controls.Add(this.lblPasswordUnlock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormConfig";
            this.Text = "Configurare";
            this.Load += new System.EventHandler(this.FormConfig_Load);
            this.grpConfig.ResumeLayout(false);
            this.grpConfig.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPasswordUnlock;
        private System.Windows.Forms.TextBox txtPasswordUnlock;
        private System.Windows.Forms.Button btnUnlockConfig;
        private System.Windows.Forms.GroupBox grpConfig;
        private System.Windows.Forms.Button btnResetConfig;
        private System.Windows.Forms.Label lblWarnMsg;
        private System.Windows.Forms.TextBox txtWarnMsg;
        private System.Windows.Forms.Label lblBranchAddress;
        private System.Windows.Forms.TextBox txtBranchAddress;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblBranchName;
        private System.Windows.Forms.TextBox txtBranchName;
    }
}