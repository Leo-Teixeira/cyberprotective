namespace TP4_POO_Bilan_Classes_Objet_Collection
{
    partial class FormBiensImmobiliers
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbTypeBien = new System.Windows.Forms.GroupBox();
            this.rbMaison = new System.Windows.Forms.RadioButton();
            this.rbAppart = new System.Windows.Forms.RadioButton();
            this.gbCaracteristiques = new System.Windows.Forms.GroupBox();
            this.numNbSalleEau = new System.Windows.Forms.NumericUpDown();
            this.numNbChambres = new System.Windows.Forms.NumericUpDown();
            this.numNbPieces = new System.Windows.Forms.NumericUpDown();
            this.tbVille = new System.Windows.Forms.TextBox();
            this.tbAdresse = new System.Windows.Forms.TextBox();
            this.tbSurface = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPrix = new System.Windows.Forms.GroupBox();
            this.tbPrix = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.cbListeBiens = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.gbConsultation = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbTypeBien.SuspendLayout();
            this.gbCaracteristiques.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNbSalleEau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNbChambres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNbPieces)).BeginInit();
            this.gbPrix.SuspendLayout();
            this.gbConsultation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTypeBien
            // 
            this.gbTypeBien.Controls.Add(this.rbMaison);
            this.gbTypeBien.Controls.Add(this.rbAppart);
            this.gbTypeBien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTypeBien.Location = new System.Drawing.Point(81, 15);
            this.gbTypeBien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbTypeBien.Name = "gbTypeBien";
            this.gbTypeBien.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbTypeBien.Size = new System.Drawing.Size(493, 62);
            this.gbTypeBien.TabIndex = 0;
            this.gbTypeBien.TabStop = false;
            this.gbTypeBien.Text = "Type du bien";
            // 
            // rbMaison
            // 
            this.rbMaison.AutoSize = true;
            this.rbMaison.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMaison.Location = new System.Drawing.Point(291, 25);
            this.rbMaison.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbMaison.Name = "rbMaison";
            this.rbMaison.Size = new System.Drawing.Size(84, 24);
            this.rbMaison.TabIndex = 1;
            this.rbMaison.TabStop = true;
            this.rbMaison.Text = "Maison";
            this.rbMaison.UseVisualStyleBackColor = true;
            // 
            // rbAppart
            // 
            this.rbAppart.AutoSize = true;
            this.rbAppart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAppart.Location = new System.Drawing.Point(88, 25);
            this.rbAppart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbAppart.Name = "rbAppart";
            this.rbAppart.Size = new System.Drawing.Size(125, 24);
            this.rbAppart.TabIndex = 0;
            this.rbAppart.TabStop = true;
            this.rbAppart.Text = "Appartement";
            this.rbAppart.UseVisualStyleBackColor = true;
            // 
            // gbCaracteristiques
            // 
            this.gbCaracteristiques.Controls.Add(this.numNbSalleEau);
            this.gbCaracteristiques.Controls.Add(this.numNbChambres);
            this.gbCaracteristiques.Controls.Add(this.numNbPieces);
            this.gbCaracteristiques.Controls.Add(this.tbVille);
            this.gbCaracteristiques.Controls.Add(this.tbAdresse);
            this.gbCaracteristiques.Controls.Add(this.tbSurface);
            this.gbCaracteristiques.Controls.Add(this.label6);
            this.gbCaracteristiques.Controls.Add(this.label5);
            this.gbCaracteristiques.Controls.Add(this.label4);
            this.gbCaracteristiques.Controls.Add(this.label3);
            this.gbCaracteristiques.Controls.Add(this.label2);
            this.gbCaracteristiques.Controls.Add(this.label1);
            this.gbCaracteristiques.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCaracteristiques.Location = new System.Drawing.Point(81, 84);
            this.gbCaracteristiques.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbCaracteristiques.Name = "gbCaracteristiques";
            this.gbCaracteristiques.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbCaracteristiques.Size = new System.Drawing.Size(493, 284);
            this.gbCaracteristiques.TabIndex = 1;
            this.gbCaracteristiques.TabStop = false;
            this.gbCaracteristiques.Text = "Caractéristiques";
            // 
            // numNbSalleEau
            // 
            this.numNbSalleEau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNbSalleEau.Location = new System.Drawing.Point(199, 215);
            this.numNbSalleEau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numNbSalleEau.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numNbSalleEau.Name = "numNbSalleEau";
            this.numNbSalleEau.Size = new System.Drawing.Size(133, 26);
            this.numNbSalleEau.TabIndex = 11;
            // 
            // numNbChambres
            // 
            this.numNbChambres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNbChambres.Location = new System.Drawing.Point(199, 181);
            this.numNbChambres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numNbChambres.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numNbChambres.Name = "numNbChambres";
            this.numNbChambres.Size = new System.Drawing.Size(133, 26);
            this.numNbChambres.TabIndex = 10;
            // 
            // numNbPieces
            // 
            this.numNbPieces.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNbPieces.Location = new System.Drawing.Point(199, 146);
            this.numNbPieces.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numNbPieces.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numNbPieces.Name = "numNbPieces";
            this.numNbPieces.Size = new System.Drawing.Size(133, 26);
            this.numNbPieces.TabIndex = 9;
            // 
            // tbVille
            // 
            this.tbVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVille.Location = new System.Drawing.Point(127, 110);
            this.tbVille.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbVille.Name = "tbVille";
            this.tbVille.Size = new System.Drawing.Size(303, 26);
            this.tbVille.TabIndex = 8;
            // 
            // tbAdresse
            // 
            this.tbAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAdresse.Location = new System.Drawing.Point(127, 75);
            this.tbAdresse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAdresse.Name = "tbAdresse";
            this.tbAdresse.Size = new System.Drawing.Size(303, 26);
            this.tbAdresse.TabIndex = 7;
            // 
            // tbSurface
            // 
            this.tbSurface.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSurface.Location = new System.Drawing.Point(199, 39);
            this.tbSurface.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSurface.Name = "tbSurface";
            this.tbSurface.Size = new System.Drawing.Size(132, 26);
            this.tbSurface.TabIndex = 6;
            this.tbSurface.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbSurface_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 219);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nb de salles d\'eau : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nb de chambres : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nb de pièces :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ville : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adresse :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Surface habitable :";
            // 
            // gbPrix
            // 
            this.gbPrix.Controls.Add(this.tbPrix);
            this.gbPrix.Controls.Add(this.label7);
            this.gbPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPrix.Location = new System.Drawing.Point(81, 407);
            this.gbPrix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPrix.Name = "gbPrix";
            this.gbPrix.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPrix.Size = new System.Drawing.Size(493, 79);
            this.gbPrix.TabIndex = 2;
            this.gbPrix.TabStop = false;
            this.gbPrix.Text = "Type du bien";
            // 
            // tbPrix
            // 
            this.tbPrix.Location = new System.Drawing.Point(156, 38);
            this.tbPrix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPrix.Name = "tbPrix";
            this.tbPrix.Size = new System.Drawing.Size(132, 26);
            this.tbPrix.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 38);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Prix voulu :";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.Red;
            this.btnAjouter.Location = new System.Drawing.Point(628, 442);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(128, 44);
            this.btnAjouter.TabIndex = 3;
            this.btnAjouter.Text = "AJOUTER";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(776, 442);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(128, 44);
            this.btnAnnuler.TabIndex = 4;
            this.btnAnnuler.Text = "ANNULER";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(931, 442);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(128, 44);
            this.btnQuitter.TabIndex = 5;
            this.btnQuitter.Text = "QUITTER";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(103, 130);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(128, 44);
            this.btnModifier.TabIndex = 6;
            this.btnModifier.Text = "MODIFIER";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // cbListeBiens
            // 
            this.cbListeBiens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListeBiens.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbListeBiens.FormattingEnabled = true;
            this.cbListeBiens.Location = new System.Drawing.Point(27, 63);
            this.cbListeBiens.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbListeBiens.Name = "cbListeBiens";
            this.cbListeBiens.Size = new System.Drawing.Size(413, 25);
            this.cbListeBiens.TabIndex = 7;
            this.cbListeBiens.SelectedIndexChanged += new System.EventHandler(this.CbListeBiens_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 30);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Liste des biens ";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(299, 130);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(143, 44);
            this.btnSupprimer.TabIndex = 9;
            this.btnSupprimer.Text = "SUPPRIMER";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // gbConsultation
            // 
            this.gbConsultation.Controls.Add(this.label8);
            this.gbConsultation.Controls.Add(this.btnSupprimer);
            this.gbConsultation.Controls.Add(this.cbListeBiens);
            this.gbConsultation.Controls.Add(this.btnModifier);
            this.gbConsultation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsultation.Location = new System.Drawing.Point(601, 193);
            this.gbConsultation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbConsultation.Name = "gbConsultation";
            this.gbConsultation.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbConsultation.Size = new System.Drawing.Size(477, 196);
            this.gbConsultation.TabIndex = 10;
            this.gbConsultation.TabStop = false;
            this.gbConsultation.Text = "Consultation des biens";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(601, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(477, 171);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vente du Bien";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(247, 107);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 26);
            this.textBox1.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(117, 111);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Prix de Vente";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(275, 41);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(112, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Non Vendu";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(117, 41);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(77, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Vendu";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // FormBiensImmobiliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 511);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbConsultation);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.gbPrix);
            this.Controls.Add(this.gbCaracteristiques);
            this.Controls.Add(this.gbTypeBien);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormBiensImmobiliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des biens immobiliers";
            this.Load += new System.EventHandler(this.FormBiensImmobiliers_Load);
            this.gbTypeBien.ResumeLayout(false);
            this.gbTypeBien.PerformLayout();
            this.gbCaracteristiques.ResumeLayout(false);
            this.gbCaracteristiques.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNbSalleEau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNbChambres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNbPieces)).EndInit();
            this.gbPrix.ResumeLayout(false);
            this.gbPrix.PerformLayout();
            this.gbConsultation.ResumeLayout(false);
            this.gbConsultation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTypeBien;
        private System.Windows.Forms.RadioButton rbAppart;
        private System.Windows.Forms.RadioButton rbMaison;
        private System.Windows.Forms.GroupBox gbCaracteristiques;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numNbSalleEau;
        private System.Windows.Forms.NumericUpDown numNbChambres;
        private System.Windows.Forms.NumericUpDown numNbPieces;
        private System.Windows.Forms.TextBox tbVille;
        private System.Windows.Forms.TextBox tbAdresse;
        private System.Windows.Forms.TextBox tbSurface;
        private System.Windows.Forms.GroupBox gbPrix;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.ComboBox cbListeBiens;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.GroupBox gbConsultation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox tbPrix;
    }
}

