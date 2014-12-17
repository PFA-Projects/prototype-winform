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
                Filiere filier = (Filiere)filiereBindingSource.Current;
                TitreLabel.Text = filier.Titre;
                CodeLabel.Text = filier.Code;
                if (e.ColumnIndex == 2)
                {
                    FormUpdateFiliere form = new FormUpdateFiliere(filier);
                    form.ShowDialog();
                    this.refresh();
                }
                if (e.ColumnIndex==3&&MessageBox.Show("voulez vous supprimer cette filiere","Information dialog",MessageBoxButtons.YesNo)==DialogResult.Yes)
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
            Filiere filier = new Filiere();
            filier.Code = CodeTextBox.Text;
            filier.Description = DescriptionTextBox.Text;
            filier.Titre = TitleTextBox.Text;
            filiereBindingSource.DataSource = null;
            filiereBindingSource.DataSource = new FiliereBAO().FindByFilier(filier);
          
        }
    }
}
