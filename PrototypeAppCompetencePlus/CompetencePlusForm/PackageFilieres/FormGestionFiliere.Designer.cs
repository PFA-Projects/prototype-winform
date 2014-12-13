namespace CompetencePlus.PackageFilieres
{
    partial class FormGestionFiliere
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CodeLabel = new System.Windows.Forms.Label();
            this.TitreLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.CodeTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.filiereDataGridView = new System.Windows.Forms.DataGridView();
            this.Update = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.BtFirst = new System.Windows.Forms.Button();
            this.BtPrevious = new System.Windows.Forms.Button();
            this.BtNext = new System.Windows.Forms.Button();
            this.BtLast = new System.Windows.Forms.Button();
            this.BtRecherche = new System.Windows.Forms.Button();
            this.BtAdd = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filiereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filiereDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filiereBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CodeLabel);
            this.groupBox1.Controls.Add(this.TitreLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filiere";
            // 
            // CodeLabel
            // 
            this.CodeLabel.AutoSize = true;
            this.CodeLabel.Location = new System.Drawing.Point(94, 113);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(31, 13);
            this.CodeLabel.TabIndex = 3;
            this.CodeLabel.Text = "code";
            // 
            // TitreLabel
            // 
            this.TitreLabel.AutoSize = true;
            this.TitreLabel.Location = new System.Drawing.Point(94, 30);
            this.TitreLabel.Name = "TitreLabel";
            this.TitreLabel.Size = new System.Drawing.Size(28, 13);
            this.TitreLabel.TabIndex = 2;
            this.TitreLabel.Text = "Titre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.DescriptionTextBox);
            this.groupBox2.Controls.Add(this.CodeTextBox);
            this.groupBox2.Controls.Add(this.TitleTextBox);
            this.groupBox2.Location = new System.Drawing.Point(11, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 163);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recherche";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Titre";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(75, 117);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(146, 20);
            this.DescriptionTextBox.TabIndex = 2;
            // 
            // CodeTextBox
            // 
            this.CodeTextBox.Location = new System.Drawing.Point(75, 71);
            this.CodeTextBox.Name = "CodeTextBox";
            this.CodeTextBox.Size = new System.Drawing.Size(146, 20);
            this.CodeTextBox.TabIndex = 1;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(75, 29);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(146, 20);
            this.TitleTextBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.filiereDataGridView);
            this.groupBox3.Location = new System.Drawing.Point(291, 55);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(551, 344);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Liste des filieres";
            // 
            // filiereDataGridView
            // 
            this.filiereDataGridView.AutoGenerateColumns = false;
            this.filiereDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filiereDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Update,
            this.Delete});
            this.filiereDataGridView.DataSource = this.filiereBindingSource;
            this.filiereDataGridView.Location = new System.Drawing.Point(12, 19);
            this.filiereDataGridView.Name = "filiereDataGridView";
            this.filiereDataGridView.Size = new System.Drawing.Size(530, 310);
            this.filiereDataGridView.TabIndex = 0;
            this.filiereDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.filiereDataGridView_CellClick);
            // 
            // Update
            // 
            this.Update.HeaderText = "";
            this.Update.Image = global::CompetencePlus.Properties.Resources.Update;
            this.Update.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Update.Name = "Update";
            this.Update.Width = 50;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Image = global::CompetencePlus.Properties.Resources.Delete;
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            this.Delete.Width = 50;
            // 
            // BtFirst
            // 
            this.BtFirst.Location = new System.Drawing.Point(303, 417);
            this.BtFirst.Name = "BtFirst";
            this.BtFirst.Size = new System.Drawing.Size(75, 23);
            this.BtFirst.TabIndex = 3;
            this.BtFirst.Text = "<<";
            this.BtFirst.UseVisualStyleBackColor = true;
            this.BtFirst.Click += new System.EventHandler(this.BtFirst_Click);
            // 
            // BtPrevious
            // 
            this.BtPrevious.Location = new System.Drawing.Point(396, 417);
            this.BtPrevious.Name = "BtPrevious";
            this.BtPrevious.Size = new System.Drawing.Size(75, 23);
            this.BtPrevious.TabIndex = 4;
            this.BtPrevious.Text = "<";
            this.BtPrevious.UseVisualStyleBackColor = true;
            this.BtPrevious.Click += new System.EventHandler(this.BtPrevious_Click);
            // 
            // BtNext
            // 
            this.BtNext.Location = new System.Drawing.Point(494, 417);
            this.BtNext.Name = "BtNext";
            this.BtNext.Size = new System.Drawing.Size(75, 23);
            this.BtNext.TabIndex = 5;
            this.BtNext.Text = ">";
            this.BtNext.UseVisualStyleBackColor = true;
            this.BtNext.Click += new System.EventHandler(this.BtNext_Click);
            // 
            // BtLast
            // 
            this.BtLast.Location = new System.Drawing.Point(586, 417);
            this.BtLast.Name = "BtLast";
            this.BtLast.Size = new System.Drawing.Size(75, 23);
            this.BtLast.TabIndex = 6;
            this.BtLast.Text = ">>";
            this.BtLast.UseVisualStyleBackColor = true;
            this.BtLast.Click += new System.EventHandler(this.BtLast_Click);
            // 
            // BtRecherche
            // 
            this.BtRecherche.Location = new System.Drawing.Point(72, 417);
            this.BtRecherche.Name = "BtRecherche";
            this.BtRecherche.Size = new System.Drawing.Size(114, 23);
            this.BtRecherche.TabIndex = 7;
            this.BtRecherche.Text = "Recherche";
            this.BtRecherche.UseVisualStyleBackColor = true;
            this.BtRecherche.Click += new System.EventHandler(this.BtRecherche_Click);
            // 
            // BtAdd
            // 
            this.BtAdd.Location = new System.Drawing.Point(758, 26);
            this.BtAdd.Name = "BtAdd";
            this.BtAdd.Size = new System.Drawing.Size(75, 23);
            this.BtAdd.TabIndex = 8;
            this.BtAdd.Text = "Ajouter";
            this.BtAdd.UseVisualStyleBackColor = true;
            this.BtAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Code";
            this.dataGridViewTextBoxColumn2.HeaderText = "Code";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Titre";
            this.dataGridViewTextBoxColumn3.HeaderText = "Titre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 280;
            // 
            // filiereBindingSource
            // 
            this.filiereBindingSource.DataSource = typeof(CompetencePlus.PackageFilieres.Filiere);
            // 
            // FormGestionFiliere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 463);
            this.Controls.Add(this.BtAdd);
            this.Controls.Add(this.BtRecherche);
            this.Controls.Add(this.BtLast);
            this.Controls.Add(this.BtNext);
            this.Controls.Add(this.BtPrevious);
            this.Controls.Add(this.BtFirst);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormGestionFiliere";
            this.Text = "FormGestionFiliere";
            this.Load += new System.EventHandler(this.FormGestionFiliere_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filiereDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filiereBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label CodeLabel;
        private System.Windows.Forms.Label TitreLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.TextBox CodeTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtFirst;
        private System.Windows.Forms.Button BtPrevious;
        private System.Windows.Forms.Button BtNext;
        private System.Windows.Forms.Button BtLast;
        private System.Windows.Forms.Button BtRecherche;
        private System.Windows.Forms.Button BtAdd;
        private System.Windows.Forms.DataGridView filiereDataGridView;
        private System.Windows.Forms.BindingSource filiereBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewImageColumn Update;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}