namespace Curatatorie
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblAutentificare = new Label();
            guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            gn2BtnAutentif = new Guna.UI2.WinForms.Guna2Button();
            gn2TextBoxParola = new Guna.UI2.WinForms.Guna2TextBox();
            gn2TextBoxNumeUtilizat = new Guna.UI2.WinForms.Guna2TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            guna2GroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(5, 84, 161);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(454, 568);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.patru;
            pictureBox1.Location = new Point(102, 182);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(235, 204);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblAutentificare
            // 
            lblAutentificare.AutoSize = true;
            lblAutentificare.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAutentificare.ForeColor = Color.Black;
            lblAutentificare.Location = new Point(98, 76);
            lblAutentificare.Name = "lblAutentificare";
            lblAutentificare.Size = new Size(159, 27);
            lblAutentificare.TabIndex = 1;
            lblAutentificare.Text = "Autentificare";
            lblAutentificare.Click += label1_Click;
            // 
            // guna2GroupBox1
            // 
            guna2GroupBox1.BorderColor = Color.Black;
            guna2GroupBox1.Controls.Add(gn2BtnAutentif);
            guna2GroupBox1.Controls.Add(gn2TextBoxParola);
            guna2GroupBox1.Controls.Add(gn2TextBoxNumeUtilizat);
            guna2GroupBox1.Controls.Add(lblAutentificare);
            guna2GroupBox1.CustomBorderColor = Color.Transparent;
            guna2GroupBox1.CustomizableEdges = customizableEdges7;
            guna2GroupBox1.FillColor = Color.Transparent;
            guna2GroupBox1.Font = new Font("Segoe UI", 9F);
            guna2GroupBox1.ForeColor = Color.FromArgb(125, 137, 149);
            guna2GroupBox1.Location = new Point(552, 51);
            guna2GroupBox1.Name = "guna2GroupBox1";
            guna2GroupBox1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2GroupBox1.Size = new Size(359, 450);
            guna2GroupBox1.TabIndex = 2;
            // 
            // gn2BtnAutentif
            // 
            gn2BtnAutentif.BorderRadius = 15;
            gn2BtnAutentif.CustomizableEdges = customizableEdges1;
            gn2BtnAutentif.DisabledState.BorderColor = Color.DarkGray;
            gn2BtnAutentif.DisabledState.CustomBorderColor = Color.DarkGray;
            gn2BtnAutentif.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            gn2BtnAutentif.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            gn2BtnAutentif.Font = new Font("Segoe UI", 9F);
            gn2BtnAutentif.ForeColor = Color.White;
            gn2BtnAutentif.Location = new Point(38, 243);
            gn2BtnAutentif.Name = "gn2BtnAutentif";
            gn2BtnAutentif.ShadowDecoration.CustomizableEdges = customizableEdges2;
            gn2BtnAutentif.Size = new Size(286, 40);
            gn2BtnAutentif.TabIndex = 4;
            gn2BtnAutentif.Text = "Autentifica";
            // 
            // gn2TextBoxParola
            // 
            gn2TextBoxParola.BorderRadius = 20;
            gn2TextBoxParola.CustomizableEdges = customizableEdges3;
            gn2TextBoxParola.DefaultText = "";
            gn2TextBoxParola.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            gn2TextBoxParola.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            gn2TextBoxParola.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            gn2TextBoxParola.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            gn2TextBoxParola.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            gn2TextBoxParola.Font = new Font("Segoe UI", 9F);
            gn2TextBoxParola.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            gn2TextBoxParola.Location = new Point(38, 188);
            gn2TextBoxParola.Margin = new Padding(3, 4, 3, 4);
            gn2TextBoxParola.Name = "gn2TextBoxParola";
            gn2TextBoxParola.PasswordChar = '\0';
            gn2TextBoxParola.PlaceholderText = "Parola";
            gn2TextBoxParola.SelectedText = "";
            gn2TextBoxParola.ShadowDecoration.CustomizableEdges = customizableEdges4;
            gn2TextBoxParola.Size = new Size(286, 39);
            gn2TextBoxParola.TabIndex = 3;
            // 
            // gn2TextBoxNumeUtilizat
            // 
            gn2TextBoxNumeUtilizat.BorderRadius = 20;
            gn2TextBoxNumeUtilizat.CustomizableEdges = customizableEdges5;
            gn2TextBoxNumeUtilizat.DefaultText = "";
            gn2TextBoxNumeUtilizat.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            gn2TextBoxNumeUtilizat.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            gn2TextBoxNumeUtilizat.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            gn2TextBoxNumeUtilizat.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            gn2TextBoxNumeUtilizat.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            gn2TextBoxNumeUtilizat.Font = new Font("Segoe UI", 9F);
            gn2TextBoxNumeUtilizat.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            gn2TextBoxNumeUtilizat.Location = new Point(38, 141);
            gn2TextBoxNumeUtilizat.Margin = new Padding(3, 4, 3, 4);
            gn2TextBoxNumeUtilizat.Name = "gn2TextBoxNumeUtilizat";
            gn2TextBoxNumeUtilizat.PasswordChar = '\0';
            gn2TextBoxNumeUtilizat.PlaceholderText = "Nume de utilizator";
            gn2TextBoxNumeUtilizat.SelectedText = "";
            gn2TextBoxNumeUtilizat.ShadowDecoration.CustomizableEdges = customizableEdges6;
            gn2TextBoxNumeUtilizat.Size = new Size(286, 39);
            gn2TextBoxNumeUtilizat.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 561);
            Controls.Add(guna2GroupBox1);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            Resize += Form1_Resize;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            guna2GroupBox1.ResumeLayout(false);
            guna2GroupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblAutentificare;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2TextBox gn2TextBoxParola;
        private Guna.UI2.WinForms.Guna2TextBox gn2TextBoxNumeUtilizat;
        private Guna.UI2.WinForms.Guna2Button gn2BtnAutentif;
        private Label label1;
        private Label label3;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
    }
}
