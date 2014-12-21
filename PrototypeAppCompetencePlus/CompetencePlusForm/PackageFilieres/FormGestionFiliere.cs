using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompetencePlus.PackageFilieres
{
    public partial class FormGestionFiliere : Form
    {

        Filiere filier;
        public FormGestionFiliere()
        {
            InitializeComponent();
        }
        private void FormGestionFiliere_Load(object sender, EventArgs e)
        {
            this.refresh();
        }
        public void refresh()
        {
            filiereBindingSource.DataSource = null;
            filiereBindingSource.DataSource = new FiliereBAO().Select();
            try
            {
                Filiere f = (Filiere)filiereBindingSource.Current;
                TitreLabel.Text = f.Titre;
                CodeLabel.Text = f.Code;
            }
            catch (Exception e) {
                MessageBox.Show(e.Message);
            }

        }


        private void BtAdd_Click(object sender, EventArgs e)
        {
            FormFiliere f = new FormFiliere();
            f.ShowDialog();
            this.refresh();
        }
        private void filiereDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                filier = (Filiere)filiereBindingSource.Current;
                TitreLabel.Text = filier.Titre;
                CodeLabel.Text = filier.Code;
                if (e.ColumnIndex == 2)
                {
                    groupBox3.Enabled = false;
                    BtFirst.Enabled = false;
                    BtLast.Enabled = false;
                    BtNext.Enabled = false;
                    BtPrevious.Enabled = false;
                    BtAdd.Enabled = false;
                    groupBox2.Text = "Modifier";
                    BtResearch.Text = "Enregistrer";
                    TitleTextBox.Text = filier.Titre;
                    CodeTextBox.Text = filier.Code;
                    DescriptionTextBox.Text = filier.Description;
                    BtCancel.Visible = true;
                }
                if (e.ColumnIndex == 3 && MessageBox.Show("voulez vous supprimer cette filiere", "Information dialog", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    new FiliereBAO().Delete(filier.Id);
                    this.refresh();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void BtFirst_Click(object sender, EventArgs e)
        {
            filiereBindingSource.Position = 0;
        }

        private void BtLast_Click(object sender, EventArgs e)
        {
            filiereBindingSource.Position = filiereBindingSource.Count;
        }

        private void BtPrevious_Click(object sender, EventArgs e)
        {
            filiereBindingSource.Position = filiereBindingSource.Position - 1;
        }

        private void BtNext_Click(object sender, EventArgs e)
        {
            filiereBindingSource.Position = filiereBindingSource.Position + 1;
        }

        private void BtResearch_Click(object sender, EventArgs e)
        {
            if (groupBox2.Text == "Recherche")
            {
                Filiere filier = new Filiere();
                filier.Code = CodeTextBox.Text;
                filier.Description = DescriptionTextBox.Text;
                filier.Titre = TitleTextBox.Text;
                filiereBindingSource.DataSource = null;
                filiereBindingSource.DataSource = new FiliereBAO().FindByFilier(filier);
            }
            if (groupBox2.Text == "Modifier")
            {
                this.filier.Code = CodeTextBox.Text;
                this.filier.Titre = TitleTextBox.Text;
                this.filier.Description = DescriptionTextBox.Text;
                new FiliereBAO().Update(this.filier);
                groupBox3.Enabled = true;
                BtFirst.Enabled = true;
                BtLast.Enabled = true;
                BtNext.Enabled = true;
                BtPrevious.Enabled = true;
                BtAdd.Enabled = true;
                groupBox2.Text = "Recherche";
                BtResearch.Text = "Recherche";
                this.refresh();
            }
        }

        private void BtCancel_Click(object sender, EventArgs e)
        {
            if (groupBox2.Text == "Recherche")
            {
                this.refresh();
            }
            else
            {
                groupBox3.Enabled = true;
                BtFirst.Enabled = true;
                BtLast.Enabled = true;
                BtNext.Enabled = true;
                BtPrevious.Enabled = true;
                BtAdd.Enabled = true;
                groupBox2.Text = "Recherche";
                BtResearch.Text = "Recherche";
            }
        }
    }
}
