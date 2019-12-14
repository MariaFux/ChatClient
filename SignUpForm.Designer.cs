namespace Chat
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.AlreadyLable = new System.Windows.Forms.Label();
            this.RePassLable = new System.Windows.Forms.Label();
            this.RePassField = new System.Windows.Forms.TextBox();
            this.SignInLink = new System.Windows.Forms.LinkLabel();
            this.EnterBtn = new System.Windows.Forms.Button();
            this.PassLable = new System.Windows.Forms.Label();
            this.PassField = new System.Windows.Forms.TextBox();
            this.NameLable = new System.Windows.Forms.Label();
            this.NameField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AlreadyLable
            // 
            this.AlreadyLable.AutoSize = true;
            this.AlreadyLable.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AlreadyLable.Location = new System.Drawing.Point(87, 262);
            this.AlreadyLable.Name = "AlreadyLable";
            this.AlreadyLable.Size = new System.Drawing.Size(126, 14);
            this.AlreadyLable.TabIndex = 64;
            this.AlreadyLable.Text = "Уже есть аккаунт?";
            // 
            // RePassLable
            // 
            this.RePassLable.AutoSize = true;
            this.RePassLable.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RePassLable.Location = new System.Drawing.Point(58, 162);
            this.RePassLable.Name = "RePassLable";
            this.RePassLable.Size = new System.Drawing.Size(144, 18);
            this.RePassLable.TabIndex = 63;
            this.RePassLable.Text = "Повторите пароль:";
            // 
            // RePassField
            // 
            this.RePassField.BackColor = System.Drawing.Color.GhostWhite;
            this.RePassField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RePassField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RePassField.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RePassField.Location = new System.Drawing.Point(62, 187);
            this.RePassField.Name = "RePassField";
            this.RePassField.Size = new System.Drawing.Size(233, 28);
            this.RePassField.TabIndex = 60;
            this.RePassField.UseSystemPasswordChar = true;
            this.RePassField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RePassField_KeyDown);
            this.RePassField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RePassField_KeyPress);
            // 
            // SignInLink
            // 
            this.SignInLink.ActiveLinkColor = System.Drawing.Color.Indigo;
            this.SignInLink.AutoSize = true;
            this.SignInLink.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignInLink.LinkColor = System.Drawing.Color.Navy;
            this.SignInLink.Location = new System.Drawing.Point(217, 261);
            this.SignInLink.Name = "SignInLink";
            this.SignInLink.Size = new System.Drawing.Size(42, 14);
            this.SignInLink.TabIndex = 62;
            this.SignInLink.TabStop = true;
            this.SignInLink.Text = "Войти";
            this.SignInLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignInLink_LinkClicked);
            // 
            // EnterBtn
            // 
            this.EnterBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.EnterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterBtn.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterBtn.Location = new System.Drawing.Point(62, 226);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(233, 30);
            this.EnterBtn.TabIndex = 61;
            this.EnterBtn.Text = "Войти";
            this.EnterBtn.UseVisualStyleBackColor = false;
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // PassLable
            // 
            this.PassLable.AutoSize = true;
            this.PassLable.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassLable.Location = new System.Drawing.Point(58, 106);
            this.PassLable.Name = "PassLable";
            this.PassLable.Size = new System.Drawing.Size(64, 18);
            this.PassLable.TabIndex = 59;
            this.PassLable.Text = "Пароль:";
            // 
            // PassField
            // 
            this.PassField.BackColor = System.Drawing.Color.GhostWhite;
            this.PassField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassField.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassField.Location = new System.Drawing.Point(62, 131);
            this.PassField.Name = "PassField";
            this.PassField.Size = new System.Drawing.Size(233, 28);
            this.PassField.TabIndex = 58;
            this.PassField.UseSystemPasswordChar = true;
            this.PassField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassField_KeyPress);
            // 
            // NameLable
            // 
            this.NameLable.AutoSize = true;
            this.NameLable.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLable.Location = new System.Drawing.Point(58, 51);
            this.NameLable.Name = "NameLable";
            this.NameLable.Size = new System.Drawing.Size(144, 18);
            this.NameLable.TabIndex = 57;
            this.NameLable.Text = "Имя пользователя:";
            // 
            // NameField
            // 
            this.NameField.BackColor = System.Drawing.Color.GhostWhite;
            this.NameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameField.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameField.Location = new System.Drawing.Point(62, 75);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(233, 28);
            this.NameField.TabIndex = 56;
            this.NameField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameField_KeyPress);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(352, 322);
            this.Controls.Add(this.AlreadyLable);
            this.Controls.Add(this.SignInLink);
            this.Controls.Add(this.EnterBtn);
            this.Controls.Add(this.RePassLable);
            this.Controls.Add(this.RePassField);
            this.Controls.Add(this.PassLable);
            this.Controls.Add(this.PassField);
            this.Controls.Add(this.NameLable);
            this.Controls.Add(this.NameField);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SignUpForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignUpForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AlreadyLable;        
        private System.Windows.Forms.LinkLabel SignInLink;
        private System.Windows.Forms.Button EnterBtn;
        private System.Windows.Forms.Label RePassLable;
        private System.Windows.Forms.TextBox RePassField;
        private System.Windows.Forms.Label PassLable;
        private System.Windows.Forms.TextBox PassField;
        private System.Windows.Forms.Label NameLable;
        private System.Windows.Forms.TextBox NameField;
    }
}