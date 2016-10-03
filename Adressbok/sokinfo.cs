using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Adressbok
{
    public class sokinfo
    {
        public string namnelleradress { get; set; }

        string allavärden = File.ReadAllText(@"C:\Users\Mario\Desktop\adressbok.txt");

        public void sokperson(sokning form)
        {
            var lines = File.ReadAllLines(@"C:\Users\Mario\Desktop\adressbok.txt").Where(arg => !string.IsNullOrWhiteSpace(arg));
            File.WriteAllLines(@"C:\Users\Mario\Desktop\adressbok.txt", lines);

            string[] värdenEfterSplit = allavärden.Split(':');
            string postort = värdenEfterSplit.GetValue(3).ToString();
            bool postortSökning = false;
            form.lstbResultat.Items.Clear();
            for (int i = 0; i < värdenEfterSplit.Length; i+=6)
            {

                    if (värdenEfterSplit[i].Contains(namnelleradress))
                    {

                        form.lstbResultat.Items.Add(värdenEfterSplit[i]);
                        postortSökning = true;
                    }
                else
                {
                    postortSökning = false;
                }
            }
            for (int i = 3; i < värdenEfterSplit.Length; i+=6)
            {
                if(värdenEfterSplit[i].Contains(namnelleradress) && postortSökning == false)
                {
                    form.lstbResultat.Items.Add(värdenEfterSplit[i-3]);
                }
            }
        }

        public string visainfo(sokning form)
        {
            var lines = File.ReadAllLines(@"C:\Users\Mario\Desktop\adressbok.txt").Where(arg => !string.IsNullOrWhiteSpace(arg));
            File.WriteAllLines(@"C:\Users\Mario\Desktop\adressbok.txt", lines);

            string[] värdenEfterSplit = allavärden.Split(Environment.NewLine.ToCharArray());

            string information;
            string namn;
            string adress;
            string postnummer;
            string postort;
            string telefon;
            string mail;
            uppdaterainfoForm formuppdaterainfo = new uppdaterainfoForm();
            for (int i = 0; i < värdenEfterSplit.Length; i++)
            {
                if (form.lstbResultat.SelectedItem.ToString().Contains("\r\n"))
                {
                    string värdeNamnSökning = form.lstbResultat.SelectedItem.ToString().Replace("\r\n", "");
                    if (värdenEfterSplit[i].Contains(värdeNamnSökning))
                    {
                        information = värdenEfterSplit[i];
                        string[] info = information.Split(':');
                        namn = info[0];
                        adress = info[1];
                        postnummer = info[2];
                        postort = info[3];
                        telefon = info[4];
                        mail = info[5];

                        formuppdaterainfo.txtNamn.Text = namn.ToString();
                        formuppdaterainfo.txtNamn.ReadOnly = true;
                        formuppdaterainfo.txtAdress.Text = adress.ToString();
                        formuppdaterainfo.txtAdress.ReadOnly = true;
                        formuppdaterainfo.txtPostnummer.Text = postnummer.ToString();
                        formuppdaterainfo.txtPostnummer.ReadOnly = true;
                        formuppdaterainfo.txtPostort.Text = postort.ToString();
                        formuppdaterainfo.txtPostort.ReadOnly = true;
                        formuppdaterainfo.txtTelefon.Text = telefon.ToString();
                        formuppdaterainfo.txtTelefon.ReadOnly = true;
                        formuppdaterainfo.txtMail.Text = mail.ToString();
                        formuppdaterainfo.txtMail.ReadOnly = true;
                        formuppdaterainfo.btnUppdatera.Enabled = false;
                        formuppdaterainfo.Show();

                        return information;

                    }
                }
                else if (värdenEfterSplit[i].Contains(form.lstbResultat.SelectedItem.ToString()))
                {
                    information = värdenEfterSplit[i];
                    string[] info = information.Split(':');
                    namn = info[0];
                    adress = info[1];
                    postnummer = info[2];
                    postort = info[3];
                    telefon = info[4];
                    mail = info[5];

                    formuppdaterainfo.txtNamn.Text = namn.ToString();
                    formuppdaterainfo.txtNamn.ReadOnly = true;
                    formuppdaterainfo.txtAdress.Text = adress.ToString();
                    formuppdaterainfo.txtAdress.ReadOnly = true;
                    formuppdaterainfo.txtPostnummer.Text = postnummer.ToString();
                    formuppdaterainfo.txtPostnummer.ReadOnly = true;
                    formuppdaterainfo.txtPostort.Text = postort.ToString();
                    formuppdaterainfo.txtPostort.ReadOnly = true;
                    formuppdaterainfo.txtTelefon.Text = telefon.ToString();
                    formuppdaterainfo.txtTelefon.ReadOnly = true;
                    formuppdaterainfo.txtMail.Text = mail.ToString();
                    formuppdaterainfo.txtMail.ReadOnly = true;
                    formuppdaterainfo.btnUppdatera.Enabled = false;
                    formuppdaterainfo.Show();

                    return information;

                }
            }
            information = "";
            return information;
        }

        public void uppdaterainfo(sokning form)
        {

            {
                var lines = File.ReadAllLines(@"C:\Users\Mario\Desktop\adressbok.txt").Where(arg => !string.IsNullOrWhiteSpace(arg));
                File.WriteAllLines(@"C:\Users\Mario\Desktop\adressbok.txt", lines);

                string[] värdenEfterSplit = allavärden.Split(Environment.NewLine.ToCharArray());

                string information;
                string namn;
                string adress;
                string postnummer;
                string postort;
                string telefon;
                string mail;
                uppdaterainfoForm formuppdaterainfo = new uppdaterainfoForm();
                for (int i = 0; i < värdenEfterSplit.Length; i++)
                {
                    if (form.lstbResultat.SelectedItem.ToString().Contains("\r\n"))
                    {
                        string värdeNamnSökning = form.lstbResultat.SelectedItem.ToString().Replace("\r\n", "");
                        if (värdenEfterSplit[i].Contains(värdeNamnSökning))
                        {
                            information = värdenEfterSplit[i];
                            string[] info = information.Split(':');
                            namn = info[0];
                            adress = info[1];
                            postnummer = info[2];
                            postort = info[3];
                            telefon = info[4];
                            mail = info[5];

                            formuppdaterainfo.txtNamn.Text = namn.ToString();
                            formuppdaterainfo.txtAdress.Text = adress.ToString();
                            formuppdaterainfo.txtPostnummer.Text = postnummer.ToString();
                            formuppdaterainfo.txtPostort.Text = postort.ToString();
                            formuppdaterainfo.txtTelefon.Text = telefon.ToString();
                            formuppdaterainfo.txtMail.Text = mail.ToString();
                            formuppdaterainfo.uppgiftersomskauppdateras = namn.ToString() + ":" + adress.ToString() + ":" + postnummer.ToString() + ":" + postort.ToString() + ":" + telefon.ToString() + ":" + mail.ToString() + ":";
                            formuppdaterainfo.Show();


                        }
                    }
                    else if (värdenEfterSplit[i].Contains(form.lstbResultat.SelectedItem.ToString()))
                    {
                        information = värdenEfterSplit[i];
                        string[] info = information.Split(':');
                        namn = info[0];
                        adress = info[1];
                        postnummer = info[2];
                        postort = info[3];
                        telefon = info[4];
                        mail = info[5];

                        formuppdaterainfo.txtNamn.Text = namn.ToString();
                        formuppdaterainfo.txtAdress.Text = adress.ToString();
                        formuppdaterainfo.txtPostnummer.Text = postnummer.ToString();
                        formuppdaterainfo.txtPostort.Text = postort.ToString();
                        formuppdaterainfo.txtTelefon.Text = telefon.ToString();
                        formuppdaterainfo.txtMail.Text = mail.ToString();
                        formuppdaterainfo.uppgiftersomskauppdateras = namn.ToString() + ":" + adress.ToString() + ":" + postnummer.ToString() + ":" + postort.ToString() + ":" + telefon.ToString() + ":" + mail.ToString() + ":";
                        formuppdaterainfo.Show();

                    }
                }
            }
        }

        public void raderainfo(sokning form)
        {
            var lines = File.ReadAllLines(@"C:\Users\Mario\Desktop\adressbok.txt").Where(arg => !string.IsNullOrWhiteSpace(arg));
            File.WriteAllLines(@"C:\Users\Mario\Desktop\adressbok.txt", lines);

            string[] värdenEfterSplit = allavärden.Split(Environment.NewLine.ToCharArray());
            string information;

            for (int i = 0; i < värdenEfterSplit.Length; i++)
            {

                if (form.lstbResultat.SelectedItem.ToString().Contains("\r\n"))
                {
                    string värdeNamnSökning = form.lstbResultat.SelectedItem.ToString().Replace("\r\n", "");
                    if (värdenEfterSplit[i].Contains(värdeNamnSökning))
                    {
                        information = värdenEfterSplit[i];
                        int position = Array.IndexOf(värdenEfterSplit, information);
                        var file = new List<string>(värdenEfterSplit);
                        file.RemoveAt(position);
                        File.WriteAllLines(@"C:\Users\Mario\Desktop\adressbok.txt", file.ToArray());
                    }
                }
                else if (värdenEfterSplit[i].Contains(form.lstbResultat.SelectedItem.ToString()))
                {
                    information = värdenEfterSplit[i];

                    int position = Array.IndexOf(värdenEfterSplit, information);
                    var file = new List<string>(värdenEfterSplit);
                    file.RemoveAt(position);
                    File.WriteAllLines(@"C:\Users\Mario\Desktop\adressbok.txt", file.ToArray());

                }
                var line = File.ReadAllLines(@"C:\Users\Mario\Desktop\adressbok.txt").Where(arg => !string.IsNullOrWhiteSpace(arg));
                File.WriteAllLines(@"C:\Users\Mario\Desktop\adressbok.txt", line);
            }
        }
    }
}
