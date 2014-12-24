using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CompetencePlus.PackageFilieres;
using CompetencePlus.PackageStagiaires;

namespace CompetencePlus
{
    public partial class MenuApplication : Form
    {
        public MenuApplication()
        {
            InitializeComponent();
        }

        private void gérerFiliereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionFiliere f = new FormGestionFiliere();
            f.Show();
        }

        private void gestionDinformationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ajouterUneInscriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStagiairesInscription f = new FormStagiairesInscription();
            f.Show();
        }

        private void gérerLesInscriptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionInscription f = new FormGestionInscription();
            f.Show();
        }

        private void gérerLesStagiairesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionStagiaires f = new FormGestionStagiaires();
            f.Show();
        }
    }
}
