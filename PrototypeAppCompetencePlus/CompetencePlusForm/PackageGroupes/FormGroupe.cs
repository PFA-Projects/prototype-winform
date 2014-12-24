using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompetencePlus.PackageGroupes
{
    public partial class FormGroupe : Form
    {
        public FormGroupe()
        {
            InitializeComponent();
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            Groupe g = new Groupe();
            g.Nom = NomTextBox.Text;
            g.Id = 1;
            g.Code = CodeTextBox.Text;
            g.Description = DescriptionTextBox.Text;
            new GroupeBAO().Add(g);
            this.Dispose();
        }

        private void BtCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void NomTextBox_Leave(object sender, EventArgs e)
        {
            
        }
    }
}
