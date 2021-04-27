namespace Projet
{
    partial class Login
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Title = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.pwdtxt = new System.Windows.Forms.TextBox();
            this.ShowHide = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BUser = new System.Windows.Forms.Button();
            this.Bexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Red;
            this.Title.Location = new System.Drawing.Point(23, 62);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(369, 26);
            this.Title.TabIndex = 0;
            this.Title.Text = "Gestion de Stock and Commande";
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(23, 144);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(123, 25);
            this.Username.TabIndex = 2;
            this.Username.Text = "Username :";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(23, 196);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(119, 25);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password :";
            // 
            // usertxt
            // 
            this.usertxt.Location = new System.Drawing.Point(178, 138);
            this.usertxt.Multiline = true;
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(207, 31);
            this.usertxt.TabIndex = 4;
            // 
            // pwdtxt
            // 
            this.pwdtxt.Location = new System.Drawing.Point(178, 196);
            this.pwdtxt.Multiline = true;
            this.pwdtxt.Name = "pwdtxt";
            this.pwdtxt.PasswordChar = '*';
            this.pwdtxt.Size = new System.Drawing.Size(207, 31);
            this.pwdtxt.TabIndex = 5;
            // 
            // ShowHide
            // 
            this.ShowHide.AutoSize = true;
            this.ShowHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowHide.Location = new System.Drawing.Point(178, 233);
            this.ShowHide.Name = "ShowHide";
            this.ShowHide.Size = new System.Drawing.Size(204, 24);
            this.ShowHide.TabIndex = 6;
            this.ShowHide.Text = "Show Your Password";
            this.ShowHide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ShowHide.UseVisualStyleBackColor = true;
            this.ShowHide.CheckedChanged += new System.EventHandler(this.ShowHide_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(94, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BUser
            // 
            this.BUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUser.ForeColor = System.Drawing.Color.Red;
            this.BUser.Location = new System.Drawing.Point(28, 353);
            this.BUser.Name = "BUser";
            this.BUser.Size = new System.Drawing.Size(357, 49);
            this.BUser.TabIndex = 10;
            this.BUser.Text = "Continuer au tant que Client ";
            this.BUser.UseVisualStyleBackColor = false;
            this.BUser.Click += new System.EventHandler(this.BUser_Click);
            // 
            // Bexit
            // 
            this.Bexit.FlatAppearance.BorderSize = 0;
            this.Bexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bexit.Image = ((System.Drawing.Image)(resources.GetObject("Bexit.Image")));
            this.Bexit.Location = new System.Drawing.Point(360, 2);
            this.Bexit.Name = "Bexit";
            this.Bexit.Size = new System.Drawing.Size(54, 57);
            this.Bexit.TabIndex = 11;
            this.Bexit.UseVisualStyleBackColor = true;
            this.Bexit.Click += new System.EventHandler(this.Bexit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(426, 495);
            this.Controls.Add(this.Bexit);
            this.Controls.Add(this.BUser);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ShowHide);
            this.Controls.Add(this.pwdtxt);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Title);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.TextBox pwdtxt;
        private System.Windows.Forms.CheckBox ShowHide;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BUser;
        private System.Windows.Forms.Button Bexit;
    }
}

