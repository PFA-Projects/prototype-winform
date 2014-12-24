using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CompetencePlus.PackageGroupes;
using CompetencePlus.PackageFilieres;

namespace CompetencePlus.PackageStagiaires
{
    public partial class FormStagiairesInscription : Form
    {
        public FormStagiairesInscription()
        {
            InitializeComponent();
        }
        string Url;

        private void BtProfilImage_Click(object sender, EventArgs e)
        {
            openImageDialog.ShowDialog();
            pictureBox1.Image = Image.FromFile(openImageDialog.FileName);
            Url = openImageDialog.FileName;
        }

        private void FormStagiairesInscription_Load(object sender, EventArgs e)
        {
            groupeComboBox.DataSource = new GroupeBAO().Select();
            FilierecomboBox.DataSource = new FiliereBAO().Select();
        }

        private void BtValide_Click_1(object sender, EventArgs e)
        {
            string sexe;
            if (sexeRadioButton.Checked)
            {
                sexe = "Male";
            }
            else sexe = "Femelle";

            FormStagiairesConfirmerInscription f = new FormStagiairesConfirmerInscription();
            f.Update(Url, nomTextBox.Text, PrenomTextBox.Text, dateNaissanceDateTimePicker.Value.ToString(),
                sexe, CinTextBox.Text, (Groupe)groupeComboBox.SelectedItem, (Filiere)FilierecomboBox.SelectedItem,
                emailTextBox.Text, telephoneTextBox.Text, adresseTextBox.Text);
            f.Formu = this;
            f.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
