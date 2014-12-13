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
    }
}
