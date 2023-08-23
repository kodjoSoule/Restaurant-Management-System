namespace Projet_RMS_Final.View.Restauranteur
{
    partial class ListeProduitRestauranteur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeProduitRestauranteur));
            labelCategorie = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label5 = new Label();
            textBoxSearch = new TextBox();
            buttonSupprimer = new Button();
            dataGridView = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // labelCategorie
            // 
            labelCategorie.AutoSize = true;
            labelCategorie.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelCategorie.Location = new Point(1121, 512);
            labelCategorie.Name = "labelCategorie";
            labelCategorie.Size = new Size(0, 32);
            labelCategorie.TabIndex = 53;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1193, 178);
            label1.Name = "label1";
            label1.Size = new Size(80, 32);
            label1.TabIndex = 50;
            label1.Text = "Image";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1121, 230);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 255);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            // 
            // iconButton1
            // 
            iconButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.HandPointLeft;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 40;
            iconButton1.Location = new Point(54, 109);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(160, 46);
            iconButton1.TabIndex = 48;
            iconButton1.Text = "Accueil";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(261, 123);
            label5.Name = "label5";
            label5.Size = new Size(130, 32);
            label5.TabIndex = 47;
            label5.Text = "Recherche";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(449, 124);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(566, 31);
            textBoxSearch.TabIndex = 46;
            // 
            // buttonSupprimer
            // 
            buttonSupprimer.BackColor = Color.Gray;
            buttonSupprimer.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSupprimer.ForeColor = Color.White;
            buttonSupprimer.Location = new Point(1170, 533);
            buttonSupprimer.Name = "buttonSupprimer";
            buttonSupprimer.Size = new Size(147, 56);
            buttonSupprimer.TabIndex = 45;
            buttonSupprimer.Text = "Commander";
            buttonSupprimer.UseVisualStyleBackColor = false;
            buttonSupprimer.Click += buttonSupprimer_Click;
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = Color.White;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(65, 178);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.RowTemplate.Height = 33;
            dataGridView.Size = new Size(1040, 411);
            dataGridView.TabIndex = 43;
            dataGridView.CellClick += dataGridView_CellClick;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fichierToolStripMenuItem, produitsToolStripMenuItem, aProposToolStripMenuItem, paiementsToolStripMenuItem, recetteToolStripMenuItem, aProposToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1428, 33);
            menuStrip1.TabIndex = 54;
            menuStrip1.Text = "menuStrip1";
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
            accueilToolStripMenuItem.Size = new Size(270, 34);
            accueilToolStripMenuItem.Text = "Accueil";
            // 
            // deconnecterToolStripMenuItem
            // 
            deconnecterToolStripMenuItem.Name = "deconnecterToolStripMenuItem";
            deconnecterToolStripMenuItem.Size = new Size(270, 34);
            deconnecterToolStripMenuItem.Text = "Deconnecter";
            deconnecterToolStripMenuItem.Click += deconnecterToolStripMenuItem_Click;
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(270, 34);
            quitterToolStripMenuItem.Text = "Quitter";
            quitterToolStripMenuItem.Click += quitterToolStripMenuItem_Click;
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
            // ListeProduitRestauranteur
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1428, 694);
            Controls.Add(menuStrip1);
            Controls.Add(labelCategorie);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(iconButton1);
            Controls.Add(label5);
            Controls.Add(textBoxSearch);
            Controls.Add(buttonSupprimer);
            Controls.Add(dataGridView);
            Name = "ListeProduitRestauranteur";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListeProduitRestauranteur";
            Load += ListeProduitRestauranteur_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCategorie;
        private ToolStripMenuItem aProposToolStripMenuItem;
        private ToolStripMenuItem aProposToolStripMenuItem1;
        private ToolStripMenuItem listeDesProduitsToolStripMenuItem;
        private ToolStripMenuItem categorieProduitToolStripMenuItem;
        private ToolStripMenuItem ajouterUnProduitToolStripMenuItem;
        private ToolStripMenuItem produitsToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem deconnecterToolStripMenuItem;
        private ToolStripMenuItem accueilToolStripMenuItem;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private MenuStrip menuStrip1;
        private Label label1;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label5;
        private TextBox textBoxSearch;
        private Button buttonSupprimer;
        private DataGridView dataGridView;
        private ToolStripMenuItem listeDesCommandeToolStripMenuItem;
        private ToolStripMenuItem listeDesCommandesToolStripMenuItem;
        private ToolStripMenuItem paiementsToolStripMenuItem;
        private ToolStripMenuItem listeDesPaiementsToolStripMenuItem;
        private ToolStripMenuItem recetteToolStripMenuItem;
        private ToolStripMenuItem listeDesRecettesToolStripMenuItem;
    }
}