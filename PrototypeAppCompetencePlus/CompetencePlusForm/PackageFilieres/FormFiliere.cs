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

        private void TitreTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TitreTextBox.Text))
            {
               // errorProviderTitle.Icon =Properties.Resources.Error;
                this.errorProviderTitle.Icon = new Icon(SystemIcons.Error,64,32);
                 errorProviderTitle.SetError(TitreTextBox,"The text box is empty");
            }
            else
            {
                    errorProviderTitle.Icon=Properties.Resources.Clear;
                    errorProviderTitle.SetError(TitreTextBox, "ok");
            }
        }

        private void FormFiliere_Load(object sender, EventArgs e)
        {
            
        }

        private void CodeTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TitreTextBox.Text))
            {
                // errorProviderTitle.Icon =Properties.Resources.Error;
                this.errorProviderCode.Icon = new Icon(SystemIcons.Error, 64, 32);
                errorProviderCode.SetError(CodeTextBox, "The text box is empty");
            }
            else
            {
                errorProviderCode.Icon = Properties.Resources.Clear;
                errorProviderCode.SetError(CodeTextBox, "ok");
            }
        }

        private void DescriptionTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TitreTextBox.Text))
            {
                // errorProviderTitle.Icon =Properties.Resources.Error;
                this.errorProviderDescription.Icon = new Icon(SystemIcons.Error, 64, 32);
                errorProviderDescription.SetError(DescriptionTextBox, "The text box is empty");
            }
            else
            {
                errorProviderDescription.Icon = Properties.Resources.Clear;
                errorProviderDescription.SetError(CodeTextBox, "ok");
            }
        }
    }
}
