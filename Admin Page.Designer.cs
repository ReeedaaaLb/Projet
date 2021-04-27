namespace Projet
{
    partial class Admin_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Page));
            this.BAjouter = new System.Windows.Forms.Button();
            this.BModifier = new System.Windows.Forms.Button();
            this.BSupp = new System.Windows.Forms.Button();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.Bexit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.combocategorie = new System.Windows.Forms.ComboBox();
            this.Tprix = new System.Windows.Forms.TextBox();
            this.Tqnt = new System.Windows.Forms.TextBox();
            this.Tnomproduit = new System.Windows.Forms.TextBox();
            this.Tidproduit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BAjouter
            // 
            this.BAjouter.BackColor = System.Drawing.Color.LightCoral;
            this.BAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAjouter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BAjouter.Location = new System.Drawing.Point(160, 314);
            this.BAjouter.Name = "BAjouter";
            this.BAjouter.Size = new System.Drawing.Size(119, 42);
            this.BAjouter.TabIndex = 8;
            this.BAjouter.Text = "Ajouter";
            this.BAjouter.UseVisualStyleBackColor = false;
            this.BAjouter.Click += new System.EventHandler(this.BAjouter_Click);
            // 
            // BModifier
            // 
            this.BModifier.BackColor = System.Drawing.Color.LightCoral;
            this.BModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BModifier.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BModifier.Location = new System.Drawing.Point(302, 314);
            this.BModifier.Name = "BModifier";
            this.BModifier.Size = new System.Drawing.Size(119, 42);
            this.BModifier.TabIndex = 9;
            this.BModifier.Text = "Modifier";
            this.BModifier.UseVisualStyleBackColor = false;
            // 
            // BSupp
            // 
            this.BSupp.BackColor = System.Drawing.Color.LightCoral;
            this.BSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSupp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BSupp.Location = new System.Drawing.Point(441, 314);
            this.BSupp.Name = "BSupp";
            this.BSupp.Size = new System.Drawing.Size(119, 42);
            this.BSupp.TabIndex = 10;
            this.BSupp.Text = "Supprimer";
            this.BSupp.UseVisualStyleBackColor = false;
            this.BSupp.Click += new System.EventHandler(this.BSupp_Click);
            // 
            // Liste
            // 
            this.Liste.AllowUserToAddRows = false;
            this.Liste.AllowUserToDeleteRows = false;
            this.Liste.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Location = new System.Drawing.Point(160, 380);
            this.Liste.Name = "Liste";
            this.Liste.ReadOnly = true;
            this.Liste.RowTemplate.Height = 28;
            this.Liste.Size = new System.Drawing.Size(813, 272);
            this.Liste.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(433, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Gestion de Stock";
            // 
            // Bexit
            // 
            this.Bexit.FlatAppearance.BorderSize = 0;
            this.Bexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bexit.Image = ((System.Drawing.Image)(resources.GetObject("Bexit.Image")));
            this.Bexit.Location = new System.Drawing.Point(919, 12);
            this.Bexit.Name = "Bexit";
            this.Bexit.Size = new System.Drawing.Size(54, 57);
            this.Bexit.TabIndex = 15;
            this.Bexit.UseVisualStyleBackColor = true;
            this.Bexit.Click += new System.EventHandler(this.Bexit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.combocategorie);
            this.groupBox1.Controls.Add(this.Tprix);
            this.groupBox1.Controls.Add(this.Tqnt);
            this.groupBox1.Controls.Add(this.Tnomproduit);
            this.groupBox1.Controls.Add(this.Tidproduit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(160, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(813, 199);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info Produit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(277, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Categories";
            // 
            // combocategorie
            // 
            this.combocategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combocategorie.FormattingEnabled = true;
            this.combocategorie.Location = new System.Drawing.Point(397, 153);
            this.combocategorie.Name = "combocategorie";
            this.combocategorie.Size = new System.Drawing.Size(121, 28);
            this.combocategorie.TabIndex = 22;
            // 
            // Tprix
            // 
            this.Tprix.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tprix.Location = new System.Drawing.Point(569, 97);
            this.Tprix.Name = "Tprix";
            this.Tprix.Size = new System.Drawing.Size(121, 26);
            this.Tprix.TabIndex = 21;
            // 
            // Tqnt
            // 
            this.Tqnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tqnt.Location = new System.Drawing.Point(174, 100);
            this.Tqnt.Name = "Tqnt";
            this.Tqnt.Size = new System.Drawing.Size(121, 26);
            this.Tqnt.TabIndex = 20;
            // 
            // Tnomproduit
            // 
            this.Tnomproduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tnomproduit.Location = new System.Drawing.Point(569, 49);
            this.Tnomproduit.Name = "Tnomproduit";
            this.Tnomproduit.Size = new System.Drawing.Size(121, 26);
            this.Tnomproduit.TabIndex = 19;
            // 
            // Tidproduit
            // 
            this.Tidproduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tidproduit.Location = new System.Drawing.Point(174, 49);
            this.Tidproduit.Name = "Tidproduit";
            this.Tidproduit.Size = new System.Drawing.Size(121, 26);
            this.Tidproduit.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(437, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Prix :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Quantité :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(437, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nom Produit :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Id Produit :";
            // 
            // Admin_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1106, 664);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Bexit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.BSupp);
            this.Controls.Add(this.BModifier);
            this.Controls.Add(this.BAjouter);
            this.Name = "Admin_Page";
            this.Text = "Admin_Page";
            this.Load += new System.EventHandler(this.Admin_Page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BAjouter;
        private System.Windows.Forms.Button BModifier;
        private System.Windows.Forms.Button BSupp;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Bexit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combocategorie;
        private System.Windows.Forms.TextBox Tprix;
        private System.Windows.Forms.TextBox Tqnt;
        private System.Windows.Forms.TextBox Tnomproduit;
        private System.Windows.Forms.TextBox Tidproduit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}