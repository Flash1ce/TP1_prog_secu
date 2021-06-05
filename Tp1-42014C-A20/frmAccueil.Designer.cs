namespace Tp1_42014C_A20
{
    partial class frmAccueil
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbDessin = new System.Windows.Forms.PictureBox();
            this.btnCouleurRemplissage = new System.Windows.Forms.Button();
            this.couleurRemplissage = new System.Windows.Forms.ColorDialog();
            this.couleurBordure = new System.Windows.Forms.ColorDialog();
            this.btnCouleurBordure = new System.Windows.Forms.Button();
            this.lblRemplissage = new System.Windows.Forms.Label();
            this.lblBordure = new System.Windows.Forms.Label();
            this.gbCouleur = new System.Windows.Forms.GroupBox();
            this.rbLigne = new System.Windows.Forms.RadioButton();
            this.gbFormes = new System.Windows.Forms.GroupBox();
            this.rbEllipse = new System.Windows.Forms.RadioButton();
            this.rbRectangle = new System.Windows.Forms.RadioButton();
            this.gbTrait = new System.Windows.Forms.GroupBox();
            this.cmbTrait = new System.Windows.Forms.ComboBox();
            this.menuStripEdition = new System.Windows.Forms.MenuStrip();
            this.menuEdition = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAnnuler = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRepeter = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtLargeur = new System.Windows.Forms.TextBox();
            this.txtHauteur = new System.Windows.Forms.TextBox();
            this.lblHauteur = new System.Windows.Forms.Label();
            this.lblLargeur = new System.Windows.Forms.Label();
            this.btnCalculerPeinture = new System.Windows.Forms.Button();
            this.lstQuantitePeinture = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDessin)).BeginInit();
            this.gbCouleur.SuspendLayout();
            this.gbFormes.SuspendLayout();
            this.gbTrait.SuspendLayout();
            this.menuStripEdition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDessin
            // 
            this.pbDessin.BackColor = System.Drawing.Color.White;
            this.pbDessin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDessin.Location = new System.Drawing.Point(12, 166);
            this.pbDessin.Name = "pbDessin";
            this.pbDessin.Size = new System.Drawing.Size(600, 600);
            this.pbDessin.TabIndex = 0;
            this.pbDessin.TabStop = false;
            this.pbDessin.Paint += new System.Windows.Forms.PaintEventHandler(this.pbDessin_Paint);
            this.pbDessin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbDessin_MouseDown);
            this.pbDessin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbDessin_MouseUp);
            // 
            // btnCouleurRemplissage
            // 
            this.btnCouleurRemplissage.Location = new System.Drawing.Point(15, 45);
            this.btnCouleurRemplissage.Name = "btnCouleurRemplissage";
            this.btnCouleurRemplissage.Size = new System.Drawing.Size(93, 70);
            this.btnCouleurRemplissage.TabIndex = 1;
            this.btnCouleurRemplissage.UseVisualStyleBackColor = true;
            this.btnCouleurRemplissage.Click += new System.EventHandler(this.btnCouleur_Click);
            // 
            // btnCouleurBordure
            // 
            this.btnCouleurBordure.Location = new System.Drawing.Point(114, 45);
            this.btnCouleurBordure.Name = "btnCouleurBordure";
            this.btnCouleurBordure.Size = new System.Drawing.Size(93, 70);
            this.btnCouleurBordure.TabIndex = 1;
            this.btnCouleurBordure.UseVisualStyleBackColor = true;
            this.btnCouleurBordure.Click += new System.EventHandler(this.btnCouleurBordure_Click);
            // 
            // lblRemplissage
            // 
            this.lblRemplissage.AutoSize = true;
            this.lblRemplissage.Location = new System.Drawing.Point(15, 22);
            this.lblRemplissage.Name = "lblRemplissage";
            this.lblRemplissage.Size = new System.Drawing.Size(93, 20);
            this.lblRemplissage.TabIndex = 2;
            this.lblRemplissage.Text = "Remplissage";
            // 
            // lblBordure
            // 
            this.lblBordure.AutoSize = true;
            this.lblBordure.Location = new System.Drawing.Point(125, 22);
            this.lblBordure.Name = "lblBordure";
            this.lblBordure.Size = new System.Drawing.Size(62, 20);
            this.lblBordure.TabIndex = 3;
            this.lblBordure.Text = "Bordure";
            // 
            // gbCouleur
            // 
            this.gbCouleur.Controls.Add(this.btnCouleurRemplissage);
            this.gbCouleur.Controls.Add(this.btnCouleurBordure);
            this.gbCouleur.Controls.Add(this.lblBordure);
            this.gbCouleur.Controls.Add(this.lblRemplissage);
            this.gbCouleur.Location = new System.Drawing.Point(12, 31);
            this.gbCouleur.Name = "gbCouleur";
            this.gbCouleur.Size = new System.Drawing.Size(224, 129);
            this.gbCouleur.TabIndex = 5;
            this.gbCouleur.TabStop = false;
            this.gbCouleur.Text = "Couleurs";
            // 
            // rbLigne
            // 
            this.rbLigne.AutoSize = true;
            this.rbLigne.Location = new System.Drawing.Point(21, 26);
            this.rbLigne.Name = "rbLigne";
            this.rbLigne.Size = new System.Drawing.Size(66, 24);
            this.rbLigne.TabIndex = 4;
            this.rbLigne.TabStop = true;
            this.rbLigne.Text = "Ligne";
            this.rbLigne.UseVisualStyleBackColor = true;
            // 
            // gbFormes
            // 
            this.gbFormes.Controls.Add(this.rbEllipse);
            this.gbFormes.Controls.Add(this.rbRectangle);
            this.gbFormes.Controls.Add(this.rbLigne);
            this.gbFormes.Location = new System.Drawing.Point(242, 35);
            this.gbFormes.Name = "gbFormes";
            this.gbFormes.Size = new System.Drawing.Size(146, 125);
            this.gbFormes.TabIndex = 6;
            this.gbFormes.TabStop = false;
            this.gbFormes.Text = "Formes";
            // 
            // rbEllipse
            // 
            this.rbEllipse.AutoSize = true;
            this.rbEllipse.Location = new System.Drawing.Point(21, 86);
            this.rbEllipse.Name = "rbEllipse";
            this.rbEllipse.Size = new System.Drawing.Size(73, 24);
            this.rbEllipse.TabIndex = 4;
            this.rbEllipse.TabStop = true;
            this.rbEllipse.Text = "Ellipse";
            this.rbEllipse.UseVisualStyleBackColor = true;
            // 
            // rbRectangle
            // 
            this.rbRectangle.AutoSize = true;
            this.rbRectangle.Location = new System.Drawing.Point(21, 56);
            this.rbRectangle.Name = "rbRectangle";
            this.rbRectangle.Size = new System.Drawing.Size(96, 24);
            this.rbRectangle.TabIndex = 4;
            this.rbRectangle.TabStop = true;
            this.rbRectangle.Text = "Rectangle";
            this.rbRectangle.UseVisualStyleBackColor = true;
            // 
            // gbTrait
            // 
            this.gbTrait.Controls.Add(this.cmbTrait);
            this.gbTrait.Location = new System.Drawing.Point(394, 35);
            this.gbTrait.Name = "gbTrait";
            this.gbTrait.Size = new System.Drawing.Size(146, 80);
            this.gbTrait.TabIndex = 6;
            this.gbTrait.TabStop = false;
            this.gbTrait.Text = "Trait";
            // 
            // cmbTrait
            // 
            this.cmbTrait.FormattingEnabled = true;
            this.cmbTrait.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbTrait.Location = new System.Drawing.Point(6, 26);
            this.cmbTrait.Name = "cmbTrait";
            this.cmbTrait.Size = new System.Drawing.Size(134, 28);
            this.cmbTrait.TabIndex = 0;
            this.cmbTrait.Text = "1";
            // 
            // menuStripEdition
            // 
            this.menuStripEdition.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripEdition.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEdition});
            this.menuStripEdition.Location = new System.Drawing.Point(0, 0);
            this.menuStripEdition.Name = "menuStripEdition";
            this.menuStripEdition.Size = new System.Drawing.Size(930, 28);
            this.menuStripEdition.TabIndex = 7;
            this.menuStripEdition.Text = "menuStrip1";
            // 
            // menuEdition
            // 
            this.menuEdition.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAnnuler,
            this.menuRepeter});
            this.menuEdition.Name = "menuEdition";
            this.menuEdition.Size = new System.Drawing.Size(70, 24);
            this.menuEdition.Text = "Édition";
            // 
            // menuAnnuler
            // 
            this.menuAnnuler.Name = "menuAnnuler";
            this.menuAnnuler.Size = new System.Drawing.Size(144, 26);
            this.menuAnnuler.Text = "Annuler";
            this.menuAnnuler.Click += new System.EventHandler(this.menuAnnuler_Click);
            // 
            // menuRepeter
            // 
            this.menuRepeter.Name = "menuRepeter";
            this.menuRepeter.Size = new System.Drawing.Size(144, 26);
            this.menuRepeter.Text = "Répéter";
            this.menuRepeter.Click += new System.EventHandler(this.menuRepeter_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // txtLargeur
            // 
            this.txtLargeur.Location = new System.Drawing.Point(571, 62);
            this.txtLargeur.Name = "txtLargeur";
            this.txtLargeur.Size = new System.Drawing.Size(142, 27);
            this.txtLargeur.TabIndex = 8;
            this.txtLargeur.Text = "0";
            // 
            // txtHauteur
            // 
            this.txtHauteur.Location = new System.Drawing.Point(571, 121);
            this.txtHauteur.Name = "txtHauteur";
            this.txtHauteur.Size = new System.Drawing.Size(142, 27);
            this.txtHauteur.TabIndex = 8;
            this.txtHauteur.Text = "0";
            // 
            // lblHauteur
            // 
            this.lblHauteur.AutoSize = true;
            this.lblHauteur.Location = new System.Drawing.Point(571, 98);
            this.lblHauteur.Name = "lblHauteur";
            this.lblHauteur.Size = new System.Drawing.Size(103, 20);
            this.lblHauteur.TabIndex = 9;
            this.lblHauteur.Text = "Hauteur réelle";
            // 
            // lblLargeur
            // 
            this.lblLargeur.AutoSize = true;
            this.lblLargeur.Location = new System.Drawing.Point(571, 41);
            this.lblLargeur.Name = "lblLargeur";
            this.lblLargeur.Size = new System.Drawing.Size(100, 20);
            this.lblLargeur.TabIndex = 9;
            this.lblLargeur.Text = "Largeur réelle";
            // 
            // btnCalculerPeinture
            // 
            this.btnCalculerPeinture.Location = new System.Drawing.Point(759, 80);
            this.btnCalculerPeinture.Name = "btnCalculerPeinture";
            this.btnCalculerPeinture.Size = new System.Drawing.Size(100, 47);
            this.btnCalculerPeinture.TabIndex = 10;
            this.btnCalculerPeinture.Text = "Calculer ";
            this.btnCalculerPeinture.UseVisualStyleBackColor = true;
            this.btnCalculerPeinture.Click += new System.EventHandler(this.btnCalculerPeinture_Click);
            // 
            // lstQuantitePeinture
            // 
            this.lstQuantitePeinture.FormattingEnabled = true;
            this.lstQuantitePeinture.ItemHeight = 20;
            this.lstQuantitePeinture.Location = new System.Drawing.Point(642, 166);
            this.lstQuantitePeinture.Name = "lstQuantitePeinture";
            this.lstQuantitePeinture.Size = new System.Drawing.Size(264, 604);
            this.lstQuantitePeinture.TabIndex = 11;
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 779);
            this.Controls.Add(this.lstQuantitePeinture);
            this.Controls.Add(this.btnCalculerPeinture);
            this.Controls.Add(this.lblLargeur);
            this.Controls.Add(this.lblHauteur);
            this.Controls.Add(this.txtHauteur);
            this.Controls.Add(this.txtLargeur);
            this.Controls.Add(this.gbTrait);
            this.Controls.Add(this.gbFormes);
            this.Controls.Add(this.gbCouleur);
            this.Controls.Add(this.pbDessin);
            this.Controls.Add(this.menuStripEdition);
            this.MainMenuStrip = this.menuStripEdition;
            this.Name = "frmAccueil";
            this.Text = "Art guerilla";
            ((System.ComponentModel.ISupportInitialize)(this.pbDessin)).EndInit();
            this.gbCouleur.ResumeLayout(false);
            this.gbCouleur.PerformLayout();
            this.gbFormes.ResumeLayout(false);
            this.gbFormes.PerformLayout();
            this.gbTrait.ResumeLayout(false);
            this.menuStripEdition.ResumeLayout(false);
            this.menuStripEdition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDessin;
        private System.Windows.Forms.Button btnCouleurRemplissage;
        private System.Windows.Forms.ColorDialog couleurRemplissage;
        private System.Windows.Forms.ColorDialog couleurBordure;
        private System.Windows.Forms.Button btnCouleurBordure;
        private System.Windows.Forms.Label lblRemplissage;
        private System.Windows.Forms.Label lblBordure;
        private System.Windows.Forms.GroupBox gbCouleur;
        private System.Windows.Forms.RadioButton rbLigne;
        private System.Windows.Forms.GroupBox gbFormes;
        private System.Windows.Forms.RadioButton rbRectangle;
        private System.Windows.Forms.RadioButton rbEllipse;
        private System.Windows.Forms.GroupBox gbTrait;
        private System.Windows.Forms.ComboBox cmbTrait;
        private System.Windows.Forms.MenuStrip menuStripEdition;
        private System.Windows.Forms.ToolStripMenuItem menuEdition;
        private System.Windows.Forms.ToolStripMenuItem menuAnnuler;
        private System.Windows.Forms.ToolStripMenuItem menuRepeter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ListBox lstQuantitePeinture;
        private System.Windows.Forms.Button btnCalculerPeinture;
        private System.Windows.Forms.Label lblLargeur;
        private System.Windows.Forms.Label lblHauteur;
        private System.Windows.Forms.TextBox txtHauteur;
        private System.Windows.Forms.TextBox txtLargeur;
    }
}

