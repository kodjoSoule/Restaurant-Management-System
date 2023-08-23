namespace Projet_RMS_Final.View.Restauranteur
{
    partial class HomeRestauranteur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeRestauranteur));
            panel2 = new Panel();
            menuStrip1 = new MenuStrip();
            fichierToolStripMenuItem = new ToolStripMenuItem();
            accueilToolStripMenuItem = new ToolStripMenuItem();
            deconnecterToolStripMenuItem = new ToolStripMenuItem();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            produitsToolStripMenuItem = new ToolStripMenuItem();
            listeDesProduitsToolStripMenuItem = new ToolStripMenuItem();
            aProposToolStripMenuItem = new ToolStripMenuItem();
            listeDesCommandeToolStripMenuItem = new ToolStripMenuItem();
            listeDesCommandesToolStripMenuItem = new ToolStripMenuItem();
            paiementsToolStripMenuItem = new ToolStripMenuItem();
            listeDesPaiementsToolStripMenuItem = new ToolStripMenuItem();
            recetteToolStripMenuItem = new ToolStripMenuItem();
            listeDesRecettesToolStripMenuItem = new ToolStripMenuItem();
            aProposToolStripMenuItem1 = new ToolStripMenuItem();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            labelUtilisateur = new Label();
            label3 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            labelUser = new Label();
            label1 = new Label();
            button5 = new Button();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(button5);
            panel2.Controls.Add(menuStrip1);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(labelUtilisateur);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1428, 694);
            panel2.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fichierToolStripMenuItem, produitsToolStripMenuItem, aProposToolStripMenuItem, paiementsToolStripMenuItem, recetteToolStripMenuItem, aProposToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1428, 33);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // fichierToolStripMenuItem
            // 
            fichierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { accueilToolStripMenuItem, deconnecterToolStripMenuItem, quitterToolStripMenuItem });
            fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            fichierToolStripMenuItem.Size = new Size(78, 29);
            fichierToolStripMenuItem.Text = "Fichier";
            // 
            // accueilToolStripMenuItem
            // 
            accueilToolStripMenuItem.Name = "accueilToolStripMenuItem";
            accueilToolStripMenuItem.Size = new Size(213, 34);
            accueilToolStripMenuItem.Text = "Accueil";
            accueilToolStripMenuItem.Click += accueilToolStripMenuItem_Click;
            // 
            // deconnecterToolStripMenuItem
            // 
            deconnecterToolStripMenuItem.Name = "deconnecterToolStripMenuItem";
            deconnecterToolStripMenuItem.Size = new Size(213, 34);
            deconnecterToolStripMenuItem.Text = "Deconnecter";
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(213, 34);
            quitterToolStripMenuItem.Text = "Quitter";
            // 
            // produitsToolStripMenuItem
            // 
            produitsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listeDesProduitsToolStripMenuItem });
            produitsToolStripMenuItem.Name = "produitsToolStripMenuItem";
            produitsToolStripMenuItem.Size = new Size(94, 29);
            produitsToolStripMenuItem.Text = "Produits";
            // 
            // listeDesProduitsToolStripMenuItem
            // 
            listeDesProduitsToolStripMenuItem.Name = "listeDesProduitsToolStripMenuItem";
            listeDesProduitsToolStripMenuItem.Size = new Size(253, 34);
            listeDesProduitsToolStripMenuItem.Text = "Liste des Produits";
            // 
            // aProposToolStripMenuItem
            // 
            aProposToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listeDesCommandeToolStripMenuItem, listeDesCommandesToolStripMenuItem });
            aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            aProposToolStripMenuItem.Size = new Size(121, 29);
            aProposToolStripMenuItem.Text = "Commande";
            aProposToolStripMenuItem.Click += aProposToolStripMenuItem_Click;
            // 
            // listeDesCommandeToolStripMenuItem
            // 
            listeDesCommandeToolStripMenuItem.Name = "listeDesCommandeToolStripMenuItem";
            listeDesCommandeToolStripMenuItem.Size = new Size(296, 34);
            listeDesCommandeToolStripMenuItem.Text = "Commande un produit";
            // 
            // listeDesCommandesToolStripMenuItem
            // 
            listeDesCommandesToolStripMenuItem.Name = "listeDesCommandesToolStripMenuItem";
            listeDesCommandesToolStripMenuItem.Size = new Size(296, 34);
            listeDesCommandesToolStripMenuItem.Text = "Liste des Commandes";
            // 
            // paiementsToolStripMenuItem
            // 
            paiementsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listeDesPaiementsToolStripMenuItem });
            paiementsToolStripMenuItem.Name = "paiementsToolStripMenuItem";
            paiementsToolStripMenuItem.Size = new Size(108, 29);
            paiementsToolStripMenuItem.Text = "Paiements";
            // 
            // listeDesPaiementsToolStripMenuItem
            // 
            listeDesPaiementsToolStripMenuItem.Name = "listeDesPaiementsToolStripMenuItem";
            listeDesPaiementsToolStripMenuItem.Size = new Size(269, 34);
            listeDesPaiementsToolStripMenuItem.Text = "Liste des paiements";
            // 
            // recetteToolStripMenuItem
            // 
            recetteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listeDesRecettesToolStripMenuItem });
            recetteToolStripMenuItem.Name = "recetteToolStripMenuItem";
            recetteToolStripMenuItem.Size = new Size(85, 29);
            recetteToolStripMenuItem.Text = "Recette";
            // 
            // listeDesRecettesToolStripMenuItem
            // 
            listeDesRecettesToolStripMenuItem.Name = "listeDesRecettesToolStripMenuItem";
            listeDesRecettesToolStripMenuItem.Size = new Size(248, 34);
            listeDesRecettesToolStripMenuItem.Text = "Liste des recettes";
            // 
            // aProposToolStripMenuItem1
            // 
            aProposToolStripMenuItem1.Name = "aProposToolStripMenuItem1";
            aProposToolStripMenuItem1.Size = new Size(103, 29);
            aProposToolStripMenuItem1.Text = "A propos";
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
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Green;
            button2.Location = new Point(35, 338);
            button2.Name = "button2";
            button2.Padding = new Padding(10);
            button2.Size = new Size(460, 81);
            button2.TabIndex = 2;
            button2.Text = "Liste des Produits dispnibles";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // labelUtilisateur
            // 
            labelUtilisateur.AutoSize = true;
            labelUtilisateur.BackColor = Color.Transparent;
            labelUtilisateur.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelUtilisateur.Location = new Point(382, 103);
            labelUtilisateur.Name = "labelUtilisateur";
            labelUtilisateur.Size = new Size(317, 65);
            labelUtilisateur.TabIndex = 1;
            labelUtilisateur.Text = "Restaurateur";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(105, 70, 221);
            label3.Location = new Point(90, 103);
            label3.Name = "label3";
            label3.Size = new Size(264, 65);
            label3.TabIndex = 0;
            label3.Text = "Bienvenue";
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
            panel1.TabIndex = 2;
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
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.Cursor = Cursors.Hand;
            button5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.Orange;
            button5.Location = new Point(527, 338);
            button5.Name = "button5";
            button5.Padding = new Padding(10);
            button5.Size = new Size(460, 81);
            button5.TabIndex = 9;
            button5.Text = "Liste des Commandes";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // HomeRestauranteur
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1428, 694);
            Controls.Add(panel1);
            Name = "HomeRestauranteur";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomeRestauranteur";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel2;
        private Label label4;
        private Button button3;
        private Button button4;
        private Button buttonList;
        private Button button2;
        private Label labelUtilisateur;
        private Label label3;
        private Panel panel1;
        private Button button1;
        private Label labelUser;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem deconnecterToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem produitsToolStripMenuItem;
        private ToolStripMenuItem accueilToolStripMenuItem;
        private ToolStripMenuItem ajouterUnProduitToolStripMenuItem;
        private ToolStripMenuItem categorieProduitToolStripMenuItem;
        private ToolStripMenuItem listeDesProduitsToolStripMenuItem;
        private ToolStripMenuItem aProposToolStripMenuItem;
        private ToolStripMenuItem listeDesCommandeToolStripMenuItem;
        private ToolStripMenuItem listeDesCommandesToolStripMenuItem;
        private ToolStripMenuItem paiementsToolStripMenuItem;
        private ToolStripMenuItem listeDesPaiementsToolStripMenuItem;
        private ToolStripMenuItem recetteToolStripMenuItem;
        private ToolStripMenuItem listeDesRecettesToolStripMenuItem;
        private ToolStripMenuItem aProposToolStripMenuItem1;
        private Button button5;
    }
}