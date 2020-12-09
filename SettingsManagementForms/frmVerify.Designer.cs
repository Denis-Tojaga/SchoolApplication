namespace SchoolApp.SettingsManagementForms
{
    partial class frmVerify
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
            this.cbVerify = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVerify = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbVerify
            // 
            this.cbVerify.AutoSize = true;
            this.cbVerify.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVerify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.cbVerify.Location = new System.Drawing.Point(228, 98);
            this.cbVerify.Name = "cbVerify";
            this.cbVerify.Size = new System.Drawing.Size(73, 22);
            this.cbVerify.TabIndex = 0;
            this.cbVerify.Text = "Verify";
            this.cbVerify.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email Verification";
            // 
            // lblVerify
            // 
            this.lblVerify.AutoSize = true;
            this.lblVerify.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.25F);
            this.lblVerify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(30)))));
            this.lblVerify.Location = new System.Drawing.Point(31, 65);
            this.lblVerify.Name = "lblVerify";
            this.lblVerify.Size = new System.Drawing.Size(152, 16);
            this.lblVerify.TabIndex = 2;
            this.lblVerify.Text = "Email verification for ";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(34, 125);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(267, 27);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirm verification";
            this.btnConfirm.UseVisualStyleBackColor = false;
            // 
            // frmVerify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 164);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblVerify);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbVerify);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmVerify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verify your account";
            this.Load += new System.EventHandler(this.frmVerify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbVerify;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVerify;
        private System.Windows.Forms.Button btnConfirm;
    }
}