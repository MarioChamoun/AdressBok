using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Adressbok
{
    public partial class Adressbok : Form
    {
        public Adressbok()
        {
            InitializeComponent();
        }
        personuppgifter nyperson = new personuppgifter();

        private void btnRegistrera_Click(object sender, EventArgs e)
        {
            nyperson.namn = txtNamn.Text;
            nyperson.gatuadress = txtAdress.Text;
            nyperson.postnummer = txtPostnummer.Text;
            nyperson.postort = txtPostort.Text;
            nyperson.telefon = txtTelefon.Text;
            nyperson.mailadress = txtMail.Text;
            nyperson.fel = false;

            if(nyperson.felinfo == "mail")
            {
                MessageBox.Show("Kontrollera att du har skrivit rätt mailadress");
            } else if (nyperson.felinfo == "postnummer")
            {
                MessageBox.Show("Kontrollera att du har skrivit in rätt postnummer");
            } else if(nyperson.felinfo == "telefonnummer")
            {
                MessageBox.Show("Kontrollera att du har skrivit in rätt telefon nummer");
            } else
            {
                nyperson.registrera();
                MessageBox.Show("Informationen har registrerats!");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sokning sokningform = new sokning();
            sokningform.Show();
        }
    }
}
