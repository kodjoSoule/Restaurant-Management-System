namespace Projet_RMS_Final.View.Administrateur
{
    partial class ListeUtilisateurForm
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
            splitContainer1 = new SplitContainer();
            textBoxId = new TextBox();
            label9 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            buttonUpdate = new Button();
            buttonEffacer = new Button();
            buttonValider = new Button();
            comboBoxRole = new ComboBox();
            textBoxTelephone = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            textBoxLogin = new TextBox();
            textBoxPrenom = new TextBox();
            textBoxNom = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            textBoxSearch = new TextBox();
            buttonSupprimer = new Button();
            button2 = new Button();
            dataGridViewUsers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
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
            splitContainer1.Panel1.BackColor = Color.FromArgb(105, 70, 221);
            splitContainer1.Panel1.Controls.Add(textBoxId);
            splitContainer1.Panel1.Controls.Add(label9);
            splitContainer1.Panel1.Controls.Add(iconButton1);
            splitContainer1.Panel1.Controls.Add(buttonUpdate);
            splitContainer1.Panel1.Controls.Add(buttonEffacer);
            splitContainer1.Panel1.Controls.Add(buttonValider);
            splitContainer1.Panel1.Controls.Add(comboBoxRole);
            splitContainer1.Panel1.Controls.Add(textBoxTelephone);
            splitContainer1.Panel1.Controls.Add(textBoxEmail);
            splitContainer1.Panel1.Controls.Add(textBoxPassword);
            splitContainer1.Panel1.Controls.Add(textBoxLogin);
            splitContainer1.Panel1.Controls.Add(textBoxPrenom);
            splitContainer1.Panel1.Controls.Add(textBoxNom);
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(label7);
            splitContainer1.Panel1.Controls.Add(label8);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(textBoxSearch);
            splitContainer1.Panel2.Controls.Add(buttonSupprimer);
            splitContainer1.Panel2.Controls.Add(button2);
            splitContainer1.Panel2.Controls.Add(dataGridViewUsers);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1478, 724);
            splitContainer1.SplitterDistance = 637;
            splitContainer1.TabIndex = 0;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(304, 89);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(274, 31);
            textBoxId.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(105, 70, 221);
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(29, 84);
            label9.Name = "label9";
            label9.Padding = new Padding(5);
            label9.Size = new Size(50, 42);
            label9.TabIndex = 19;
            label9.Text = "ID";
            // 
            // iconButton1
            // 
            iconButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 50;
            iconButton1.Location = new Point(21, 15);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(150, 55);
            iconButton1.TabIndex = 18;
            iconButton1.Text = "Retour";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.White;
            buttonUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUpdate.ForeColor = Color.Green;
            buttonUpdate.Location = new Point(117, 633);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(147, 46);
            buttonUpdate.TabIndex = 17;
            buttonUpdate.Text = "Mise a Jour";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonEffacer
            // 
            buttonEffacer.BackColor = Color.Red;
            buttonEffacer.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEffacer.ForeColor = Color.White;
            buttonEffacer.Location = new Point(283, 633);
            buttonEffacer.Name = "buttonEffacer";
            buttonEffacer.Size = new Size(127, 46);
            buttonEffacer.TabIndex = 16;
            buttonEffacer.Text = "Effacer";
            buttonEffacer.UseVisualStyleBackColor = false;
            buttonEffacer.Click += buttonEffacer_Click;
            // 
            // buttonValider
            // 
            buttonValider.BackColor = Color.White;
            buttonValider.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonValider.ForeColor = Color.FromArgb(105, 70, 221);
            buttonValider.Location = new Point(103, 633);
            buttonValider.Name = "buttonValider";
            buttonValider.Size = new Size(127, 46);
            buttonValider.TabIndex = 15;
            buttonValider.Text = "Valider";
            buttonValider.UseVisualStyleBackColor = false;
            buttonValider.Click += buttonValider_Click;
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(304, 533);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(274, 33);
            comboBoxRole.TabIndex = 14;
            comboBoxRole.SelectedIndexChanged += comboBoxRole_SelectedIndexChanged;
            // 
            // textBoxTelephone
            // 
            textBoxTelephone.Location = new Point(305, 470);
            textBoxTelephone.Name = "textBoxTelephone";
            textBoxTelephone.Size = new Size(274, 31);
            textBoxTelephone.TabIndex = 13;
            textBoxTelephone.TextChanged += textBoxTelephone_TextChanged;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(305, 394);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(274, 31);
            textBoxEmail.TabIndex = 12;
            textBoxEmail.TextChanged += textBoxEmail_TextChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(305, 330);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(274, 31);
            textBoxPassword.TabIndex = 11;
            textBoxPassword.TextChanged += textBox4_TextChanged;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(305, 259);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(274, 31);
            textBoxLogin.TabIndex = 10;
            textBoxLogin.TextChanged += textBoxLogin_TextChanged;
            // 
            // textBoxPrenom
            // 
            textBoxPrenom.Location = new Point(305, 198);
            textBoxPrenom.Name = "textBoxPrenom";
            textBoxPrenom.Size = new Size(274, 31);
            textBoxPrenom.TabIndex = 9;
            textBoxPrenom.TextChanged += textBoxPrenom_TextChanged;
            // 
            // textBoxNom
            // 
            textBoxNom.Location = new Point(304, 140);
            textBoxNom.Name = "textBoxNom";
            textBoxNom.Size = new Size(274, 31);
            textBoxNom.TabIndex = 8;
            textBoxNom.TextChanged += textBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(105, 70, 221);
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(25, 521);
            label6.Name = "label6";
            label6.Padding = new Padding(5);
            label6.Size = new Size(74, 42);
            label6.TabIndex = 6;
            label6.Text = "Role";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(105, 70, 221);
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(25, 459);
            label7.Name = "label7";
            label7.Padding = new Padding(5);
            label7.Size = new Size(141, 42);
            label7.TabIndex = 5;
            label7.Text = "Telephone";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(105, 70, 221);
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(25, 391);
            label8.Name = "label8";
            label8.Padding = new Padding(5);
            label8.Size = new Size(86, 42);
            label8.TabIndex = 4;
            label8.Text = "Email";
            label8.Click += label8_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(105, 70, 221);
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(25, 319);
            label3.Name = "label3";
            label3.Padding = new Padding(5);
            label3.Size = new Size(176, 42);
            label3.TabIndex = 3;
            label3.Text = "Mot de passe";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(105, 70, 221);
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(25, 248);
            label4.Name = "label4";
            label4.Padding = new Padding(5);
            label4.Size = new Size(205, 42);
            label4.TabIndex = 2;
            label4.Text = "Nom Utilisateur";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(105, 70, 221);
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(25, 187);
            label2.Name = "label2";
            label2.Padding = new Padding(5);
            label2.Size = new Size(114, 42);
            label2.TabIndex = 1;
            label2.Text = "Prenom";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(105, 70, 221);
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(29, 135);
            label1.Name = "label1";
            label1.Padding = new Padding(5);
            label1.Size = new Size(80, 42);
            label1.TabIndex = 0;
            label1.Text = "Nom";
            label1.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(151, 42);
            label5.Name = "label5";
            label5.Size = new Size(110, 28);
            label5.TabIndex = 4;
            label5.Text = "Recherche";
            label5.Click += label5_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(297, 42);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(465, 31);
            textBoxSearch.TabIndex = 3;
            textBoxSearch.TextChanged += textBox1_TextChanged_1;
            // 
            // buttonSupprimer
            // 
            buttonSupprimer.BackColor = Color.Red;
            buttonSupprimer.Cursor = Cursors.Hand;
            buttonSupprimer.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSupprimer.ForeColor = Color.White;
            buttonSupprimer.Location = new Point(599, 574);
            buttonSupprimer.Name = "buttonSupprimer";
            buttonSupprimer.Size = new Size(147, 56);
            buttonSupprimer.TabIndex = 2;
            buttonSupprimer.Text = "Supprimer";
            buttonSupprimer.UseVisualStyleBackColor = false;
            buttonSupprimer.Click += buttonSupprimer_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Orange;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(416, 574);
            button2.Name = "button2";
            button2.Size = new Size(147, 56);
            button2.TabIndex = 1;
            button2.Text = "Modifier";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.BackgroundColor = Color.White;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Location = new Point(16, 106);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.RowHeadersWidth = 62;
            dataGridViewUsers.RowTemplate.Height = 33;
            dataGridViewUsers.Size = new Size(778, 411);
            dataGridViewUsers.TabIndex = 0;
            //dataGridViewUsers.CellContentClick += dataGridViewUsers_CellContentClick;
            dataGridViewUsers.CellClick += dataGridViewUsers_CellClick;
            // 
            // ListeUtilisateurForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 724);
            Controls.Add(splitContainer1);
            Name = "ListeUtilisateurForm";
            Text = "ListeUtilisateurForm";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dataGridViewUsers;
        private TextBox textBoxPassword;
        private TextBox textBoxLogin;
        private TextBox textBoxPrenom;
        private TextBox textBoxNom;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox textBoxTelephone;
        private TextBox textBoxEmail;
        private ComboBox comboBoxRole;
        private Button buttonValider;
        private Button buttonUpdate;
        private Button buttonEffacer;
        private Button button2;
        private Button buttonSupprimer;
        private Label label5;
        private TextBox textBoxSearch;
        private FontAwesome.Sharp.IconButton iconButton1;
        private TextBox textBoxId;
        private Label label9;
    }
}