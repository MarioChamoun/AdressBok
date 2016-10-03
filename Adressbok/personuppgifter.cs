using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Adressbok
{
    public class personuppgifter
    {
        public string namn { get; set; }
        public string gatuadress { get; set; }
        public string postnummer { get; set; }
        public string postort { get; set; }
        public string telefon { get; set; }
        public string mailadress { get; set; }
        public string txtadressbok { get; set; }
        public bool fel { get; set; }
        public string felinfo { get; set; }

        public void registrera()
        {
            //Raderar alla tomma rader
            var lines = File.ReadAllLines(@"C:\Users\Mario\Desktop\adressbok.txt").Where(arg => !string.IsNullOrWhiteSpace(arg));
            File.WriteAllLines(@"C:\Users\Mario\Desktop\adressbok.txt", lines);

            if (kontrollera() == true)
            {
                string seperera = ":";
                string path = @"C:\Users\Mario\Desktop\adressbok.txt";
                StreamWriter writer = new StreamWriter(path, true);
                writer.Write(namn + seperera + gatuadress + seperera + postnummer + seperera + postort + seperera + telefon + seperera + mailadress + seperera + Environment.NewLine);
                writer.Close();
            } else
            {
                fel = true;

            }
        }

        public void uppdatera(string UppgifterSomSkaUppdateras, string NyaVärdet)
        {

            var lines = File.ReadAllLines(@"C:\Users\Mario\Desktop\adressbok.txt").Where(arg => !string.IsNullOrWhiteSpace(arg));
            File.WriteAllLines(@"C:\Users\Mario\Desktop\adressbok.txt", lines);

            string allavärden = File.ReadAllText(@"C:\Users\Mario\Desktop\adressbok.txt");
            string[] värdenEfterSplit = allavärden.Split(Environment.NewLine.ToCharArray());
            string information;

            for (int i = 0; i < värdenEfterSplit.Length; i++)
            {

                if (UppgifterSomSkaUppdateras.Contains("\r\n"))
                {
                    string NamnSökning = UppgifterSomSkaUppdateras.ToString().Replace("\r\n", ""); //Tar bort onödiga tecken
                    if (värdenEfterSplit[i].Contains(NamnSökning))
                    {
                        information = värdenEfterSplit[i];
                        int position = Array.IndexOf(värdenEfterSplit, information); //Tar reda på positionen för infot som ska uppdateras
                        var file = new List<string>(värdenEfterSplit);
                        file.RemoveAt(position);
                        file.Insert(position, NyaVärdet);
                        File.WriteAllLines(@"C:\Users\Mario\Desktop\adressbok.txt", file.ToArray());
                    }
                }
                else if (värdenEfterSplit[i].Contains(UppgifterSomSkaUppdateras))
                {
                    information = värdenEfterSplit[i];

                    int position = Array.IndexOf(värdenEfterSplit, information);
                    var file = new List<string>(värdenEfterSplit);
                    file.RemoveAt(position);
                    file.Insert(position, NyaVärdet);
                    File.WriteAllLines(@"C:\Users\Mario\Desktop\adressbok.txt", file.ToArray());

                }
                var line = File.ReadAllLines(@"C:\Users\Mario\Desktop\adressbok.txt").Where(arg => !string.IsNullOrWhiteSpace(arg));
                File.WriteAllLines(@"C:\Users\Mario\Desktop\adressbok.txt", line);
            }
        }

        public bool kontrollera()
        {
            if(!mailadress.Contains("@") || !mailadress.Contains("."))
            {
                felinfo = "mail";
                return false;
            } else if(postnummer.Length != 5)
            {
                felinfo = "postnummer";
                return false;
            } else if(telefon.Length != 10)
            {
                felinfo = "telefonnummer";
                return false;
            } else
            {
                felinfo = "";
                return true;
            }
        }

    }
}
