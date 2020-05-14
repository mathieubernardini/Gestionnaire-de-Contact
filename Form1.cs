using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionContact
{
    
    public partial class gestionContact : Form
    {
        List<Contact> listeContact = new List<Contact>();
        int nbContact = 0;
        string sauvegarde = "sauvegardeContact";

        private void gestionListe()
        {
            lstContact.Items.Clear();
            foreach (Contact contact in listeContact)
            {
                lstContact.Items.Add(contact.infosContact());

            }
            Serialise.Sauve(sauvegarde, listeContact);

        }


        private void affichePhotoStandard()
        {
            if (rbParticulier.Checked)
            {
                picContact.Image = Properties.Resources.particulier;
            }
            else
            {
                picContact.Image = Properties.Resources.professionnel;
            }
        }


        private bool pingContact (string telephone)
        {
            bool output = true;
            foreach (Contact contact in listeContact)
            {
                if (contact.getTel() == telephone)
                {
                    output = false;
                }
            }
            return output;
        }

        private Contact searchContact (string telephone)
        {
            Contact contactVoulu = null;

            foreach (Contact contact in listeContact)
            {
                if (contact.getTel().Contains( telephone))
                {
                    contactVoulu = contact;
                }
            }

            return contactVoulu;

        }
        /*
         * AJOUT DE CONTACT ET ANNULATION D'AJOUT
         * 
         */

        private bool verifDonnee(string input, char char1, char char2)
        {
            input = input.ToUpper();
            bool output = true;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.Parse(input.Substring(i, 1)) < char1 || char.Parse(input.Substring(i, 1)) > char2)
                {
                    output = false;
                }
            }
            return output;
        }

        private void analyseNum (string input, ref bool output)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if ((i == 2 || i == 5 || i == 8 || i == 11) && (char.Parse(input.Substring(i, 1)) != ' '))
                {
                    output = false;
                }
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (i == 2 || i == 4 || i == 6 || i == 8)
                {
                    input = input.Remove(i, 1);
                }
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (char.Parse(input.Substring(i, 1)) < '0' || char.Parse(input.Substring(i, 1)) > '9')
                {
                    output = false;
                }
            }
        }

        private bool verifTel(string input)
        {
            bool output = true;

            try
            {
                if (input.Length != 14)
                {
                    output = false;
                }

                analyseNum(input,ref output);


            }
            catch
            {

            }

            return output;
        }

        private void messageErreur (string input, string typeDonnee, string phrasePerso)
        {
            if (input == "")
            {
                MessageBox.Show("Veuillez remplir le champ \"" + typeDonnee +  "\".");
            }
            else
            {
                MessageBox.Show("Le champ \"" + typeDonnee + "\" ne doit contenir que des " + phrasePerso + ".");
            }
        }

        private void ajouterContact (string nom, string prenom, string telephone)
        {
            if (rbParticulier.Checked)
            {
                if (nom == "" || !verifDonnee(nom, 'A', 'Z'))
                {
                    messageErreur(nom, "Nom", "lettres");
                }
                else if (prenom == "" || !verifDonnee(prenom, 'A', 'Z'))
                {
                    messageErreur(prenom, "Prénom", "lettres");
                }
                else if (telephone == "" || !verifTel(telephone))
                {
                    messageErreur(telephone, "Telephone", "10 chiffres et des espaces entre chaque paire");
                }
                else
                {
                    Particulier newParticulier = new Particulier(nom, prenom, telephone, picContact.Image);
                    listeContact.Add(newParticulier);
                    cleanAjoutContact();
                    activationAjoutContact(false);

                }
                
            }
            else if (rbProfessionnel.Checked)
            {
                if (nom == "" || !verifDonnee(nom, 'A', 'Z'))
                {
                    messageErreur(nom, "Nom", "lettres");
                }
                else if (telephone == "" || !verifTel(telephone))
                {
                    messageErreur(telephone, "Telephone", "10 chiffres et des espaces entre chaque paire");
                }
                else
                {
                    Professionnel newProfessionnel = new Professionnel(nom, telephone, picContact.Image);
                    listeContact.Add(newProfessionnel);
                    cleanAjoutContact();
                    activationAjoutContact(false);

                }
            }

            gestionListe();
        }

        private void cleanAjoutContact ()
        {
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtTel.Text = "";
            rbParticulier.Checked = false;
            rbProfessionnel.Checked = false;
        }

        private void activationElemGraph (bool input)
        {
            txtNom.Enabled = input;
            txtPrenom.Enabled = input;
            txtTel.Enabled = input;
            btnAddContact.Enabled = input;
            btnCancelContact.Enabled = input;
            picContact.Enabled = input;

            btnDeleteContact.Enabled = !input;
            btnModifier.Enabled = !input;
            grpRecherche.Enabled = !input;
            lstContact.Enabled = !input;
        }

        private void activationAjoutContact(bool input)
        {
            activationElemGraph(input);
            lblPhoto.Visible = input;

            if (!rbParticulier.Checked && !rbProfessionnel.Checked)
            {
                picContact.Image = Properties.Resources.vide;
                lblPrenom.Visible = true;
                txtPrenom.Visible = true;
            }

            else
            {
                if (rbParticulier.Checked)
                {
                    picContact.Image = Properties.Resources.particulier;
                    lblPrenom.Visible = true;
                    txtPrenom.Visible = true;
                }
                else
                {
                    picContact.Image = Properties.Resources.professionnel;
                    lblPrenom.Visible = false;
                    txtPrenom.Visible = false;
                }
            }
            
        }

        /* 
         * Module evenementiel
         * 
         */

        public gestionContact()
        {
            InitializeComponent();
        }

        private void gestionContact_Load(object sender, EventArgs e)
        {
            Object recuperation = Serialise.Recup(sauvegarde);
            if (recuperation != null)
            {
                listeContact = (List<Contact>)recuperation;

            }
            gestionListe();
            lstContact.SelectedIndex = 0;

        }

        private void rbParticulier_CheckedChanged(object sender, EventArgs e)
        {
            activationAjoutContact(true);

        }
        private void btnCancelContact_Click(object sender, EventArgs e)
        {
            cleanAjoutContact();
            activationAjoutContact(false);
            lstContact.SelectedIndex = 0;
            picContact.Image = listeContact[0].getPhoto();
        }

        private void rbProfessionnel_CheckedChanged(object sender, EventArgs e)
        {
            activationAjoutContact(true);   
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {


            try
            {
                string nom = txtNom.Text, prenom = txtPrenom.Text, telephone = txtTel.Text;

                if (pingContact(telephone))
                {
                    ajouterContact(nom, prenom, telephone);
                    lstContact.SelectedIndex = nbContact;
                    nbContact++;
                }
                else
                {
                    MessageBox.Show("Un contact semble déjà avoir été enregistré sous ce numéro.");
                }


                  
            }
            catch
            {
                
            }

        }


        private void lstContact_SelectedIndexChanged(object sender, EventArgs e)
        {
            picContact.Image = listeContact[lstContact.SelectedIndex].getPhoto();
        }

        private void btnDeleteContact_Click(object sender, EventArgs e)
        {
            try
            {
                string contact = lstContact.SelectedItem.ToString();
                int index = lstContact.SelectedIndex;

                Contact contactTrouve = searchContact(contact.Substring(contact.Length - 15, 14));

                listeContact.Remove(contactTrouve);

                gestionListe();
                nbContact--;

                lstContact.SelectedIndex = index;
            }
            catch
            {

            }


        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (lstContact.SelectedIndex > -1)
            {
                string contact = lstContact.SelectedItem.ToString();
                int index = lstContact.SelectedIndex;

                Contact contactTrouve = searchContact(contact.Substring(contact.Length - 15, 14));

                txtNom.Text = contactTrouve.getNom();
                if (contactTrouve is Particulier)
                {
                    rbParticulier.Checked = true;
                    txtPrenom.Text = ((Particulier)contactTrouve).getPrenom();
                }
                else
                {
                    rbProfessionnel.Checked = true;

                }
                txtTel.Text = contactTrouve.getTel();
                picContact.Image = contactTrouve.getPhoto();

                listeContact.Remove(contactTrouve);
                gestionListe();
                nbContact--;
            }
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            txtRecherche.Text = "";
            gestionListe();
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            if(txtRecherche.Text != "")
            {
                bool analyse = true;
                analyseNum(txtRecherche.Text, ref analyse);

                if (analyse)
                {
                    lstContact.Items.Clear();
                    foreach (Contact contact in listeContact)
                    {
                        if (contact.getTel().Contains(txtRecherche.Text))
                        {
                            lstContact.Items.Add(contact.infosContact());
                        }
                    }
                    lstContact.SelectedIndex = 0;
                }
            }
        }

        private void picContact_Click(object sender, EventArgs e)
        {
            OpenFileDialog rechercheFichier;
            rechercheFichier = new System.Windows.Forms.OpenFileDialog();
            DialogResult choix = rechercheFichier.ShowDialog();

            if (choix == DialogResult.OK)
            {
                string nomFichier = rechercheFichier.FileName;

                try
                {
                    picContact.Image = Image.FromFile(nomFichier);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Le fichier n'est pas une image");

                    affichePhotoStandard();
                }
            }
        }

        private void lblPhoto_Click(object sender, EventArgs e)
        {
            picContact_Click(null, null);
        }

        private void lstContact_DrawItem_1(object sender, DrawItemEventArgs e)
        {
            if (e.Index > -1)
            {
                e.DrawBackground();
                string contact = lstContact.SelectedItem.ToString();
                int index = lstContact.SelectedIndex;

                Contact contactTrouve = searchContact(contact.Substring(contact.Length - 15, 14));

                Color couleur = Color.Red;

                if (contactTrouve is Particulier)
                {
                    couleur = rbParticulier.ForeColor;
                }
                else if (contactTrouve is Professionnel)
                {
                    couleur = rbProfessionnel.ForeColor;
                }
                Brush myBrush = new SolidBrush(couleur);

                e.Graphics.DrawString(contact, e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
                e.DrawFocusRectangle();

            }
        }
    }
}
