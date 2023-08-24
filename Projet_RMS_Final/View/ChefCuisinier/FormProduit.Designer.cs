namespace Projet_RMS_Final.View.ChefCuisinier
{
    partial class FormProduit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduit));
            iconButton1 = new FontAwesome.Sharp.IconButton();
            comboBoxCategorie = new ComboBox();
            textBoxPrix = new TextBox();
            textBoxDescription = new TextBox();
            textBoxIntitule = new TextBox();
            label8 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            pictureBoxImage = new PictureBox();
            iconButtonValider = new FontAwesome.Sharp.IconButton();
            button1 = new Button();
            buttonImage = new Button();
            iconButtonModifier = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            SuspendLayout();
            // 
            // iconButton1
            // 
            iconButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 45;
            iconButton1.Location = new Point(42, 29);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(150, 46);
            iconButton1.TabIndex = 36;
            iconButton1.Text = "Retour";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // comboBoxCategorie
            // 
            comboBoxCategorie.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCategorie.FormattingEnabled = true;
            comboBoxCategorie.Location = new Point(693, 255);
            comboBoxCategorie.Name = "comboBoxCategorie";
            comboBoxCategorie.Size = new Size(349, 40);
            comboBoxCategorie.TabIndex = 32;
            comboBoxCategorie.SelectedIndexChanged += comboBoxCategorie_SelectedIndexChanged;
            // 
            // textBoxPrix
            // 
            textBoxPrix.Location = new Point(693, 186);
            textBoxPrix.Name = "textBoxPrix";
            textBoxPrix.Size = new Size(349, 31);
            textBoxPrix.TabIndex = 28;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDescription.Location = new Point(693, 125);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(349, 39);
            textBoxDescription.TabIndex = 27;
            // 
            // textBoxIntitule
            // 
            textBoxIntitule.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxIntitule.Location = new Point(692, 67);
            textBoxIntitule.Name = "textBoxIntitule";
            textBoxIntitule.Size = new Size(350, 39);
            textBoxIntitule.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(481, 327);
            label8.Name = "label8";
            label8.Padding = new Padding(5);
            label8.Size = new Size(95, 42);
            label8.TabIndex = 23;
            label8.Text = "Image";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(481, 255);
            label3.Name = "label3";
            label3.Padding = new Padding(5);
            label3.Size = new Size(134, 42);
            label3.TabIndex = 22;
            label3.Text = "Categorie";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(481, 184);
            label4.Name = "label4";
            label4.Padding = new Padding(5);
            label4.Size = new Size(69, 42);
            label4.TabIndex = 21;
            label4.Text = "Prix";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(481, 123);
            label2.Name = "label2";
            label2.Padding = new Padding(5);
            label2.Size = new Size(156, 42);
            label2.TabIndex = 20;
            label2.Text = "Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(485, 71);
            label1.Name = "label1";
            label1.Padding = new Padding(5);
            label1.Size = new Size(107, 42);
            label1.TabIndex = 19;
            label1.Text = "Intitule";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(481, 395);
            label7.Name = "label7";
            label7.Padding = new Padding(5);
            label7.Size = new Size(197, 42);
            label7.TabIndex = 24;
            label7.Text = "Apercue Image";
            // 
            // pictureBoxImage
            // 
            pictureBoxImage.BackColor = Color.White;
            pictureBoxImage.Location = new Point(693, 386);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Size = new Size(349, 143);
            pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImage.TabIndex = 37;
            pictureBoxImage.TabStop = false;
            // 
            // iconButtonValider
            // 
            iconButtonValider.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            iconButtonValider.IconChar = FontAwesome.Sharp.IconChar.Check;
            iconButtonValider.IconColor = Color.Green;
            iconButtonValider.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonValider.IconSize = 50;
            iconButtonValider.Location = new Point(595, 577);
            iconButtonValider.Name = "iconButtonValider";
            iconButtonValider.Size = new Size(171, 50);
            iconButtonValider.TabIndex = 38;
            iconButtonValider.Text = "Valider";
            iconButtonValider.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonValider.UseVisualStyleBackColor = true;
            iconButtonValider.Click += iconButton2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(801, 577);
            button1.Name = "button1";
            button1.Size = new Size(154, 50);
            button1.TabIndex = 39;
            button1.Text = "Effacer";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonImage
            // 
            buttonImage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonImage.Location = new Point(692, 327);
            buttonImage.Name = "buttonImage";
            buttonImage.Size = new Size(350, 42);
            buttonImage.TabIndex = 40;
            buttonImage.Text = "Charger Image ...";
            buttonImage.UseVisualStyleBackColor = true;
            buttonImage.Click += buttonImage_Click;
            // 
            // iconButtonModifier
            // 
            iconButtonModifier.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            iconButtonModifier.IconChar = FontAwesome.Sharp.IconChar.Check;
            iconButtonModifier.IconColor = Color.Green;
            iconButtonModifier.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonModifier.IconSize = 50;
            iconButtonModifier.Location = new Point(566, 577);
            iconButtonModifier.Name = "iconButtonModifier";
            iconButtonModifier.Size = new Size(171, 50);
            iconButtonModifier.TabIndex = 41;
            iconButtonModifier.Text = "Modifier";
            iconButtonModifier.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonModifier.UseVisualStyleBackColor = true;
            iconButtonModifier.Click += iconButtonModifier_Click;
            // 
            // FormProduit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1428, 694);
            Controls.Add(iconButtonModifier);
            Controls.Add(buttonImage);
            Controls.Add(button1);
            Controls.Add(iconButtonValider);
            Controls.Add(pictureBoxImage);
            Controls.Add(iconButton1);
            Controls.Add(comboBoxCategorie);
            Controls.Add(textBoxPrix);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxIntitule);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormProduit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormProduit";
            Load += FormProduit_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton1;
        private ComboBox comboBoxCategorie;
        private TextBox textBoxPrix;
        private TextBox textBoxDescription;
        private TextBox textBoxIntitule;
        private Label label8;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label7;
        private PictureBox pictureBoxImage;
        private FontAwesome.Sharp.IconButton iconButtonValider;
        private Button button1;
        private Button buttonImage;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButtonModifier;
    }
}