using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompetencePlus.PackageStagiaires
{
    public partial class FormGestionStagiaires : Form
    {
        public FormGestionStagiaires()
        {
            InitializeComponent();
        }
        public void Actualiser() {
            stagiaireBindingSource.DataSource = null;
            stagiaireBindingSource.DataSource = new StagiaireBAO().Select();
        }

        private void FormGestionStagiaires_Load(object sender, EventArgs e)
        {
            this.Actualiser();
        }

        private void stagiaireDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==3)
            {
                Stagiaire s = (Stagiaire)stagiaireBindingSource.Current;
                    FormUpdateStagiaires f = new FormUpdateStagiaires();
                    f.Update(s);
                    f.ShowDialog();
                    this.Actualiser();
            }
            if (e.ColumnIndex==4)
            {
                Stagiaire s = (Stagiaire)stagiaireBindingSource.Current;
                new StagiaireBAO().Delete(s.Id);
                this.Actualiser();
            }
        }

        private void BtResearch_Click(object sender, EventArgs e)
        {

        }
    }
}
