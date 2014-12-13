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
        public void Actualiser() {
            filiereBindingSource.DataSource = null;
            filiereBindingSource.DataSource = new FiliereBAO().Select();
            try
            {
                Filiere f = (Filiere)filiereBindingSource.Current;
                TitreLabel.Text = f.Titre;
                CodeLabel.Text = f.Code;
            }
            catch (Exception) { }
            
                
              
           
        }

        private void FormGestionFiliere_Load(object sender, EventArgs e)
        {
            this.Actualiser();
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            FormFiliere f = new FormFiliere();
            f.ShowDialog();
            this.Actualiser();
        }

        private void filiereDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Filiere f = (Filiere)filiereBindingSource.Current;
                TitreLabel.Text = f.Titre;
                CodeLabel.Text = f.Code;
          

            if (e.ColumnIndex == 2)
            {
                FormUpdateFiliere fu = new FormUpdateFiliere();
                fu.Update(f);
                fu.ShowDialog();
                this.Actualiser();
            }
            if (e.ColumnIndex==3)
            {
                new FiliereBAO().Delete(f.Id);
                this.Actualiser();
            }
            }
            catch (Exception) { }
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

        private void BtRecherche_Click(object sender, EventArgs e)
        {
            if (CodeTextBox.Text != "" && TitleTextBox.Text != "" && DescriptionTextBox.Text != "")
            {
                filiereBindingSource.DataSource = null;
                filiereBindingSource.DataSource = new FiliereBAO().SelectCodeAndDescriptionAndTitle(CodeTextBox.Text, DescriptionTextBox.Text, TitleTextBox.Text);
            }else
                if (CodeTextBox.Text!=""&&TitleTextBox.Text!="")
                {
                     filiereBindingSource.DataSource = null;
                     filiereBindingSource.DataSource = new FiliereBAO().SelectCodeAndTitle(CodeTextBox.Text,TitleTextBox.Text);
                
                }else
                    if (CodeTextBox.Text!=""&&DescriptionTextBox.Text!="")
                    {
                         filiereBindingSource.DataSource = null;
                         filiereBindingSource.DataSource = new FiliereBAO().SelectCodeAndDescription(CodeTextBox.Text,DescriptionTextBox.Text);
                    }
                    else
                        if (CodeTextBox.Text != "" && DescriptionTextBox.Text != "")
                        {
                            filiereBindingSource.DataSource = null;
                            filiereBindingSource.DataSource = new FiliereBAO().SelectCodeAndDescription(CodeTextBox.Text, DescriptionTextBox.Text);
                        }
            else
                            if (TitleTextBox.Text != "" && DescriptionTextBox.Text != "")
                            {
                                filiereBindingSource.DataSource = null;
                                filiereBindingSource.DataSource = new FiliereBAO().SelectTitreAndDescription(TitleTextBox.Text, DescriptionTextBox.Text);
                            }
                            else

            if (CodeTextBox.Text!="")
            {
                filiereBindingSource.DataSource = null;
                filiereBindingSource.DataSource = new FiliereBAO().SelectCode(CodeTextBox.Text);
            } else
            if (TitleTextBox.Text != "")
            {
                filiereBindingSource.DataSource = null;
                filiereBindingSource.DataSource = new FiliereBAO().SelectTitre(TitleTextBox.Text);
            }else
                if (DescriptionTextBox.Text != "")
                {
                    filiereBindingSource.DataSource = null;
                    filiereBindingSource.DataSource = new FiliereBAO().SelectDescription(DescriptionTextBox.Text);
                }
        }
    }
}
