namespace CompetencePlus
{
    partial class MenuApplication
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
            this.gestionDinformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerFiliereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionIndividuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerStagiaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneInscriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLesInscriptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLesStagiairesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDinformationToolStripMenuItem,
            this.gestionIndividuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(443, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionDinformationToolStripMenuItem
            // 
            this.gestionDinformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerFiliereToolStripMenuItem});
            this.gestionDinformationToolStripMenuItem.Name = "gestionDinformationToolStripMenuItem";
            this.gestionDinformationToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.gestionDinformationToolStripMenuItem.Text = "Paramétrage";
            this.gestionDinformationToolStripMenuItem.Click += new System.EventHandler(this.gestionDinformationToolStripMenuItem_Click);
            // 
            // gérerFiliereToolStripMenuItem
            // 
            this.gérerFiliereToolStripMenuItem.Name = "gérerFiliereToolStripMenuItem";
            this.gérerFiliereToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.gérerFiliereToolStripMenuItem.Text = "Gestion des filières";
            this.gérerFiliereToolStripMenuItem.Click += new System.EventHandler(this.gérerFiliereToolStripMenuItem_Click);
            // 
            // gestionIndividuToolStripMenuItem
            // 
            this.gestionIndividuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerStagiaireToolStripMenuItem});
            this.gestionIndividuToolStripMenuItem.Name = "gestionIndividuToolStripMenuItem";
            this.gestionIndividuToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.gestionIndividuToolStripMenuItem.Text = "Gestion individu";
            // 
            // gérerStagiaireToolStripMenuItem
            // 
            this.gérerStagiaireToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUneInscriptionToolStripMenuItem,
            this.gérerLesInscriptionsToolStripMenuItem,
            this.gérerLesStagiairesToolStripMenuItem});
            this.gérerStagiaireToolStripMenuItem.Name = "gérerStagiaireToolStripMenuItem";
            this.gérerStagiaireToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.gérerStagiaireToolStripMenuItem.Text = "Gestion stagiaires";
            // 
            // ajouterUneInscriptionToolStripMenuItem
            // 
            this.ajouterUneInscriptionToolStripMenuItem.Name = "ajouterUneInscriptionToolStripMenuItem";
            this.ajouterUneInscriptionToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.ajouterUneInscriptionToolStripMenuItem.Text = "Ajouter une inscription";
            this.ajouterUneInscriptionToolStripMenuItem.Click += new System.EventHandler(this.ajouterUneInscriptionToolStripMenuItem_Click);
            // 
            // gérerLesInscriptionsToolStripMenuItem
            // 
            this.gérerLesInscriptionsToolStripMenuItem.Name = "gérerLesInscriptionsToolStripMenuItem";
            this.gérerLesInscriptionsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.gérerLesInscriptionsToolStripMenuItem.Text = "Gérer les inscriptions";
            this.gérerLesInscriptionsToolStripMenuItem.Click += new System.EventHandler(this.gérerLesInscriptionsToolStripMenuItem_Click);
            // 
            // gérerLesStagiairesToolStripMenuItem
            // 
            this.gérerLesStagiairesToolStripMenuItem.Name = "gérerLesStagiairesToolStripMenuItem";
            this.gérerLesStagiairesToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.gérerLesStagiairesToolStripMenuItem.Text = "Gérer les stagiaires";
            this.gérerLesStagiairesToolStripMenuItem.Click += new System.EventHandler(this.gérerLesStagiairesToolStripMenuItem_Click);
            // 
            // MenuApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 357);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuApplication";
            this.Text = "Prototype - CompétencePlus";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionDinformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerFiliereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionIndividuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerStagiaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneInscriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerLesInscriptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerLesStagiairesToolStripMenuItem;
    }
}