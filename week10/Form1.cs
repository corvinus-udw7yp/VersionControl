using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using week10.Entities;

namespace week10
{
    public partial class Form1 : Form
    {
        List<Person> Population = new List<Person>();
        List<Person> MalePopulation = new List<Person>();
        List<Person> FemalePopulation = new List<Person>();
        List<BirthProbability> BirthProbabilities = new List<BirthProbability>();
        List<DeathProbability> DeathProbabilities = new List<DeathProbability>();

        Random rng = new Random(1234);

        public Form1()
        {
            
            InitializeComponent();


            

            
        }

        public void Simulation(string fajlnev,decimal zaroev)
        {
            richTextBoxResults.SelectAll();
            richTextBoxResults.SelectedText = "";
            Population = GetPopulation(@fajlnev);
            BirthProbabilities = GetBirthProbabilities(@"C:\Temp\születés.csv");
            DeathProbabilities = GetDeathProbabilities(@"C:\Temp\halál.csv");
            // Végigmegyünk a vizsgált éveken
            for (int year = 2005; year <= zaroev; year++)
            {
                // Végigmegyünk az összes személyen
                for (int i = 0; i < Population.Count; i++)
                {
                    // Ide jön a szimulációs lépés
                    SimStep(year, Population[i]);
                }

                int nbrOfMales = (from x in Population
                                  where x.Gender == Gender.Male && x.IsAlive
                                  select x).Count();
                int nbrOfFemales = (from x in Population
                                    where x.Gender == Gender.Female && x.IsAlive
                                    select x).Count();
                Console.WriteLine(
                    string.Format("Év:{0} Fiúk:{1} Lányok:{2}", year, nbrOfMales, nbrOfFemales));
            }
        }

        public void DisplayResults(decimal zaroev)
        {
            // Végigmegyünk a vizsgált éveken
            for (int year = 2005; year <= zaroev; year++)
            {
                // Végigmegyünk az összes férfi személyen
                int fiuk = MalePopulation.Count();
                // Végigmegyünk az összes női személyen
                int lanyok = FemalePopulation.Count();

                richTextBoxResults.AppendText("Szimulációs év: "+zaroev.ToString()+"\n\tFiúk: "+fiuk.ToString()+ "\n\tLányok: "+lanyok.ToString()+"\n\n");
            }
        }

        public List<Person> GetPopulation(string csvpath)
        {
            List<Person> population = new List<Person>();

            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    population.Add(new Person()
                    {
                        BirthYear = int.Parse(line[0]),
                        Gender = (Gender)Enum.Parse(typeof(Gender), line[1]),
                        NbrOfChildren = int.Parse(line[2])
                    });
                }
            }

            return population;
        }

        public List<BirthProbability> GetBirthProbabilities(string csvpath)
        {
            List<BirthProbability> birthprobabilities = new List<BirthProbability>();

            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    birthprobabilities.Add(new BirthProbability()
                    {
                        Age = int.Parse(line[0]),
                        NbrOfChildren = int.Parse(line[1]),
                        P = double.Parse(line[2]),
                    });
                }
            }

            return birthprobabilities;
        }

        public List<DeathProbability> GetDeathProbabilities(string csvpath)
        {
            List<DeathProbability> deatprobabilities = new List<DeathProbability>();

            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    deatprobabilities.Add(new DeathProbability()
                    {
                        Gender = (Gender)Enum.Parse(typeof(Gender), line[0]),
                        Age = int.Parse(line[1]),
                        P = double.Parse(line[2]),
                    });
                }
            }

            return deatprobabilities;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SimStep(int year, Person person)
        {
            //Ha halott akkor kihagyjuk, ugrunk a ciklus következő lépésére
            if (!person.IsAlive) return;

            // Letároljuk az életkort, hogy ne kelljen mindenhol újraszámolni
            byte age = (byte)(year - person.BirthYear);

            // Halál kezelése
            // Halálozási valószínűség kikeresése
            double pDeath = (from x in DeathProbabilities
                             where x.Gender == person.Gender && x.Age == age
                             select x.P).FirstOrDefault();
            // Meghal a személy?
            if (rng.NextDouble() <= pDeath)
                person.IsAlive = false;

            //Születés kezelése - csak az élő nők szülnek
            if (person.IsAlive && person.Gender == Gender.Female)
            {
                //Szülési valószínűség kikeresése
                double pBirth = (from x in BirthProbabilities
                                 where x.Age == age
                                 select x.P).FirstOrDefault();
                //Születik gyermek?
                if (rng.NextDouble() <= pBirth)
                {
                    Person újszülött = new Person();
                    újszülött.BirthYear = year;
                    újszülött.NbrOfChildren = 0;
                    újszülött.Gender = (Gender)(rng.Next(1, 3));
                    Population.Add(újszülött);
                    if (újszülött.Gender == Gender.Female)
                    {
                        FemalePopulation.Add(újszülött);
                    }
                    else
                    {
                        MalePopulation.Add(újszülött);
                    }
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Simulation(labelNepessegFajl.Text, numericUpDownZaroev.Value);
            DisplayResults(numericUpDownZaroev.Value);
        }

        private void numericUpDownZaroev_ValueChanged(object sender, EventArgs e)
        {

        }

        private void labelZaroev_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // Példányosít egyet a windows standard fájlmegnyitó ablakából
            OpenFileDialog ofd = new OpenFileDialog();

            // Opcionális rész
            ofd.InitialDirectory = Application.StartupPath; // Alapértelmezetten az exe fájlunk mappája fog megnyílni a dialógus ablakban
            ofd.Filter = "Comma Seperated Values (*.csv)|*.csv"; // A kiválasztható fájlformátumokat adjuk meg ezzel a sorral. Jelen esetben csak a csv-t fogadjuk el
            ofd.DefaultExt = "csv"; // A csv lesz az alapértelmezetten kiválasztott kiterjesztés
            ofd.AddExtension = true; // Ha ez igaz, akkor hozzáírja a megadott fájlnévhez a kiválasztott kiterjesztést, de érzékeli, ha a felhasználó azt is beírta és nem fogja duplán hozzáírni

            // Ez a sor megnyitja a dialógus ablakot és csak akkor engedi tovább futni a kódot, ha az ablakot az OK gombbal zárták be
            if (ofd.ShowDialog() != DialogResult.OK) labelNepessegFajl.Text = ofd.FileName;
                
        }

        private void labelNepessegFajl_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNepessegFajl_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
