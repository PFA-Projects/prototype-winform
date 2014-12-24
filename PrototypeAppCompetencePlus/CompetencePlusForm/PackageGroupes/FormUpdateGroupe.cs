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
    public partial class FormUpdateFiliere : Form
    {
        public FormUpdateFiliere()
        {
            InitializeComponent();
        }
        public FormUpdateFiliere(Filiere filier)
        {
            InitializeComponent();
            UpdateInterface(filier);
        }

        private Filiere filier;
        private void UpdateInterface(Filiere f) {
            filier = f;
            CodeTextBox.Text = filier.Code;
            TitreTextBox.Text = filier.Titre;
            DescriptionTextBox.Text = filier.Description;
        }

        private void BtUpdate_Click(object sender, EventArgs e)
        {
            filier.Code = CodeTextBox.Text;
            filier.Titre = TitreTextBox.Text;
            filier.Description = DescriptionTextBox.Text;
            new FiliereBAO().Update(filier);
            this.Dispose();
        }

        private void BtCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
