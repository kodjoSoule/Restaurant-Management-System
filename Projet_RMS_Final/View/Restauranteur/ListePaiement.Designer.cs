namespace Projet_RMS_Final.View.Restauranteur
{
    partial class ListePaiement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListePaiement));
            paiementsToolStripMenuItem = new ToolStripMenuItem();
            listeDesPaiementsToolStripMenuItem = new ToolStripMenuItem();
            listeDesCommandesToolStripMenuItem = new ToolStripMenuItem();
            listeDesCommandeToolStripMenuItem = new ToolStripMenuItem();
            aProposToolStripMenuItem = new ToolStripMenuItem();
            listeDesProduitsToolStripMenuItem = new ToolStripMenuItem();
            produitsToolStripMenuItem = new ToolStripMenuItem();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            deconnecterToolStripMenuItem = new ToolStripMenuItem();
            accueilToolStripMenuItem = new ToolStripMenuItem();
            fichierToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            dataGridView = new DataGridView();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            labelTotal = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // paiementsToolStripMenuItem
            // 
            paiementsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listeDesPaiementsToolStripMenuItem });
            paiementsToolStripMenuItem.Name = "paiementsToolStripMenuItem";
            paiementsToolStripMenuItem.Size = new Size(85, 29);
            paiementsToolStripMenuItem.Text = "Recette";
            // 
            // listeDesPaiementsToolStripMenuItem
            // 
            listeDesPaiementsToolStripMenuItem.Name = "listeDesPaiementsToolStripMenuItem";
            listeDesPaiementsToolStripMenuItem.Size = new Size(269, 34);
            listeDesPaiementsToolStripMenuItem.Text = "Liste des paiements";
            listeDesPaiementsToolStripMenuItem.Click += listeDesPaiementsToolStripMenuItem_Click;
            // 
            // listeDesCommandesToolStripMenuItem
            // 
            listeDesCommandesToolStripMenuItem.Name = "listeDesCommandesToolStripMenuItem";
            listeDesCommandesToolStripMenuItem.Size = new Size(296, 34);
            listeDesCommandesToolStripMenuItem.Text = "Liste des Commandes";
            listeDesCommandesToolStripMenuItem.Click += listeDesCommandesToolStripMenuItem_Click;
            // 
            // listeDesCommandeToolStripMenuItem
            // 
            listeDesCommandeToolStripMenuItem.Name = "listeDesCommandeToolStripMenuItem";
            listeDesCommandeToolStripMenuItem.Size = new Size(296, 34);
            listeDesCommandeToolStripMenuItem.Text = "Commande un produit";
            listeDesCommandeToolStripMenuItem.Click += listeDesCommandeToolStripMenuItem_Click;
            // 
            // aProposToolStripMenuItem
            // 
            aProposToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listeDesCommandeToolStripMenuItem, listeDesCommandesToolStripMenuItem });
            aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            aProposToolStripMenuItem.Size = new Size(121, 29);
            aProposToolStripMenuItem.Text = "Commande";
            // 
            // listeDesProduitsToolStripMenuItem
            // 
            listeDesProduitsToolStripMenuItem.Name = "listeDesProduitsToolStripMenuItem";
            listeDesProduitsToolStripMenuItem.Size = new Size(253, 34);
            listeDesProduitsToolStripMenuItem.Text = "Liste des Produits";
            listeDesProduitsToolStripMenuItem.Click += listeDesProduitsToolStripMenuItem_Click;
            // 
            // produitsToolStripMenuItem
            // 
            produitsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listeDesProduitsToolStripMenuItem });
            produitsToolStripMenuItem.Name = "produitsToolStripMenuItem";
            produitsToolStripMenuItem.Size = new Size(94, 29);
            produitsToolStripMenuItem.Text = "Produits";
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(213, 34);
            quitterToolStripMenuItem.Text = "Quitter";
            quitterToolStripMenuItem.Click += quitterToolStripMenuItem_Click;
            // 
            // deconnecterToolStripMenuItem
            // 
            deconnecterToolStripMenuItem.Name = "deconnecterToolStripMenuItem";
            deconnecterToolStripMenuItem.Size = new Size(213, 34);
            deconnecterToolStripMenuItem.Text = "Deconnecter";
            deconnecterToolStripMenuItem.Click += deconnecterToolStripMenuItem_Click;
            // 
            // accueilToolStripMenuItem
            // 
            accueilToolStripMenuItem.Name = "accueilToolStripMenuItem";
            accueilToolStripMenuItem.Size = new Size(213, 34);
            accueilToolStripMenuItem.Text = "Accueil";
            accueilToolStripMenuItem.Click += accueilToolStripMenuItem_Click;
            // 
            // fichierToolStripMenuItem
            // 
            fichierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { accueilToolStripMenuItem, deconnecterToolStripMenuItem, quitterToolStripMenuItem });
            fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            fichierToolStripMenuItem.Size = new Size(78, 29);
            fichierToolStripMenuItem.Text = "Fichier";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fichierToolStripMenuItem, produitsToolStripMenuItem, aProposToolStripMenuItem, paiementsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1428, 33);
            menuStrip1.TabIndex = 59;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconButton1
            // 
            iconButton1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.HandPointLeft;
            iconButton1.IconColor = Color.Green;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 40;
            iconButton1.Location = new Point(32, 135);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(150, 45);
            iconButton1.TabIndex = 58;
            iconButton1.Text = "Accueil";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = Color.White;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(76, 201);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.RowTemplate.Height = 33;
            dataGridView.Size = new Size(1278, 375);
            dataGridView.TabIndex = 54;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(423, 59);
            label1.Name = "label1";
            label1.Size = new Size(393, 54);
            label1.TabIndex = 60;
            label1.Text = "Liste des Paiements";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(350, 135);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(334, 33);
            comboBox1.TabIndex = 61;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(123, 605);
            label2.Name = "label2";
            label2.Size = new Size(65, 32);
            label2.TabIndex = 62;
            label2.Text = "Total";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotal.Location = new Point(207, 605);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(0, 32);
            labelTotal.TabIndex = 63;
            // 
            // ListePaiement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1428, 694);
            Controls.Add(labelTotal);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(iconButton1);
            Controls.Add(dataGridView);
            Name = "ListePaiement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListePaiement";
            Load += ListePaiement_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSupprimerCommande;
        private ToolStripMenuItem paiementsToolStripMenuItem;
        private ToolStripMenuItem listeDesPaiementsToolStripMenuItem;
        private ToolStripMenuItem listeDesCommandesToolStripMenuItem;
        private ToolStripMenuItem listeDesCommandeToolStripMenuItem;
        private ToolStripMenuItem aProposToolStripMenuItem;
        private ToolStripMenuItem listeDesProduitsToolStripMenuItem;
        private ToolStripMenuItem produitsToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem deconnecterToolStripMenuItem;
        private ToolStripMenuItem accueilToolStripMenuItem;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Button button2;
        private DataGridView dataGridView;
        private Button buttonDetails;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private Label labelTotal;
    }
}