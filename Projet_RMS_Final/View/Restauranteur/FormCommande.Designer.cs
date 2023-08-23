namespace Projet_RMS_Final.View.Restauranteur
{
    partial class FormCommande
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
            label9 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            buttonEffacer = new Button();
            buttonEnregistrer = new Button();
            textBoxQuantite = new TextBox();
            textBoxPrix = new TextBox();
            textBoxProduit = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxNomClient = new TextBox();
            textBoxTelephone = new TextBox();
            textBoxPrenomClient = new TextBox();
            textBoxEmail = new TextBox();
            label5 = new Label();
            label10 = new Label();
            textBoxAddresse = new TextBox();
            label11 = new Label();
            dateTimePickerDate = new DateTimePicker();
            comboBoxStatut = new ComboBox();
            buttonAnnuler = new Button();
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
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(81, 144);
            label9.Name = "label9";
            label9.Padding = new Padding(5);
            label9.Size = new Size(110, 42);
            label9.TabIndex = 39;
            label9.Text = "Produit";
            // 
            // iconButton1
            // 
            iconButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 40;
            iconButton1.Location = new Point(27, 44);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(150, 40);
            iconButton1.TabIndex = 38;
            iconButton1.Text = "Retour";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // buttonEffacer
            // 
            buttonEffacer.BackColor = Color.Red;
            buttonEffacer.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEffacer.ForeColor = Color.White;
            buttonEffacer.Location = new Point(822, 493);
            buttonEffacer.Name = "buttonEffacer";
            buttonEffacer.Size = new Size(127, 46);
            buttonEffacer.TabIndex = 36;
            buttonEffacer.Text = "Effacer";
            buttonEffacer.UseVisualStyleBackColor = false;
            buttonEffacer.Click += buttonEffacer_Click;
            // 
            // buttonEnregistrer
            // 
            buttonEnregistrer.BackColor = Color.White;
            buttonEnregistrer.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEnregistrer.ForeColor = Color.FromArgb(105, 70, 221);
            buttonEnregistrer.Location = new Point(433, 578);
            buttonEnregistrer.Name = "buttonEnregistrer";
            buttonEnregistrer.Size = new Size(127, 46);
            buttonEnregistrer.TabIndex = 35;
            buttonEnregistrer.Text = "Valider";
            buttonEnregistrer.UseVisualStyleBackColor = false;
            buttonEnregistrer.Click += buttonEnregistrer_Click_1;
            // 
            // textBoxQuantite
            // 
            textBoxQuantite.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxQuantite.Location = new Point(227, 263);
            textBoxQuantite.Name = "textBoxQuantite";
            textBoxQuantite.Size = new Size(274, 39);
            textBoxQuantite.TabIndex = 30;
            // 
            // textBoxPrix
            // 
            textBoxPrix.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPrix.Location = new Point(226, 205);
            textBoxPrix.Name = "textBoxPrix";
            textBoxPrix.Size = new Size(274, 39);
            textBoxPrix.TabIndex = 29;
            // 
            // textBoxProduit
            // 
            textBoxProduit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxProduit.Location = new Point(226, 144);
            textBoxProduit.Name = "textBoxProduit";
            textBoxProduit.Size = new Size(274, 39);
            textBoxProduit.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(597, 260);
            label6.Name = "label6";
            label6.Padding = new Padding(5);
            label6.Size = new Size(141, 42);
            label6.TabIndex = 27;
            label6.Text = "Telephone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(597, 202);
            label7.Name = "label7";
            label7.Padding = new Padding(5);
            label7.Size = new Size(187, 42);
            label7.TabIndex = 26;
            label7.Text = "Prenom Client";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(597, 142);
            label8.Name = "label8";
            label8.Padding = new Padding(5);
            label8.Size = new Size(153, 42);
            label8.TabIndex = 25;
            label8.Text = "Nom Client";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(77, 384);
            label3.Name = "label3";
            label3.Padding = new Padding(5);
            label3.Size = new Size(91, 42);
            label3.TabIndex = 24;
            label3.Text = "Statut";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(80, 321);
            label4.Name = "label4";
            label4.Padding = new Padding(5);
            label4.Size = new Size(77, 42);
            label4.TabIndex = 23;
            label4.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(77, 252);
            label2.Name = "label2";
            label2.Padding = new Padding(5);
            label2.Size = new Size(123, 42);
            label2.TabIndex = 22;
            label2.Text = "Quantite";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(81, 200);
            label1.Name = "label1";
            label1.Padding = new Padding(5);
            label1.Size = new Size(69, 42);
            label1.TabIndex = 21;
            label1.Text = "Prix";
            // 
            // textBoxNomClient
            // 
            textBoxNomClient.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNomClient.Location = new Point(822, 142);
            textBoxNomClient.Name = "textBoxNomClient";
            textBoxNomClient.Size = new Size(274, 39);
            textBoxNomClient.TabIndex = 40;
            // 
            // textBoxTelephone
            // 
            textBoxTelephone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTelephone.Location = new Point(822, 271);
            textBoxTelephone.Name = "textBoxTelephone";
            textBoxTelephone.Size = new Size(274, 39);
            textBoxTelephone.TabIndex = 41;
            // 
            // textBoxPrenomClient
            // 
            textBoxPrenomClient.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPrenomClient.Location = new Point(822, 211);
            textBoxPrenomClient.Name = "textBoxPrenomClient";
            textBoxPrenomClient.Size = new Size(274, 39);
            textBoxPrenomClient.TabIndex = 42;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.Location = new Point(822, 334);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(274, 39);
            textBoxEmail.TabIndex = 43;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(597, 331);
            label5.Name = "label5";
            label5.Padding = new Padding(5);
            label5.Size = new Size(86, 42);
            label5.TabIndex = 44;
            label5.Text = "Email";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(597, 395);
            label10.Name = "label10";
            label10.Padding = new Padding(5);
            label10.Size = new Size(129, 42);
            label10.TabIndex = 45;
            label10.Text = "Addresse";
            // 
            // textBoxAddresse
            // 
            textBoxAddresse.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAddresse.Location = new Point(822, 398);
            textBoxAddresse.Name = "textBoxAddresse";
            textBoxAddresse.Size = new Size(274, 39);
            textBoxAddresse.TabIndex = 46;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(377, 53);
            label11.Name = "label11";
            label11.Size = new Size(599, 54);
            label11.TabIndex = 47;
            label11.Text = "Enregistrement de Commande ";
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerDate.Location = new Point(227, 320);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(274, 39);
            dateTimePickerDate.TabIndex = 48;
            // 
            // comboBoxStatut
            // 
            comboBoxStatut.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxStatut.FormattingEnabled = true;
            comboBoxStatut.Location = new Point(227, 387);
            comboBoxStatut.Name = "comboBoxStatut";
            comboBoxStatut.Size = new Size(274, 40);
            comboBoxStatut.TabIndex = 49;
            comboBoxStatut.SelectedIndexChanged += comboBoxStatut_SelectedIndexChanged;
            // 
            // buttonAnnuler
            // 
            buttonAnnuler.BackColor = Color.White;
            buttonAnnuler.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAnnuler.ForeColor = Color.FromArgb(105, 70, 221);
            buttonAnnuler.Location = new Point(611, 578);
            buttonAnnuler.Name = "buttonAnnuler";
            buttonAnnuler.Size = new Size(127, 46);
            buttonAnnuler.TabIndex = 50;
            buttonAnnuler.Text = "Annuler";
            buttonAnnuler.UseVisualStyleBackColor = false;
            buttonAnnuler.Click += buttonAnnuler_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fichierToolStripMenuItem, produitsToolStripMenuItem, aProposToolStripMenuItem, paiementsToolStripMenuItem, recetteToolStripMenuItem, aProposToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1428, 33);
            menuStrip1.TabIndex = 51;
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
            // FormCommande
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chocolate;
            ClientSize = new Size(1428, 694);
            Controls.Add(menuStrip1);
            Controls.Add(buttonAnnuler);
            Controls.Add(comboBoxStatut);
            Controls.Add(dateTimePickerDate);
            Controls.Add(label11);
            Controls.Add(textBoxAddresse);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxPrenomClient);
            Controls.Add(textBoxTelephone);
            Controls.Add(textBoxNomClient);
            Controls.Add(label9);
            Controls.Add(iconButton1);
            Controls.Add(buttonEffacer);
            Controls.Add(buttonEnregistrer);
            Controls.Add(textBoxQuantite);
            Controls.Add(textBoxPrix);
            Controls.Add(textBoxProduit);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCommande";
            Text = "FormCommande";
            Load += FormCommande_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label9;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Button buttonEffacer;
        private Button buttonEnregistrer;
        private Button buttonValider;
        private TextBox textBoxEmail;
        private TextBox textBoxDate;
        private TextBox textBoxQuantite;
        private TextBox textBoxPrix;
        private TextBox textBoxProduit;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox textBoxNomClient;
        private TextBox textBoxTelephone;
        private TextBox textBoxPrenomClient;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label5;
        private Label label10;
        private TextBox textBoxAddresse;
        private Label label11;
        private DateTimePicker dateTimePickerDate;
        private ComboBox comboBoxStatut;
        private Button buttonAnnuler;
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
        private ToolStripMenuItem recetteToolStripMenuItem;
        private ToolStripMenuItem listeDesRecettesToolStripMenuItem;
        private ToolStripMenuItem aProposToolStripMenuItem1;
    }
}