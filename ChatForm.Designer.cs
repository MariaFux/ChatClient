namespace Chat
{
    partial class ChatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SendBtn = new System.Windows.Forms.Button();
            this.ExitAccBtn = new System.Windows.Forms.Button();
            this.EntryField = new System.Windows.Forms.RichTextBox();
            this.DisplayField = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.LightCoral;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExitBtn.Location = new System.Drawing.Point(548, 14);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(121, 27);
            this.ExitBtn.TabIndex = 7;
            this.ExitBtn.Text = "Выйти";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // SendBtn
            // 
            this.SendBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendBtn.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendBtn.Location = new System.Drawing.Point(439, 319);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(88, 27);
            this.SendBtn.TabIndex = 6;
            this.SendBtn.Text = "Отправить";
            this.SendBtn.UseVisualStyleBackColor = false;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // ExitAccBtn
            // 
            this.ExitAccBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ExitAccBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitAccBtn.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitAccBtn.Location = new System.Drawing.Point(548, 47);
            this.ExitAccBtn.Name = "ExitAccBtn";
            this.ExitAccBtn.Size = new System.Drawing.Size(121, 38);
            this.ExitAccBtn.TabIndex = 8;
            this.ExitAccBtn.Text = "Выйти из учетной записи";
            this.ExitAccBtn.UseVisualStyleBackColor = false;
            this.ExitAccBtn.Click += new System.EventHandler(this.ExitAccBtn_Click);
            // 
            // EntryField
            // 
            this.EntryField.BackColor = System.Drawing.SystemColors.Desktop;
            this.EntryField.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EntryField.ForeColor = System.Drawing.Color.Black;
            this.EntryField.Location = new System.Drawing.Point(15, 321);
            this.EntryField.Name = "EntryField";
            this.EntryField.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.EntryField.Size = new System.Drawing.Size(418, 25);
            this.EntryField.TabIndex = 9;
            this.EntryField.Text = "";
            this.EntryField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EntryField_KeyDown);
            this.EntryField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EntryField_KeyPress);
            // 
            // DisplayField
            // 
            this.DisplayField.BackColor = System.Drawing.SystemColors.Control;
            this.DisplayField.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DisplayField.Location = new System.Drawing.Point(15, 14);
            this.DisplayField.Name = "DisplayField";
            this.DisplayField.ReadOnly = true;
            this.DisplayField.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.DisplayField.Size = new System.Drawing.Size(512, 299);
            this.DisplayField.TabIndex = 10;
            this.DisplayField.TabStop = false;
            this.DisplayField.Text = "";
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(688, 382);
            this.Controls.Add(this.DisplayField);
            this.Controls.Add(this.EntryField);
            this.Controls.Add(this.ExitAccBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.SendBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Чат";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChatForm_FormClosed);
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.Button ExitAccBtn;
        private System.Windows.Forms.RichTextBox EntryField;
        public System.Windows.Forms.RichTextBox DisplayField;
    }
}