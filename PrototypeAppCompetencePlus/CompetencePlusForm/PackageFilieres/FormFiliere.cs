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
    public partial class FormFiliere : Form
    {
        public FormFiliere()
        {
            InitializeComponent();
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            Filiere filiere = new Filiere();
            filiere.Code = CodeTextBox.Text;
            filiere.Titre = TitreTextBox.Text;
            filiere.Description = DescriptionTextBox.Text;
            new FiliereBAO().Add(filiere);
            this.Dispose();
        }

        private void BtCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
