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
        int id;
        public void Update(Filiere f) {
            id = f.Id;
            CodeTextBox.Text = f.Code;
            TitreTextBox.Text = f.Titre;
            DescriptionTextBox.Text = f.Description;
        
        }
        private void FormUpdateFiliere_Load(object sender, EventArgs e)
        {

        }

        private void BtUpdate_Click(object sender, EventArgs e)
        {
            Filiere f = new Filiere();
            f.Id = id;
            f.Code = CodeTextBox.Text;
            f.Titre = TitreTextBox.Text;
            f.Description = DescriptionTextBox.Text;
            new FiliereBAO().Update(f);
            this.Dispose();
        }
    }
}
