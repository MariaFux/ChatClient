namespace Chat
{
    partial class SignInForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInForm));
            this.SignUpLink = new System.Windows.Forms.LinkLabel();
            this.EnterBtn = new System.Windows.Forms.Button();
            this.PassLable = new System.Windows.Forms.Label();
            this.PassField = new System.Windows.Forms.TextBox();
            this.NameLable = new System.Windows.Forms.Label();
            this.NameField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SignUpLink
            // 
            this.SignUpLink.ActiveLinkColor = System.Drawing.Color.Indigo;
            this.SignUpLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SignUpLink.AutoSize = true;
            this.SignUpLink.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignUpLink.LinkColor = System.Drawing.Color.Navy;
            this.SignUpLink.Location = new System.Drawing.Point(90, 195);
            this.SignUpLink.Name = "SignUpLink";
            this.SignUpLink.Size = new System.Drawing.Size(133, 14);
            this.SignUpLink.TabIndex = 29;
            this.SignUpLink.TabStop = true;
            this.SignUpLink.Text = "Зарегистрироваться";
            this.SignUpLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignUpLink_LinkClicked);
            // 
            // EnterBtn
            // 
            this.EnterBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.EnterBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EnterBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.EnterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterBtn.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterBtn.Location = new System.Drawing.Point(53, 160);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(200, 28);
            this.EnterBtn.TabIndex = 28;
            this.EnterBtn.Text = "Войти";
            this.EnterBtn.UseVisualStyleBackColor = false;
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // PassLable
            // 
            this.PassLable.AutoSize = true;
            this.PassLable.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassLable.Location = new System.Drawing.Point(50, 100);
            this.PassLable.Name = "PassLable";
            this.PassLable.Size = new System.Drawing.Size(64, 18);
            this.PassLable.TabIndex = 27;
            this.PassLable.Text = "Пароль:";
            // 
            // PassField
            // 
            this.PassField.BackColor = System.Drawing.Color.GhostWhite;
            this.PassField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassField.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassField.Location = new System.Drawing.Point(53, 123);
            this.PassField.Name = "PassField";
            this.PassField.Size = new System.Drawing.Size(200, 28);
            this.PassField.TabIndex = 26;
            this.PassField.UseSystemPasswordChar = true;
            this.PassField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PassField_KeyDown);
            this.PassField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassField_KeyPress);
            // 
            // NameLable
            // 
            this.NameLable.AutoSize = true;
            this.NameLable.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLable.Location = new System.Drawing.Point(50, 49);
            this.NameLable.Name = "NameLable";
            this.NameLable.Size = new System.Drawing.Size(144, 18);
            this.NameLable.TabIndex = 25;
            this.NameLable.Text = "Имя пользователя:";
            // 
            // NameField
            // 
            this.NameField.BackColor = System.Drawing.Color.GhostWhite;
            this.NameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameField.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameField.Location = new System.Drawing.Point(53, 71);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(200, 28);
            this.NameField.TabIndex = 24;
            this.NameField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameField_KeyPress);
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(302, 257);
            this.Controls.Add(this.SignUpLink);
            this.Controls.Add(this.EnterBtn);
            this.Controls.Add(this.PassLable);
            this.Controls.Add(this.PassField);
            this.Controls.Add(this.NameLable);
            this.Controls.Add(this.NameField);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SignInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignInForm_FormClosing);
            this.Enter += new System.EventHandler(this.EnterBtn_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel SignUpLink;
        private System.Windows.Forms.Button EnterBtn;
        private System.Windows.Forms.Label PassLable;
        private System.Windows.Forms.TextBox PassField;
        private System.Windows.Forms.Label NameLable;
        public System.Windows.Forms.TextBox NameField;
    }
}

