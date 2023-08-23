namespace Projet_RMS_Final.View.Administrateur
{
    partial class HomeAdministrateur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeAdministrateur));
            panel1 = new Panel();
            panel2 = new Panel();
            label4 = new Label();
            button3 = new Button();
            button4 = new Button();
            buttonList = new Button();
            button2 = new Button();
            labelUtilisateur = new Label();
            label3 = new Label();
            button1 = new Button();
            labelUser = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(labelUser);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1428, 694);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(buttonList);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(labelUtilisateur);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1428, 694);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(664, 385);
            label4.Name = "label4";
            label4.Padding = new Padding(10);
            label4.Size = new Size(246, 52);
            label4.TabIndex = 6;
            label4.Text = "Gestion Utilisateur";
            label4.Click += label4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Gray;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(35, 549);
            button3.Name = "button3";
            button3.Padding = new Padding(10);
            button3.Size = new Size(196, 67);
            button3.TabIndex = 5;
            button3.Text = "Deconnexion";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(280, 549);
            button4.Name = "button4";
            button4.Padding = new Padding(10);
            button4.Size = new Size(196, 67);
            button4.TabIndex = 4;
            button4.Text = "Quitter";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // buttonList
            // 
            buttonList.BackColor = Color.Blue;
            buttonList.Cursor = Cursors.Hand;
            buttonList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonList.ForeColor = Color.White;
            buttonList.Location = new Point(914, 454);
            buttonList.Name = "buttonList";
            buttonList.Padding = new Padding(10);
            buttonList.Size = new Size(196, 67);
            buttonList.TabIndex = 3;
            buttonList.Text = "Liste";
            buttonList.UseVisualStyleBackColor = false;
            buttonList.Click += buttonList_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(254, 207, 71);
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(664, 454);
            button2.Name = "button2";
            button2.Padding = new Padding(10);
            button2.Size = new Size(196, 67);
            button2.TabIndex = 2;
            button2.Text = "Ajouter";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // labelUtilisateur
            // 
            labelUtilisateur.AutoSize = true;
            labelUtilisateur.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelUtilisateur.Location = new Point(939, 290);
            labelUtilisateur.Name = "labelUtilisateur";
            labelUtilisateur.Size = new Size(264, 65);
            labelUtilisateur.TabIndex = 1;
            labelUtilisateur.Text = "Utilisateur";
            labelUtilisateur.Click += labelUtilisateur_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(105, 70, 221);
            label3.Location = new Point(644, 290);
            label3.Name = "label3";
            label3.Size = new Size(264, 65);
            label3.TabIndex = 0;
            label3.Text = "Bienvenue";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(105, 70, 221);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(712, 454);
            button1.Name = "button1";
            button1.Padding = new Padding(10);
            button1.Size = new Size(196, 67);
            button1.TabIndex = 2;
            button1.Text = "Ajouter Utilisateur";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelUser.Location = new Point(1005, 306);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(264, 65);
            labelUser.TabIndex = 1;
            labelUser.Text = "Utilisateur";
            labelUser.Click += labelUser_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(105, 70, 221);
            label1.Location = new Point(703, 306);
            label1.Name = "label1";
            label1.Size = new Size(264, 65);
            label1.TabIndex = 0;
            label1.Text = "Bienvenue";
            label1.Click += label1_Click;
            // 
            // HomeAdministrateur
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1428, 694);
            Controls.Add(panel1);
            Name = "HomeAdministrateur";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomeAdministrateur";
            Load += HomeAdministrateur_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelUser;
        private Label label1;
        private Button button1;
        private Panel panel2;
        private Button button4;
        private Button buttonList;
        private Button button2;
        private Label labelUtilisateur;
        private Label label3;
        private Button button3;
        private Label label4;
    }
}