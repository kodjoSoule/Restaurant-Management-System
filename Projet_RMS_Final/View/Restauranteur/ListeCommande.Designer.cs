namespace Projet_RMS_Final.View.Restauranteur
{
    partial class ListeCommande
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeCommande));
            dataGridView = new DataGridView();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            button2 = new Button();
            textBoxSearch = new TextBox();
            label5 = new Label();
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
            buttonSupprimerCommande = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = Color.White;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(69, 173);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.RowTemplate.Height = 33;
            dataGridView.Size = new Size(1306, 434);
            dataGridView.TabIndex = 19;
            dataGridView.CellContentClick += dataGridViewUsers_CellContentClick;
            // 
            // iconButton1
            // 
            iconButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.HandPointLeft;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 40;
            iconButton1.Location = new Point(28, 99);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(150, 45);
            iconButton1.TabIndex = 24;
            iconButton1.Text = "Accueil";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(820, 626);
            button2.Name = "button2";
            button2.Size = new Size(146, 56);
            button2.TabIndex = 20;
            button2.Text = "Payer";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(440, 108);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(772, 31);
            textBoxSearch.TabIndex = 22;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(280, 108);
            label5.Name = "label5";
            label5.Size = new Size(110, 28);
            label5.TabIndex = 23;
            label5.Text = "Recherche";
            label5.Click += label5_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fichierToolStripMenuItem, produitsToolStripMenuItem, aProposToolStripMenuItem, paiementsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1428, 33);
            menuStrip1.TabIndex = 52;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // fichierToolStripMenuItem
            // 
            fichierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { accueilToolStripMenuItem, deconnecterToolStripMenuItem, quitterToolStripMenuItem });
            fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            fichierToolStripMenuItem.Size = new Size(78, 29);
            fichierToolStripMenuItem.Text = "Fichier";
            fichierToolStripMenuItem.Click += fichierToolStripMenuItem_Click;
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
            deconnecterToolStripMenuItem.Click += deconnecterToolStripMenuItem_Click;
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(213, 34);
            quitterToolStripMenuItem.Text = "Quitter";
            quitterToolStripMenuItem.Click += quitterToolStripMenuItem_Click;
            // 
            // produitsToolStripMenuItem
            // 
            produitsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listeDesProduitsToolStripMenuItem });
            produitsToolStripMenuItem.Name = "produitsToolStripMenuItem";
            produitsToolStripMenuItem.Size = new Size(94, 29);
            produitsToolStripMenuItem.Text = "Produits";
            produitsToolStripMenuItem.Click += produitsToolStripMenuItem_Click;
            // 
            // listeDesProduitsToolStripMenuItem
            // 
            listeDesProduitsToolStripMenuItem.Name = "listeDesProduitsToolStripMenuItem";
            listeDesProduitsToolStripMenuItem.Size = new Size(253, 34);
            listeDesProduitsToolStripMenuItem.Text = "Liste des Produits";
            listeDesProduitsToolStripMenuItem.Click += listeDesProduitsToolStripMenuItem_Click;
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
            listeDesCommandeToolStripMenuItem.Click += listeDesCommandeToolStripMenuItem_Click;
            // 
            // listeDesCommandesToolStripMenuItem
            // 
            listeDesCommandesToolStripMenuItem.Name = "listeDesCommandesToolStripMenuItem";
            listeDesCommandesToolStripMenuItem.Size = new Size(296, 34);
            listeDesCommandesToolStripMenuItem.Text = "Liste des Commandes";
            listeDesCommandesToolStripMenuItem.Click += listeDesCommandesToolStripMenuItem_Click;
            // 
            // paiementsToolStripMenuItem
            // 
            paiementsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listeDesPaiementsToolStripMenuItem });
            paiementsToolStripMenuItem.Name = "paiementsToolStripMenuItem";
            paiementsToolStripMenuItem.Size = new Size(85, 29);
            paiementsToolStripMenuItem.Text = "Recette";
            paiementsToolStripMenuItem.Click += paiementsToolStripMenuItem_Click;
            // 
            // listeDesPaiementsToolStripMenuItem
            // 
            listeDesPaiementsToolStripMenuItem.Name = "listeDesPaiementsToolStripMenuItem";
            listeDesPaiementsToolStripMenuItem.Size = new Size(269, 34);
            listeDesPaiementsToolStripMenuItem.Text = "Liste des paiements";
            listeDesPaiementsToolStripMenuItem.Click += listeDesPaiementsToolStripMenuItem_Click;
            // 
            // buttonSupprimerCommande
            // 
            buttonSupprimerCommande.BackColor = Color.Red;
            buttonSupprimerCommande.Cursor = Cursors.Hand;
            buttonSupprimerCommande.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSupprimerCommande.ForeColor = Color.White;
            buttonSupprimerCommande.Location = new Point(1019, 626);
            buttonSupprimerCommande.Name = "buttonSupprimerCommande";
            buttonSupprimerCommande.Size = new Size(154, 56);
            buttonSupprimerCommande.TabIndex = 53;
            buttonSupprimerCommande.Text = "Supprimer";
            buttonSupprimerCommande.UseVisualStyleBackColor = false;
            buttonSupprimerCommande.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(419, 33);
            label1.Name = "label1";
            label1.Size = new Size(431, 54);
            label1.TabIndex = 57;
            label1.Text = "Liste des Commandes";
            // 
            // ListeCommande
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1428, 694);
            Controls.Add(label1);
            Controls.Add(buttonSupprimerCommande);
            Controls.Add(menuStrip1);
            Controls.Add(iconButton1);
            Controls.Add(label5);
            Controls.Add(textBoxSearch);
            Controls.Add(button2);
            Controls.Add(dataGridView);
            Name = "ListeCommande";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListeCommande";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Button button2;
        private TextBox textBoxSearch;
        private Label label5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem accueilToolStripMenuItem;
        private ToolStripMenuItem deconnecterToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem produitsToolStripMenuItem;
        private ToolStripMenuItem listeDesProduitsToolStripMenuItem;
        private ToolStripMenuItem aProposToolStripMenuItem;
        private ToolStripMenuItem listeDesCommandeToolStripMenuItem;
        private ToolStripMenuItem listeDesCommandesToolStripMenuItem;
        private ToolStripMenuItem paiementsToolStripMenuItem;
        private ToolStripMenuItem listeDesPaiementsToolStripMenuItem;
        private Button buttonSupprimerCommande;
        private Label label1;
    }
}