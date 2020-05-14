namespace gestionContact
{
    partial class gestionContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gestionContact));
            this.picContact = new System.Windows.Forms.PictureBox();
            this.lstContact = new System.Windows.Forms.ListBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnDeleteContact = new System.Windows.Forms.Button();
            this.grpAjoutContact = new System.Windows.Forms.GroupBox();
            this.btnCancelContact = new System.Windows.Forms.Button();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.rbProfessionnel = new System.Windows.Forms.RadioButton();
            this.rbParticulier = new System.Windows.Forms.RadioButton();
            this.grpRecherche = new System.Windows.Forms.GroupBox();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.lblRecherche = new System.Windows.Forms.Label();
            this.lblPhoto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picContact)).BeginInit();
            this.grpAjoutContact.SuspendLayout();
            this.grpRecherche.SuspendLayout();
            this.SuspendLayout();
            // 
            // picContact
            // 
            this.picContact.Image = global::gestionContact.Properties.Resources.vide;
            this.picContact.Location = new System.Drawing.Point(13, 13);
            this.picContact.Name = "picContact";
            this.picContact.Size = new System.Drawing.Size(170, 200);
            this.picContact.TabIndex = 0;
            this.picContact.TabStop = false;
            this.picContact.Click += new System.EventHandler(this.picContact_Click);
            // 
            // lstContact
            // 
            this.lstContact.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstContact.FormattingEnabled = true;
            this.lstContact.Location = new System.Drawing.Point(274, 13);
            this.lstContact.Name = "lstContact";
            this.lstContact.Size = new System.Drawing.Size(344, 459);
            this.lstContact.Sorted = true;
            this.lstContact.TabIndex = 1;
            this.lstContact.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstContact_DrawItem_1);
            this.lstContact.SelectedIndexChanged += new System.EventHandler(this.lstContact_SelectedIndexChanged);
            // 
            // btnModifier
            // 
            this.btnModifier.Image = ((System.Drawing.Image)(resources.GetObject("btnModifier.Image")));
            this.btnModifier.Location = new System.Drawing.Point(198, 13);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(60, 60);
            this.btnModifier.TabIndex = 2;
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnDeleteContact
            // 
            this.btnDeleteContact.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteContact.Image")));
            this.btnDeleteContact.Location = new System.Drawing.Point(198, 88);
            this.btnDeleteContact.Name = "btnDeleteContact";
            this.btnDeleteContact.Size = new System.Drawing.Size(60, 60);
            this.btnDeleteContact.TabIndex = 3;
            this.btnDeleteContact.UseVisualStyleBackColor = true;
            this.btnDeleteContact.Click += new System.EventHandler(this.btnDeleteContact_Click);
            // 
            // grpAjoutContact
            // 
            this.grpAjoutContact.Controls.Add(this.btnCancelContact);
            this.grpAjoutContact.Controls.Add(this.txtTel);
            this.grpAjoutContact.Controls.Add(this.lblTel);
            this.grpAjoutContact.Controls.Add(this.txtPrenom);
            this.grpAjoutContact.Controls.Add(this.lblPrenom);
            this.grpAjoutContact.Controls.Add(this.btnAddContact);
            this.grpAjoutContact.Controls.Add(this.txtNom);
            this.grpAjoutContact.Controls.Add(this.lblNom);
            this.grpAjoutContact.Controls.Add(this.rbProfessionnel);
            this.grpAjoutContact.Controls.Add(this.rbParticulier);
            this.grpAjoutContact.Location = new System.Drawing.Point(13, 230);
            this.grpAjoutContact.Name = "grpAjoutContact";
            this.grpAjoutContact.Size = new System.Drawing.Size(255, 158);
            this.grpAjoutContact.TabIndex = 4;
            this.grpAjoutContact.TabStop = false;
            this.grpAjoutContact.Text = "ajout contact";
            // 
            // btnCancelContact
            // 
            this.btnCancelContact.Enabled = false;
            this.btnCancelContact.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelContact.Image")));
            this.btnCancelContact.Location = new System.Drawing.Point(196, 101);
            this.btnCancelContact.Name = "btnCancelContact";
            this.btnCancelContact.Size = new System.Drawing.Size(45, 45);
            this.btnCancelContact.TabIndex = 9;
            this.btnCancelContact.UseVisualStyleBackColor = true;
            this.btnCancelContact.Click += new System.EventHandler(this.btnCancelContact_Click);
            // 
            // txtTel
            // 
            this.txtTel.Enabled = false;
            this.txtTel.Location = new System.Drawing.Point(47, 114);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(135, 20);
            this.txtTel.TabIndex = 8;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(6, 117);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(24, 13);
            this.lblTel.TabIndex = 7;
            this.lblTel.Text = "tel :";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Enabled = false;
            this.txtPrenom.Location = new System.Drawing.Point(47, 81);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(135, 20);
            this.txtPrenom.TabIndex = 6;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(6, 84);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(42, 13);
            this.lblPrenom.TabIndex = 5;
            this.lblPrenom.Text = "prénom";
            // 
            // btnAddContact
            // 
            this.btnAddContact.Enabled = false;
            this.btnAddContact.Image = ((System.Drawing.Image)(resources.GetObject("btnAddContact.Image")));
            this.btnAddContact.Location = new System.Drawing.Point(196, 35);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(45, 45);
            this.btnAddContact.TabIndex = 4;
            this.btnAddContact.UseVisualStyleBackColor = true;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // txtNom
            // 
            this.txtNom.Enabled = false;
            this.txtNom.Location = new System.Drawing.Point(47, 48);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(135, 20);
            this.txtNom.TabIndex = 3;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(6, 51);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(33, 13);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "nom :";
            // 
            // rbProfessionnel
            // 
            this.rbProfessionnel.AutoSize = true;
            this.rbProfessionnel.ForeColor = System.Drawing.Color.DarkOrchid;
            this.rbProfessionnel.Location = new System.Drawing.Point(99, 20);
            this.rbProfessionnel.Name = "rbProfessionnel";
            this.rbProfessionnel.Size = new System.Drawing.Size(87, 17);
            this.rbProfessionnel.TabIndex = 1;
            this.rbProfessionnel.TabStop = true;
            this.rbProfessionnel.Text = "professionnel";
            this.rbProfessionnel.UseVisualStyleBackColor = true;
            this.rbProfessionnel.CheckedChanged += new System.EventHandler(this.rbProfessionnel_CheckedChanged);
            // 
            // rbParticulier
            // 
            this.rbParticulier.AutoSize = true;
            this.rbParticulier.ForeColor = System.Drawing.Color.ForestGreen;
            this.rbParticulier.Location = new System.Drawing.Point(7, 20);
            this.rbParticulier.Name = "rbParticulier";
            this.rbParticulier.Size = new System.Drawing.Size(70, 17);
            this.rbParticulier.TabIndex = 0;
            this.rbParticulier.TabStop = true;
            this.rbParticulier.Text = "particulier";
            this.rbParticulier.UseVisualStyleBackColor = true;
            this.rbParticulier.CheckedChanged += new System.EventHandler(this.rbParticulier_CheckedChanged);
            // 
            // grpRecherche
            // 
            this.grpRecherche.Controls.Add(this.btnRecherche);
            this.grpRecherche.Controls.Add(this.txtRecherche);
            this.grpRecherche.Controls.Add(this.lblRecherche);
            this.grpRecherche.Location = new System.Drawing.Point(13, 404);
            this.grpRecherche.Name = "grpRecherche";
            this.grpRecherche.Size = new System.Drawing.Size(255, 72);
            this.grpRecherche.TabIndex = 5;
            this.grpRecherche.TabStop = false;
            this.grpRecherche.Text = "recherche";
            // 
            // btnRecherche
            // 
            this.btnRecherche.Image = ((System.Drawing.Image)(resources.GetObject("btnRecherche.Image")));
            this.btnRecherche.Location = new System.Drawing.Point(196, 20);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(45, 45);
            this.btnRecherche.TabIndex = 2;
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(47, 20);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(135, 20);
            this.txtRecherche.TabIndex = 1;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            // 
            // lblRecherche
            // 
            this.lblRecherche.AutoSize = true;
            this.lblRecherche.Location = new System.Drawing.Point(6, 23);
            this.lblRecherche.Name = "lblRecherche";
            this.lblRecherche.Size = new System.Drawing.Size(24, 13);
            this.lblRecherche.TabIndex = 0;
            this.lblRecherche.Text = "tel :";
            // 
            // lblPhoto
            // 
            this.lblPhoto.AutoSize = true;
            this.lblPhoto.Location = new System.Drawing.Point(34, 172);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(125, 26);
            this.lblPhoto.TabIndex = 6;
            this.lblPhoto.Text = "Cliquez pour sélectionner\r\n une photo";
            this.lblPhoto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPhoto.Visible = false;
            this.lblPhoto.Click += new System.EventHandler(this.lblPhoto_Click);
            // 
            // gestionContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 480);
            this.Controls.Add(this.lblPhoto);
            this.Controls.Add(this.grpRecherche);
            this.Controls.Add(this.grpAjoutContact);
            this.Controls.Add(this.btnDeleteContact);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.lstContact);
            this.Controls.Add(this.picContact);
            this.Name = "gestionContact";
            this.Text = "Gestionnaire de contact";
            this.Load += new System.EventHandler(this.gestionContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picContact)).EndInit();
            this.grpAjoutContact.ResumeLayout(false);
            this.grpAjoutContact.PerformLayout();
            this.grpRecherche.ResumeLayout(false);
            this.grpRecherche.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picContact;
        private System.Windows.Forms.ListBox lstContact;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnDeleteContact;
        private System.Windows.Forms.GroupBox grpAjoutContact;
        private System.Windows.Forms.Button btnCancelContact;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.RadioButton rbProfessionnel;
        private System.Windows.Forms.RadioButton rbParticulier;
        private System.Windows.Forms.GroupBox grpRecherche;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Label lblRecherche;
        private System.Windows.Forms.Label lblPhoto;
    }
}

