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
    public partial class FormStagiairesConfirmerInscription : Form
    {
        public FormStagiairesConfirmerInscription()
        {
            InitializeComponent();
        }
        string Url;
        public void Update(string Url, string nom, string Prenom, string dateNaissance, string Sexe, string Cin, Groupe g, Filiere f, string Email, string Telephone, string Adresse)
        {
            pictureBox1.Image = Image.FromFile(Url);
            NomLab.Text = nom;
            PrenomLab.Text = Prenom;
            DateNaissanceLab.Text = dateNaissance;
            SexeLab.Text = Sexe;
            CinLab.Text = Cin;
            GroupeLab.Text = g.Nom;
            FiliereLab.Text = f.Titre;
            EmailLab.Text = Email;
            TelephoneLab.Text = Telephone;
            AdresseLab.Text = Adresse;
            this.Url = Url;

        }
        public FormStagiairesInscription Formu { get; set; }
        private void FormStagiairesConfirmerInscription_Load(object sender, EventArgs e)
        {

        }

        private void BtConfirmer_Click_1(object sender, EventArgs e)
        {
            Stagiaire s = new Stagiaire();
            s.Id = 1;
            s.Nom = NomLab.Text;
            s.Prenom = PrenomLab.Text;
            s.DateNaissance = DateTime.Parse(DateNaissanceLab.Text);
            if (SexeLab.Text == "Male")
            {
                s.Sexe = true;
            }
            else s.Sexe = false;
            s.Cin = CinLab.Text;
            s.Groupe = new GroupeBAO().FindByName(GroupeLab.Text);
            s.Email = EmailLab.Text;
            s.Telephone = TelephoneLab.Text;
            s.Adresse = AdresseLab.Text;
            s.Etat = 0;
            s.ProfilImage = @Url;
            StagiaireBAO.Add(s);
            this.Dispose();
            Formu.Dispose();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            Formu.Show();
        }
    }
}
