namespace Projet_RMS_Final.Authentification
{
    partial class AuthentificationUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthentificationUI));
            splitContainer1 = new SplitContainer();
            pictureBox1 = new PictureBox();
            buttonQuitter = new Button();
            textBoxPassword = new TextBox();
            textBoxLogin = new TextBox();
            label3 = new Label();
            label2 = new Label();
            buttonConnecter = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(247, 245, 250);
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.FromArgb(105, 70, 221);
            splitContainer1.Panel2.Controls.Add(buttonQuitter);
            splitContainer1.Panel2.Controls.Add(textBoxPassword);
            splitContainer1.Panel2.Controls.Add(textBoxLogin);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(buttonConnecter);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1428, 694);
            splitContainer1.SplitterDistance = 753;
            splitContainer1.SplitterWidth = 1;
            splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(753, 694);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // buttonQuitter
            // 
            buttonQuitter.BackColor = Color.Red;
            buttonQuitter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonQuitter.ForeColor = Color.White;
            buttonQuitter.Location = new Point(400, 539);
            buttonQuitter.Name = "buttonQuitter";
            buttonQuitter.Size = new Size(214, 65);
            buttonQuitter.TabIndex = 6;
            buttonQuitter.Text = "Quitter";
            buttonQuitter.UseVisualStyleBackColor = false;
            buttonQuitter.Click += buttonQuitter_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(135, 382);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(499, 39);
            textBoxPassword.TabIndex = 5;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(135, 261);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(499, 39);
            textBoxLogin.TabIndex = 4;
            textBoxLogin.TextChanged += textBoxLogin_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(129, 337);
            label3.Name = "label3";
            label3.Size = new Size(166, 32);
            label3.TabIndex = 3;
            label3.Text = "Mot de passe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(128, 210);
            label2.Name = "label2";
            label2.Size = new Size(195, 32);
            label2.TabIndex = 2;
            label2.Text = "Nom Utilisateur";
            // 
            // buttonConnecter
            // 
            buttonConnecter.BackColor = Color.White;
            buttonConnecter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonConnecter.ForeColor = Color.FromArgb(105, 70, 221);
            buttonConnecter.Location = new Point(135, 539);
            buttonConnecter.Name = "buttonConnecter";
            buttonConnecter.Size = new Size(214, 65);
            buttonConnecter.TabIndex = 1;
            buttonConnecter.Text = "Se connecter";
            buttonConnecter.UseVisualStyleBackColor = false;
            buttonConnecter.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(218, 87);
            label1.Name = "label1";
            label1.Size = new Size(270, 65);
            label1.TabIndex = 0;
            label1.Text = "Connexion";
            label1.Click += label1_Click;
            // 
            // AuthentificationUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1428, 694);
            Controls.Add(splitContainer1);
            HelpButton = true;
            Name = "AuthentificationUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += AuthentificationUI_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button buttonConnecter;
        private TextBox textBoxPassword;
        private TextBox textBoxLogin;
        private Label label3;
        private Label label2;
        private Button buttonQuitter;
    }
}