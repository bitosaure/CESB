namespace CESB
{
    partial class AdmSuppressionUtilisateur
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherFactureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesUtilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créationDesUtilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppressionDesUtilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesProduitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créationDeProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppressionDeProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesComptesDuMagasinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.listUtil = new System.Windows.Forms.ListBox();
            this.btValider = new System.Windows.Forms.Button();
            this.gbSup = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.gbSup.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.rechercheToolStripMenuItem,
            this.gestionDesUtilisateursToolStripMenuItem,
            this.gestionDesProduitsToolStripMenuItem,
            this.gestionDesComptesDuMagasinToolStripMenuItem,
            this.statistiquesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(785, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // rechercheToolStripMenuItem
            // 
            this.rechercheToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rechercherProduitToolStripMenuItem,
            this.rechercherFactureToolStripMenuItem});
            this.rechercheToolStripMenuItem.Name = "rechercheToolStripMenuItem";
            this.rechercheToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.rechercheToolStripMenuItem.Text = "Recherche";
            // 
            // rechercherProduitToolStripMenuItem
            // 
            this.rechercherProduitToolStripMenuItem.Name = "rechercherProduitToolStripMenuItem";
            this.rechercherProduitToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.rechercherProduitToolStripMenuItem.Text = "Rechercher produit";
            // 
            // rechercherFactureToolStripMenuItem
            // 
            this.rechercherFactureToolStripMenuItem.Name = "rechercherFactureToolStripMenuItem";
            this.rechercherFactureToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.rechercherFactureToolStripMenuItem.Text = "Rechercher facture";
            // 
            // gestionDesUtilisateursToolStripMenuItem
            // 
            this.gestionDesUtilisateursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créationDesUtilisateursToolStripMenuItem,
            this.suppressionDesUtilisateursToolStripMenuItem});
            this.gestionDesUtilisateursToolStripMenuItem.Name = "gestionDesUtilisateursToolStripMenuItem";
            this.gestionDesUtilisateursToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.gestionDesUtilisateursToolStripMenuItem.Text = "Gestion des utilisateurs";
            // 
            // créationDesUtilisateursToolStripMenuItem
            // 
            this.créationDesUtilisateursToolStripMenuItem.Name = "créationDesUtilisateursToolStripMenuItem";
            this.créationDesUtilisateursToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.créationDesUtilisateursToolStripMenuItem.Text = "Création des utilisateurs";
            // 
            // suppressionDesUtilisateursToolStripMenuItem
            // 
            this.suppressionDesUtilisateursToolStripMenuItem.Enabled = false;
            this.suppressionDesUtilisateursToolStripMenuItem.Name = "suppressionDesUtilisateursToolStripMenuItem";
            this.suppressionDesUtilisateursToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.suppressionDesUtilisateursToolStripMenuItem.Text = "Suppression des utilisateurs";
            // 
            // gestionDesProduitsToolStripMenuItem
            // 
            this.gestionDesProduitsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créationDeProduitToolStripMenuItem,
            this.suppressionDeProduitToolStripMenuItem});
            this.gestionDesProduitsToolStripMenuItem.Name = "gestionDesProduitsToolStripMenuItem";
            this.gestionDesProduitsToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.gestionDesProduitsToolStripMenuItem.Text = "Gestion des produits";
            // 
            // créationDeProduitToolStripMenuItem
            // 
            this.créationDeProduitToolStripMenuItem.Name = "créationDeProduitToolStripMenuItem";
            this.créationDeProduitToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.créationDeProduitToolStripMenuItem.Text = "Création de produit";
            // 
            // suppressionDeProduitToolStripMenuItem
            // 
            this.suppressionDeProduitToolStripMenuItem.Name = "suppressionDeProduitToolStripMenuItem";
            this.suppressionDeProduitToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.suppressionDeProduitToolStripMenuItem.Text = "Suppression de produit";
            // 
            // gestionDesComptesDuMagasinToolStripMenuItem
            // 
            this.gestionDesComptesDuMagasinToolStripMenuItem.Name = "gestionDesComptesDuMagasinToolStripMenuItem";
            this.gestionDesComptesDuMagasinToolStripMenuItem.Size = new System.Drawing.Size(194, 20);
            this.gestionDesComptesDuMagasinToolStripMenuItem.Text = "Gestion des comptes du magasin";
            // 
            // statistiquesToolStripMenuItem
            // 
            this.statistiquesToolStripMenuItem.Name = "statistiquesToolStripMenuItem";
            this.statistiquesToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.statistiquesToolStripMenuItem.Text = "Statistiques";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choisir l\'utilisateur";
            // 
            // listUtil
            // 
            this.listUtil.FormattingEnabled = true;
            this.listUtil.Location = new System.Drawing.Point(255, 32);
            this.listUtil.Name = "listUtil";
            this.listUtil.Size = new System.Drawing.Size(217, 134);
            this.listUtil.TabIndex = 5;
            this.listUtil.SelectedIndexChanged += new System.EventHandler(this.listUtil_SelectedIndexChanged);
            // 
            // btValider
            // 
            this.btValider.Location = new System.Drawing.Point(255, 182);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(75, 23);
            this.btValider.TabIndex = 6;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // gbSup
            // 
            this.gbSup.Controls.Add(this.listUtil);
            this.gbSup.Controls.Add(this.label1);
            this.gbSup.Controls.Add(this.btValider);
            this.gbSup.Location = new System.Drawing.Point(119, 80);
            this.gbSup.Name = "gbSup";
            this.gbSup.Size = new System.Drawing.Size(569, 224);
            this.gbSup.TabIndex = 7;
            this.gbSup.TabStop = false;
            this.gbSup.Text = "Supprimer un utilisateur";
            // 
            // AdmSuppressionUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 388);
            this.Controls.Add(this.gbSup);
            this.Controls.Add(this.menuStrip1);
            this.Name = "AdmSuppressionUtilisateur";
            this.Text = "AdmSuppressionUtilisateur";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbSup.ResumeLayout(false);
            this.gbSup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherProduitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherFactureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesUtilisateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créationDesUtilisateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppressionDesUtilisateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesProduitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créationDeProduitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppressionDeProduitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesComptesDuMagasinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistiquesToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listUtil;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.GroupBox gbSup;
    }
}