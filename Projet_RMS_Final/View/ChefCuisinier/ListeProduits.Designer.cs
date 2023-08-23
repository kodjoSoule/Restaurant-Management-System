namespace Projet_RMS_Final.View.ChefCuisinier
{
    partial class ListeProduits
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
            label5 = new Label();
            textBoxSearch = new TextBox();
            buttonSupprimer = new Button();
            button2 = new Button();
            dataGridView = new DataGridView();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            fichierToolStripMenuItem = new ToolStripMenuItem();
            accueilToolStripMenuItem = new ToolStripMenuItem();
            deconnecterToolStripMenuItem = new ToolStripMenuItem();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            produitsToolStripMenuItem = new ToolStripMenuItem();
            ajouterUnProduitToolStripMenuItem = new ToolStripMenuItem();
            categorieProduitToolStripMenuItem = new ToolStripMenuItem();
            listeDesProduitsToolStripMenuItem = new ToolStripMenuItem();
            aProposToolStripMenuItem = new ToolStripMenuItem();
            aProposToolStripMenuItem1 = new ToolStripMenuItem();
            labelCategorie = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(262, 106);
            label5.Name = "label5";
            label5.Size = new Size(110, 28);
            label5.TabIndex = 9;
            label5.Text = "Recherche";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(460, 106);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(414, 31);
            textBoxSearch.TabIndex = 8;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // buttonSupprimer
            // 
            buttonSupprimer.BackColor = Color.Red;
            buttonSupprimer.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSupprimer.ForeColor = Color.White;
            buttonSupprimer.Location = new Point(716, 613);
            buttonSupprimer.Name = "buttonSupprimer";
            buttonSupprimer.Size = new Size(147, 56);
            buttonSupprimer.TabIndex = 7;
            buttonSupprimer.Text = "Supprimer";
            buttonSupprimer.UseVisualStyleBackColor = false;
            buttonSupprimer.Click += buttonSupprimer_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Orange;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(533, 613);
            button2.Name = "button2";
            button2.Size = new Size(147, 56);
            button2.TabIndex = 6;
            button2.Text = "Modifier";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = Color.White;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(65, 165);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.RowTemplate.Height = 33;
            dataGridView.Size = new Size(1040, 411);
            dataGridView.TabIndex = 5;
            dataGridView.CellClick += dataGridViewUsers_CellClick;
            dataGridView.CellContentClick += dataGridViewUsers_CellContentClick;
            // 
            // iconButton1
            // 
            iconButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 50;
            iconButton1.Location = new Point(31, 50);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(150, 55);
            iconButton1.TabIndex = 37;
            iconButton1.Text = "Retour";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1121, 217);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 255);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1111, 165);
            label1.Name = "label1";
            label1.Size = new Size(80, 32);
            label1.TabIndex = 39;
            label1.Text = "Image";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(346, 613);
            button1.Name = "button1";
            button1.Size = new Size(147, 56);
            button1.TabIndex = 40;
            button1.Text = "Ajouter";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fichierToolStripMenuItem, produitsToolStripMenuItem, aProposToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1428, 33);
            menuStrip1.TabIndex = 41;
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
            accueilToolStripMenuItem.Size = new Size(213, 34);
            accueilToolStripMenuItem.Text = "Accueil";
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
            produitsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ajouterUnProduitToolStripMenuItem, categorieProduitToolStripMenuItem, listeDesProduitsToolStripMenuItem });
            produitsToolStripMenuItem.Name = "produitsToolStripMenuItem";
            produitsToolStripMenuItem.Size = new Size(94, 29);
            produitsToolStripMenuItem.Text = "Produits";
            // 
            // ajouterUnProduitToolStripMenuItem
            // 
            ajouterUnProduitToolStripMenuItem.Name = "ajouterUnProduitToolStripMenuItem";
            ajouterUnProduitToolStripMenuItem.Size = new Size(260, 34);
            ajouterUnProduitToolStripMenuItem.Text = "Ajouter un Produit";
            // 
            // categorieProduitToolStripMenuItem
            // 
            categorieProduitToolStripMenuItem.Name = "categorieProduitToolStripMenuItem";
            categorieProduitToolStripMenuItem.Size = new Size(260, 34);
            categorieProduitToolStripMenuItem.Text = "Categorie Produit";
            // 
            // listeDesProduitsToolStripMenuItem
            // 
            listeDesProduitsToolStripMenuItem.Name = "listeDesProduitsToolStripMenuItem";
            listeDesProduitsToolStripMenuItem.Size = new Size(260, 34);
            listeDesProduitsToolStripMenuItem.Text = "Liste des Produits";
            // 
            // aProposToolStripMenuItem
            // 
            aProposToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aProposToolStripMenuItem1 });
            aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            aProposToolStripMenuItem.Size = new Size(102, 29);
            aProposToolStripMenuItem.Text = "A Propos";
            // 
            // aProposToolStripMenuItem1
            // 
            aProposToolStripMenuItem1.Name = "aProposToolStripMenuItem1";
            aProposToolStripMenuItem1.Size = new Size(189, 34);
            aProposToolStripMenuItem1.Text = "A propos";
            // 
            // labelCategorie
            // 
            labelCategorie.AutoSize = true;
            labelCategorie.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelCategorie.Location = new Point(1121, 499);
            labelCategorie.Name = "labelCategorie";
            labelCategorie.Size = new Size(0, 32);
            labelCategorie.TabIndex = 42;
            // 
            // ListeProduits
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1428, 694);
            Controls.Add(labelCategorie);
            Controls.Add(menuStrip1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(iconButton1);
            Controls.Add(label5);
            Controls.Add(textBoxSearch);
            Controls.Add(buttonSupprimer);
            Controls.Add(button2);
            Controls.Add(dataGridView);
            Name = "ListeProduits";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListeProduits";
            Load += ListeProduits_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox textBoxSearch;
        private Button buttonSupprimer;
        private Button button2;
        private DataGridView dataGridView;
        private FontAwesome.Sharp.IconButton iconButton1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem accueilToolStripMenuItem;
        private ToolStripMenuItem deconnecterToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem produitsToolStripMenuItem;
        private ToolStripMenuItem ajouterUnProduitToolStripMenuItem;
        private ToolStripMenuItem categorieProduitToolStripMenuItem;
        private ToolStripMenuItem listeDesProduitsToolStripMenuItem;
        private ToolStripMenuItem aProposToolStripMenuItem;
        private ToolStripMenuItem aProposToolStripMenuItem1;
        private Label labelCategorie;
    }
}