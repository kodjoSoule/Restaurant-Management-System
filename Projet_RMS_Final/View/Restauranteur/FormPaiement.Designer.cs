namespace Projet_RMS_Final.View.Restauranteur
{
    partial class FormPaiement
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            labelCommande = new Label();
            labelClient = new Label();
            labelClientAddresse = new Label();
            label13 = new Label();
            buttonPayer = new Button();
            button2 = new Button();
            textBoxMontantRecue = new TextBox();
            textBoxMontanRendue = new TextBox();
            textBoxTotal = new TextBox();
            dateTimePickerDatePaiement = new DateTimePicker();
            panel1 = new Panel();
            dateTimePickerDateCommande = new DateTimePicker();
            labelError = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(346, 7);
            label1.Name = "label1";
            label1.Size = new Size(339, 45);
            label1.TabIndex = 0;
            label1.Text = "Paiement Commande";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(275, 92);
            label2.Name = "label2";
            label2.Size = new Size(144, 32);
            label2.TabIndex = 1;
            label2.Text = "Commande";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(275, 146);
            label3.Name = "label3";
            label3.Size = new Size(80, 32);
            label3.TabIndex = 2;
            label3.Text = "Client";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(275, 256);
            label4.Name = "label4";
            label4.Size = new Size(204, 32);
            label4.TabIndex = 4;
            label4.Text = "Date Commande";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(275, 197);
            label5.Name = "label5";
            label5.Size = new Size(119, 32);
            label5.TabIndex = 3;
            label5.Text = "Addresse";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(275, 413);
            label6.Name = "label6";
            label6.Size = new Size(188, 32);
            label6.TabIndex = 7;
            label6.Text = "Montant Recue";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(275, 354);
            label7.Name = "label7";
            label7.Size = new Size(70, 32);
            label7.TabIndex = 6;
            label7.Text = "Total";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(275, 303);
            label8.Name = "label8";
            label8.Size = new Size(180, 32);
            label8.TabIndex = 5;
            label8.Text = "Date Paiement";
            // 
            // labelCommande
            // 
            labelCommande.AutoSize = true;
            labelCommande.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelCommande.Location = new Point(600, 92);
            labelCommande.Name = "labelCommande";
            labelCommande.Size = new Size(0, 32);
            labelCommande.TabIndex = 8;
            labelCommande.Click += label9_Click;
            // 
            // labelClient
            // 
            labelClient.AutoSize = true;
            labelClient.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelClient.Location = new Point(600, 146);
            labelClient.Name = "labelClient";
            labelClient.Size = new Size(0, 32);
            labelClient.TabIndex = 9;
            // 
            // labelClientAddresse
            // 
            labelClientAddresse.AutoSize = true;
            labelClientAddresse.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelClientAddresse.Location = new Point(600, 197);
            labelClientAddresse.Name = "labelClientAddresse";
            labelClientAddresse.Size = new Size(0, 32);
            labelClientAddresse.TabIndex = 10;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(275, 466);
            label13.Name = "label13";
            label13.Size = new Size(225, 32);
            label13.TabIndex = 12;
            label13.Text = "Montant A Rendre";
            // 
            // buttonPayer
            // 
            buttonPayer.BackColor = Color.Green;
            buttonPayer.Cursor = Cursors.No;
            buttonPayer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPayer.ForeColor = Color.White;
            buttonPayer.Location = new Point(351, 539);
            buttonPayer.Name = "buttonPayer";
            buttonPayer.Size = new Size(149, 60);
            buttonPayer.TabIndex = 13;
            buttonPayer.Text = "Payer";
            buttonPayer.UseVisualStyleBackColor = false;
            buttonPayer.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(545, 539);
            button2.Name = "button2";
            button2.Size = new Size(149, 60);
            button2.TabIndex = 14;
            button2.Text = "Annuler";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBoxMontantRecue
            // 
            textBoxMontantRecue.Location = new Point(600, 416);
            textBoxMontantRecue.Name = "textBoxMontantRecue";
            textBoxMontantRecue.Size = new Size(188, 31);
            textBoxMontantRecue.TabIndex = 15;
            textBoxMontantRecue.TextChanged += textBoxMontantRecue_TextChanged;
            // 
            // textBoxMontanRendue
            // 
            textBoxMontanRendue.Enabled = false;
            textBoxMontanRendue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxMontanRendue.ForeColor = Color.Orange;
            textBoxMontanRendue.Location = new Point(600, 469);
            textBoxMontanRendue.Name = "textBoxMontanRendue";
            textBoxMontanRendue.Size = new Size(188, 31);
            textBoxMontanRendue.TabIndex = 16;
            // 
            // textBoxTotal
            // 
            textBoxTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTotal.Location = new Point(600, 357);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.Size = new Size(188, 39);
            textBoxTotal.TabIndex = 17;
            // 
            // dateTimePickerDatePaiement
            // 
            dateTimePickerDatePaiement.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePickerDatePaiement.Cursor = Cursors.Hand;
            dateTimePickerDatePaiement.CustomFormat = "dd/mm/yy hh:mm";
            dateTimePickerDatePaiement.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerDatePaiement.Format = DateTimePickerFormat.Short;
            dateTimePickerDatePaiement.Location = new Point(600, 304);
            dateTimePickerDatePaiement.Name = "dateTimePickerDatePaiement";
            dateTimePickerDatePaiement.Size = new Size(188, 39);
            dateTimePickerDatePaiement.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(5, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1042, 69);
            panel1.TabIndex = 19;
            // 
            // dateTimePickerDateCommande
            // 
            dateTimePickerDateCommande.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePickerDateCommande.Cursor = Cursors.Hand;
            dateTimePickerDateCommande.CustomFormat = "dd/mm/yy hh:mm";
            dateTimePickerDateCommande.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerDateCommande.Format = DateTimePickerFormat.Short;
            dateTimePickerDateCommande.Location = new Point(600, 251);
            dateTimePickerDateCommande.Name = "dateTimePickerDateCommande";
            dateTimePickerDateCommande.Size = new Size(188, 39);
            dateTimePickerDateCommande.TabIndex = 19;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Font = new Font("Segoe Print", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelError.Location = new Point(805, 416);
            labelError.Name = "labelError";
            labelError.Size = new Size(0, 35);
            labelError.TabIndex = 20;
            // 
            // FormPaiement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1056, 639);
            Controls.Add(labelError);
            Controls.Add(dateTimePickerDateCommande);
            Controls.Add(panel1);
            Controls.Add(dateTimePickerDatePaiement);
            Controls.Add(textBoxTotal);
            Controls.Add(textBoxMontanRendue);
            Controls.Add(textBoxMontantRecue);
            Controls.Add(button2);
            Controls.Add(buttonPayer);
            Controls.Add(label13);
            Controls.Add(labelClientAddresse);
            Controls.Add(labelClient);
            Controls.Add(labelCommande);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "FormPaiement";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormPaiement";
            Load += FormPaiement_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label labelCommande;
        private Label labelClient;
        private Label labelClientAddresse;
        private Label label12;
        private Label label13;
        private Button button1;
        private Button button2;
        private TextBox textBoxMontantRecue;
        private TextBox textBoxMontanRendue;
        private TextBox textBoxTotal;
        private DateTimePicker dateTimePickerDatePaiement;
        private Panel panel1;
        private DateTimePicker dateTimePickerDateCommande;
        private Button buttonPayer;
        private Label labelError;
    }
}