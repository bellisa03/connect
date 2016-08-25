namespace Connect
{
    partial class Job
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
            this.labelEntreprise = new System.Windows.Forms.Label();
            this.labelJob = new System.Windows.Forms.Label();
            this.comboBoxEntreprise = new System.Windows.Forms.ComboBox();
            this.textBoxJobID = new System.Windows.Forms.TextBox();
            this.labelIntituleJob = new System.Windows.Forms.Label();
            this.labelChamps = new System.Windows.Forms.Label();
            this.textBoxIntituleJob = new System.Windows.Forms.TextBox();
            this.labelDescriptifJob = new System.Windows.Forms.Label();
            this.textBoxDescriptif = new System.Windows.Forms.TextBox();
            this.textBoxProfilJob = new System.Windows.Forms.TextBox();
            this.labelProfilJob = new System.Windows.Forms.Label();
            this.datePickerDebutJob = new System.Windows.Forms.DateTimePicker();
            this.datePickerFinJob = new System.Windows.Forms.DateTimePicker();
            this.labelFinJob = new System.Windows.Forms.Label();
            this.labelDebutJob = new System.Windows.Forms.Label();
            this.textBoxHoraireJob = new System.Windows.Forms.TextBox();
            this.labelHoraireJob = new System.Windows.Forms.Label();
            this.labelSalaireJob = new System.Windows.Forms.Label();
            this.labelEuros = new System.Windows.Forms.Label();
            this.radioButtonPermisNonJob = new System.Windows.Forms.RadioButton();
            this.radioButtonPermisOuiJob = new System.Windows.Forms.RadioButton();
            this.labelPermisJob = new System.Windows.Forms.Label();
            this.textBoxRmqJob = new System.Windows.Forms.TextBox();
            this.labelRmqJob = new System.Windows.Forms.Label();
            this.datePickerPublicationJob = new System.Windows.Forms.DateTimePicker();
            this.labelDatePublication = new System.Windows.Forms.Label();
            this.labelEtudiantJob = new System.Windows.Forms.Label();
            this.buttonRechercheEtudiant = new System.Windows.Forms.Button();
            this.buttonDeleteJob = new System.Windows.Forms.Button();
            this.buttonValiderJob = new System.Windows.Forms.Button();
            this.buttonFermerJob = new System.Windows.Forms.Button();
            this.textBoxEtudiantJob = new System.Windows.Forms.TextBox();
            this.numericUpDownSalaireJob = new System.Windows.Forms.NumericUpDown();
            this.buttonEffacerSelectionEtudiant = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalaireJob)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEntreprise
            // 
            this.labelEntreprise.AutoSize = true;
            this.labelEntreprise.Location = new System.Drawing.Point(12, 15);
            this.labelEntreprise.Name = "labelEntreprise";
            this.labelEntreprise.Size = new System.Drawing.Size(54, 13);
            this.labelEntreprise.TabIndex = 0;
            this.labelEntreprise.Text = "Entreprise";
            // 
            // labelJob
            // 
            this.labelJob.AutoSize = true;
            this.labelJob.Location = new System.Drawing.Point(265, 15);
            this.labelJob.Name = "labelJob";
            this.labelJob.Size = new System.Drawing.Size(38, 13);
            this.labelJob.TabIndex = 1;
            this.labelJob.Text = "Job ID";
            // 
            // comboBoxEntreprise
            // 
            this.comboBoxEntreprise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxEntreprise.FormattingEnabled = true;
            this.comboBoxEntreprise.Location = new System.Drawing.Point(101, 12);
            this.comboBoxEntreprise.Name = "comboBoxEntreprise";
            this.comboBoxEntreprise.Size = new System.Drawing.Size(142, 21);
            this.comboBoxEntreprise.TabIndex = 2;
            // 
            // textBoxJobID
            // 
            this.textBoxJobID.Enabled = false;
            this.textBoxJobID.Location = new System.Drawing.Point(309, 12);
            this.textBoxJobID.Name = "textBoxJobID";
            this.textBoxJobID.ReadOnly = true;
            this.textBoxJobID.Size = new System.Drawing.Size(100, 20);
            this.textBoxJobID.TabIndex = 3;
            this.textBoxJobID.TabStop = false;
            // 
            // labelIntituleJob
            // 
            this.labelIntituleJob.AutoSize = true;
            this.labelIntituleJob.Location = new System.Drawing.Point(12, 49);
            this.labelIntituleJob.Name = "labelIntituleJob";
            this.labelIntituleJob.Size = new System.Drawing.Size(42, 13);
            this.labelIntituleJob.TabIndex = 4;
            this.labelIntituleJob.Text = "Intitulé*";
            // 
            // labelChamps
            // 
            this.labelChamps.AutoSize = true;
            this.labelChamps.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChamps.Location = new System.Drawing.Point(12, 676);
            this.labelChamps.Name = "labelChamps";
            this.labelChamps.Size = new System.Drawing.Size(105, 13);
            this.labelChamps.TabIndex = 29;
            this.labelChamps.Text = "*Champs obligatoires";
            // 
            // textBoxIntituleJob
            // 
            this.textBoxIntituleJob.Location = new System.Drawing.Point(101, 46);
            this.textBoxIntituleJob.Name = "textBoxIntituleJob";
            this.textBoxIntituleJob.Size = new System.Drawing.Size(186, 20);
            this.textBoxIntituleJob.TabIndex = 4;
            // 
            // labelDescriptifJob
            // 
            this.labelDescriptifJob.AutoSize = true;
            this.labelDescriptifJob.Location = new System.Drawing.Point(12, 82);
            this.labelDescriptifJob.Name = "labelDescriptifJob";
            this.labelDescriptifJob.Size = new System.Drawing.Size(51, 13);
            this.labelDescriptifJob.TabIndex = 31;
            this.labelDescriptifJob.Text = "Descriptif";
            // 
            // textBoxDescriptif
            // 
            this.textBoxDescriptif.Location = new System.Drawing.Point(101, 82);
            this.textBoxDescriptif.Multiline = true;
            this.textBoxDescriptif.Name = "textBoxDescriptif";
            this.textBoxDescriptif.Size = new System.Drawing.Size(308, 75);
            this.textBoxDescriptif.TabIndex = 5;
            // 
            // textBoxProfilJob
            // 
            this.textBoxProfilJob.Location = new System.Drawing.Point(101, 173);
            this.textBoxProfilJob.Multiline = true;
            this.textBoxProfilJob.Name = "textBoxProfilJob";
            this.textBoxProfilJob.Size = new System.Drawing.Size(308, 75);
            this.textBoxProfilJob.TabIndex = 6;
            // 
            // labelProfilJob
            // 
            this.labelProfilJob.AutoSize = true;
            this.labelProfilJob.Location = new System.Drawing.Point(12, 173);
            this.labelProfilJob.Name = "labelProfilJob";
            this.labelProfilJob.Size = new System.Drawing.Size(61, 13);
            this.labelProfilJob.TabIndex = 33;
            this.labelProfilJob.Text = "Profil requis";
            // 
            // datePickerDebutJob
            // 
            this.datePickerDebutJob.Location = new System.Drawing.Point(185, 265);
            this.datePickerDebutJob.Name = "datePickerDebutJob";
            this.datePickerDebutJob.Size = new System.Drawing.Size(200, 20);
            this.datePickerDebutJob.TabIndex = 7;
            // 
            // datePickerFinJob
            // 
            this.datePickerFinJob.Location = new System.Drawing.Point(185, 300);
            this.datePickerFinJob.Name = "datePickerFinJob";
            this.datePickerFinJob.Size = new System.Drawing.Size(200, 20);
            this.datePickerFinJob.TabIndex = 8;
            // 
            // labelFinJob
            // 
            this.labelFinJob.AutoSize = true;
            this.labelFinJob.Location = new System.Drawing.Point(115, 306);
            this.labelFinJob.Name = "labelFinJob";
            this.labelFinJob.Size = new System.Drawing.Size(21, 13);
            this.labelFinJob.TabIndex = 37;
            this.labelFinJob.Text = "Fin";
            // 
            // labelDebutJob
            // 
            this.labelDebutJob.AutoSize = true;
            this.labelDebutJob.Location = new System.Drawing.Point(115, 271);
            this.labelDebutJob.Name = "labelDebutJob";
            this.labelDebutJob.Size = new System.Drawing.Size(36, 13);
            this.labelDebutJob.TabIndex = 38;
            this.labelDebutJob.Text = "Début";
            // 
            // textBoxHoraireJob
            // 
            this.textBoxHoraireJob.Location = new System.Drawing.Point(101, 337);
            this.textBoxHoraireJob.Multiline = true;
            this.textBoxHoraireJob.Name = "textBoxHoraireJob";
            this.textBoxHoraireJob.Size = new System.Drawing.Size(308, 75);
            this.textBoxHoraireJob.TabIndex = 9;
            // 
            // labelHoraireJob
            // 
            this.labelHoraireJob.AutoSize = true;
            this.labelHoraireJob.Location = new System.Drawing.Point(15, 337);
            this.labelHoraireJob.Name = "labelHoraireJob";
            this.labelHoraireJob.Size = new System.Drawing.Size(41, 13);
            this.labelHoraireJob.TabIndex = 39;
            this.labelHoraireJob.Text = "Horaire";
            // 
            // labelSalaireJob
            // 
            this.labelSalaireJob.AutoSize = true;
            this.labelSalaireJob.Location = new System.Drawing.Point(15, 432);
            this.labelSalaireJob.Name = "labelSalaireJob";
            this.labelSalaireJob.Size = new System.Drawing.Size(73, 13);
            this.labelSalaireJob.TabIndex = 41;
            this.labelSalaireJob.Text = "Rémunération";
            // 
            // labelEuros
            // 
            this.labelEuros.AutoSize = true;
            this.labelEuros.Location = new System.Drawing.Point(199, 432);
            this.labelEuros.Name = "labelEuros";
            this.labelEuros.Size = new System.Drawing.Size(34, 13);
            this.labelEuros.TabIndex = 42;
            this.labelEuros.Text = "Euros";
            // 
            // radioButtonPermisNonJob
            // 
            this.radioButtonPermisNonJob.AutoSize = true;
            this.radioButtonPermisNonJob.Location = new System.Drawing.Point(171, 460);
            this.radioButtonPermisNonJob.Name = "radioButtonPermisNonJob";
            this.radioButtonPermisNonJob.Size = new System.Drawing.Size(45, 17);
            this.radioButtonPermisNonJob.TabIndex = 12;
            this.radioButtonPermisNonJob.TabStop = true;
            this.radioButtonPermisNonJob.Text = "Non";
            this.radioButtonPermisNonJob.UseVisualStyleBackColor = true;
            // 
            // radioButtonPermisOuiJob
            // 
            this.radioButtonPermisOuiJob.AutoSize = true;
            this.radioButtonPermisOuiJob.Location = new System.Drawing.Point(101, 460);
            this.radioButtonPermisOuiJob.Name = "radioButtonPermisOuiJob";
            this.radioButtonPermisOuiJob.Size = new System.Drawing.Size(41, 17);
            this.radioButtonPermisOuiJob.TabIndex = 11;
            this.radioButtonPermisOuiJob.TabStop = true;
            this.radioButtonPermisOuiJob.Text = "Oui";
            this.radioButtonPermisOuiJob.UseVisualStyleBackColor = true;
            // 
            // labelPermisJob
            // 
            this.labelPermisJob.AutoSize = true;
            this.labelPermisJob.Location = new System.Drawing.Point(15, 460);
            this.labelPermisJob.Name = "labelPermisJob";
            this.labelPermisJob.Size = new System.Drawing.Size(73, 13);
            this.labelPermisJob.TabIndex = 44;
            this.labelPermisJob.Text = "Permis voiture";
            // 
            // textBoxRmqJob
            // 
            this.textBoxRmqJob.Location = new System.Drawing.Point(101, 492);
            this.textBoxRmqJob.Multiline = true;
            this.textBoxRmqJob.Name = "textBoxRmqJob";
            this.textBoxRmqJob.Size = new System.Drawing.Size(308, 75);
            this.textBoxRmqJob.TabIndex = 13;
            // 
            // labelRmqJob
            // 
            this.labelRmqJob.AutoSize = true;
            this.labelRmqJob.Location = new System.Drawing.Point(15, 492);
            this.labelRmqJob.Name = "labelRmqJob";
            this.labelRmqJob.Size = new System.Drawing.Size(61, 13);
            this.labelRmqJob.TabIndex = 47;
            this.labelRmqJob.Text = "Remarques";
            // 
            // datePickerPublicationJob
            // 
            this.datePickerPublicationJob.Enabled = false;
            this.datePickerPublicationJob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerPublicationJob.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.datePickerPublicationJob.Location = new System.Drawing.Point(323, 616);
            this.datePickerPublicationJob.Name = "datePickerPublicationJob";
            this.datePickerPublicationJob.Size = new System.Drawing.Size(86, 20);
            this.datePickerPublicationJob.TabIndex = 14;
            // 
            // labelDatePublication
            // 
            this.labelDatePublication.AutoSize = true;
            this.labelDatePublication.Location = new System.Drawing.Point(256, 619);
            this.labelDatePublication.Name = "labelDatePublication";
            this.labelDatePublication.Size = new System.Drawing.Size(47, 13);
            this.labelDatePublication.TabIndex = 49;
            this.labelDatePublication.Text = "Publié le";
            // 
            // labelEtudiantJob
            // 
            this.labelEtudiantJob.AutoSize = true;
            this.labelEtudiantJob.Location = new System.Drawing.Point(15, 586);
            this.labelEtudiantJob.Name = "labelEtudiantJob";
            this.labelEtudiantJob.Size = new System.Drawing.Size(46, 13);
            this.labelEtudiantJob.TabIndex = 51;
            this.labelEtudiantJob.Text = "Etudiant";
            // 
            // buttonRechercheEtudiant
            // 
            this.buttonRechercheEtudiant.Location = new System.Drawing.Point(259, 582);
            this.buttonRechercheEtudiant.Name = "buttonRechercheEtudiant";
            this.buttonRechercheEtudiant.Size = new System.Drawing.Size(150, 23);
            this.buttonRechercheEtudiant.TabIndex = 14;
            this.buttonRechercheEtudiant.Text = "Etudiant(s) Disponible(s)**";
            this.buttonRechercheEtudiant.UseVisualStyleBackColor = true;
            this.buttonRechercheEtudiant.Click += new System.EventHandler(this.buttonRechercheEtudiant_Click);
            // 
            // buttonDeleteJob
            // 
            this.buttonDeleteJob.Location = new System.Drawing.Point(244, 647);
            this.buttonDeleteJob.Name = "buttonDeleteJob";
            this.buttonDeleteJob.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteJob.TabIndex = 17;
            this.buttonDeleteJob.Text = "Supprimer";
            this.buttonDeleteJob.UseVisualStyleBackColor = true;
            this.buttonDeleteJob.Click += new System.EventHandler(this.buttonDeleteJob_Click);
            // 
            // buttonValiderJob
            // 
            this.buttonValiderJob.Location = new System.Drawing.Point(153, 647);
            this.buttonValiderJob.Name = "buttonValiderJob";
            this.buttonValiderJob.Size = new System.Drawing.Size(75, 23);
            this.buttonValiderJob.TabIndex = 16;
            this.buttonValiderJob.Text = "Ajouter";
            this.buttonValiderJob.UseVisualStyleBackColor = true;
            this.buttonValiderJob.Click += new System.EventHandler(this.buttonValiderJob_Click);
            // 
            // buttonFermerJob
            // 
            this.buttonFermerJob.Location = new System.Drawing.Point(334, 647);
            this.buttonFermerJob.Name = "buttonFermerJob";
            this.buttonFermerJob.Size = new System.Drawing.Size(75, 23);
            this.buttonFermerJob.TabIndex = 18;
            this.buttonFermerJob.Text = "Fermer";
            this.buttonFermerJob.UseVisualStyleBackColor = true;
            this.buttonFermerJob.Click += new System.EventHandler(this.buttonFermerJob_Click);
            // 
            // textBoxEtudiantJob
            // 
            this.textBoxEtudiantJob.Location = new System.Drawing.Point(101, 584);
            this.textBoxEtudiantJob.Name = "textBoxEtudiantJob";
            this.textBoxEtudiantJob.ReadOnly = true;
            this.textBoxEtudiantJob.Size = new System.Drawing.Size(127, 20);
            this.textBoxEtudiantJob.TabIndex = 52;
            this.textBoxEtudiantJob.TabStop = false;
            // 
            // numericUpDownSalaireJob
            // 
            this.numericUpDownSalaireJob.DecimalPlaces = 2;
            this.numericUpDownSalaireJob.Location = new System.Drawing.Point(108, 430);
            this.numericUpDownSalaireJob.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownSalaireJob.Name = "numericUpDownSalaireJob";
            this.numericUpDownSalaireJob.Size = new System.Drawing.Size(85, 20);
            this.numericUpDownSalaireJob.TabIndex = 10;
            // 
            // buttonEffacerSelectionEtudiant
            // 
            this.buttonEffacerSelectionEtudiant.Location = new System.Drawing.Point(101, 613);
            this.buttonEffacerSelectionEtudiant.Name = "buttonEffacerSelectionEtudiant";
            this.buttonEffacerSelectionEtudiant.Size = new System.Drawing.Size(127, 23);
            this.buttonEffacerSelectionEtudiant.TabIndex = 15;
            this.buttonEffacerSelectionEtudiant.Text = "Effacer Sélection";
            this.buttonEffacerSelectionEtudiant.UseVisualStyleBackColor = true;
            this.buttonEffacerSelectionEtudiant.Click += new System.EventHandler(this.buttonEffacerSelectionEtudiant_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 694);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "**Déclenche automatiquement une première sauvegarde des données du formulaire job" +
    "";
            // 
            // Job
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(441, 581);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEffacerSelectionEtudiant);
            this.Controls.Add(this.numericUpDownSalaireJob);
            this.Controls.Add(this.buttonFermerJob);
            this.Controls.Add(this.buttonDeleteJob);
            this.Controls.Add(this.buttonValiderJob);
            this.Controls.Add(this.buttonRechercheEtudiant);
            this.Controls.Add(this.textBoxEtudiantJob);
            this.Controls.Add(this.labelEtudiantJob);
            this.Controls.Add(this.datePickerPublicationJob);
            this.Controls.Add(this.labelDatePublication);
            this.Controls.Add(this.textBoxRmqJob);
            this.Controls.Add(this.labelRmqJob);
            this.Controls.Add(this.radioButtonPermisNonJob);
            this.Controls.Add(this.radioButtonPermisOuiJob);
            this.Controls.Add(this.labelPermisJob);
            this.Controls.Add(this.labelEuros);
            this.Controls.Add(this.labelSalaireJob);
            this.Controls.Add(this.textBoxHoraireJob);
            this.Controls.Add(this.labelHoraireJob);
            this.Controls.Add(this.labelDebutJob);
            this.Controls.Add(this.labelFinJob);
            this.Controls.Add(this.datePickerFinJob);
            this.Controls.Add(this.datePickerDebutJob);
            this.Controls.Add(this.textBoxProfilJob);
            this.Controls.Add(this.labelProfilJob);
            this.Controls.Add(this.textBoxDescriptif);
            this.Controls.Add(this.labelDescriptifJob);
            this.Controls.Add(this.textBoxIntituleJob);
            this.Controls.Add(this.labelChamps);
            this.Controls.Add(this.labelIntituleJob);
            this.Controls.Add(this.textBoxJobID);
            this.Controls.Add(this.comboBoxEntreprise);
            this.Controls.Add(this.labelJob);
            this.Controls.Add(this.labelEntreprise);
            this.Name = "Job";
            this.Text = "Formulaire Job";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalaireJob)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEntreprise;
        private System.Windows.Forms.Label labelJob;
        private System.Windows.Forms.ComboBox comboBoxEntreprise;
        private System.Windows.Forms.TextBox textBoxJobID;
        private System.Windows.Forms.Label labelIntituleJob;
        private System.Windows.Forms.Label labelChamps;
        private System.Windows.Forms.TextBox textBoxIntituleJob;
        private System.Windows.Forms.Label labelDescriptifJob;
        private System.Windows.Forms.TextBox textBoxDescriptif;
        private System.Windows.Forms.TextBox textBoxProfilJob;
        private System.Windows.Forms.Label labelProfilJob;
        private System.Windows.Forms.DateTimePicker datePickerDebutJob;
        private System.Windows.Forms.DateTimePicker datePickerFinJob;
        private System.Windows.Forms.Label labelFinJob;
        private System.Windows.Forms.Label labelDebutJob;
        private System.Windows.Forms.TextBox textBoxHoraireJob;
        private System.Windows.Forms.Label labelHoraireJob;
        private System.Windows.Forms.Label labelSalaireJob;
        private System.Windows.Forms.Label labelEuros;
        private System.Windows.Forms.RadioButton radioButtonPermisNonJob;
        private System.Windows.Forms.RadioButton radioButtonPermisOuiJob;
        private System.Windows.Forms.Label labelPermisJob;
        private System.Windows.Forms.TextBox textBoxRmqJob;
        private System.Windows.Forms.Label labelRmqJob;
        private System.Windows.Forms.DateTimePicker datePickerPublicationJob;
        private System.Windows.Forms.Label labelDatePublication;
        private System.Windows.Forms.Label labelEtudiantJob;
        private System.Windows.Forms.Button buttonRechercheEtudiant;
        private System.Windows.Forms.Button buttonDeleteJob;
        private System.Windows.Forms.Button buttonValiderJob;
        private System.Windows.Forms.Button buttonFermerJob;
        private System.Windows.Forms.TextBox textBoxEtudiantJob;
        private System.Windows.Forms.NumericUpDown numericUpDownSalaireJob;
        private System.Windows.Forms.Button buttonEffacerSelectionEtudiant;
        private System.Windows.Forms.Label label1;
    }
}