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
    public partial class sokning : Form
    {
        public sokning()
        {
            InitializeComponent();
        }

        sokinfo nysokning = new sokinfo();

        private void btnSök_Click(object sender, EventArgs e)
        {


            if (txtNamn.Text == "" ||  txtNamn.TextLength < 3)
            {
                MessageBox.Show("Ange ett giltigt värde!");
            }
            else
            {
                nysokning.namnelleradress = txtNamn.Text;
                nysokning.sokperson(this);
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            uppdaterainfoForm uppdateraform = new uppdaterainfoForm();
            if (lstbResultat.Items.Count == 0)
            {
                MessageBox.Show("Finns ingen information du kan visa.");
            }
            else
            {
                nysokning.visainfo(this);
            }
        }

        private void btnRaderaInfo_Click(object sender, EventArgs e)
        {
            if (lstbResultat.SelectedItem == null)
            {
                MessageBox.Show("Välj vilken person du vill radera.");
            }
            else
            {
                nysokning.raderainfo(this);
                MessageBox.Show("Informationen har raderats!");
                lstbResultat.DataSource = null;
                lstbResultat.Items.Clear();
            }
        }

        private void btnUppdateraInfo_Click(object sender, EventArgs e)
        {
            if (lstbResultat.SelectedItem == null)
            {
                MessageBox.Show("Välj vilken person du vill uppdatera.");
            }
            else
            {
                uppdaterainfoForm uppdateraform = new uppdaterainfoForm();
                nysokning.uppdaterainfo(this);
               

            }
        }

        private void sokning_Load(object sender, EventArgs e)
        {
            
        }

        private void bullionButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
