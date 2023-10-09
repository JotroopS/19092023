using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19092023
{
    public partial class Form1 : Form
    {
        public struct prodotto
        {
            public string nome;
            public double prezzo;
        }
        public prodotto[] p;
        public int dim;
        public Form1()
        {
            InitializeComponent();
            p = new prodotto[100];
            dim = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        public void Aggiungi_Click(object sender, EventArgs e)
        {
            p[dim].nome = Nome.Text;
            p[dim].prezzo = double.Parse(Prezzo.Text);
            dim++;
            MessageBox.Show("Aggiunto");
            Nome.Clear();
            Prezzo.Clear();
            visualizza(p);
        }
        public string prodString(prodotto p)
        {
            return p.nome + ": " + p.prezzo.ToString() + "€";
        }
        public void visualizza(prodotto[] pp)
        {
            ElencoProdotti.Items.Clear();
            for (int i = 0; i < dim; i++)

            {
                ElencoProdotti.Items.Add(prodString(pp[i]));


            }
        }
        public string Ricerc;
        private void ModificaNome_Click(object sender, EventArgs e)
        {
            Ricerc = Ricerca.Text;
            for (int i = 0; i < p.Length; ++i)
            {
                if (p[i].nome == Ricerc)
                {
                    p[i].nome = NuovoNome.Text;
                    MessageBox.Show("Modificato");
                    Ricerca.Clear();
                    NuovoNome.Clear();
                    visualizza(p);
                    break;
                }
            }
        }
        private void ModificaPrezzo_Click(object sender, EventArgs e)
        {
            Ricerc = Ricerca.Text;
            for (int i = 0; i < p.Length; ++i)
            {
                if (p[i].nome == Ricerc)
                {
                    p[i].prezzo = double.Parse(NuovoPrezzo.Text);
                    MessageBox.Show("Modificato");
                    Ricerca.Clear();
                    NuovoPrezzo.Clear();
                    visualizza(p);
                    break;
                }
            }
        }

        private void Cancella_Click(object sender, EventArgs e)
        {
            
        }

        private void Ordina_Click(object sender, EventArgs e)
        {
            var prodottiOrdinati = p.Take(dim).OrderBy(item => item.nome).ToArray();
            Array.Copy(prodottiOrdinati, p, dim);
            visualizza(p);
        }

        private void Percent_Click(object sender, EventArgs e)
        {
            double percentuale = Convert.ToDouble(Perce.Text);
                for (int i = 0; i < dim; i++)
                {
                    p[i].prezzo += p[i].prezzo * (percentuale / 100);
                }
                visualizza(p);
                return;
        }
        private void Salva_Click(object sender, EventArgs e)
        {
                StreamWriter salva = new StreamWriter("Salva.Txt");
                for (int i = 0; i < dim; i++)
                {
                    salva.WriteLine(p[i].nome + ": " + p[i].prezzo + "€");
                }
                salva.Close();
                MessageBox.Show("File salvato");
        }
        private void Leggi_Click(object sender, EventArgs e)
        {

            ElencoProdotti.Items.Clear();
            string lettura;
            if (File.Exists("Salva.txt"))
            {
                    StreamReader leggi = new StreamReader("Salva.Txt");
                    lettura = leggi.ReadLine();
                    while(lettura != null)
                    {
                        ElencoProdotti.Items.Add(lettura);
                        lettura = leggi.ReadLine();
                        dim++;
                    }
                    leggi.Close();
                    MessageBox.Show("File letto correttamente");
            }
        }

        private void Somma_Click(object sender, EventArgs e)
        {
            double tot = 0;
            for (int i = 0; i < dim; i++)
            {
                tot += p[i].prezzo;
            }
            MessageBox.Show("Il prezzo totale è " + tot + "€");
        }

        private void Minimo_Click(object sender, EventArgs e)
        {
            double minf = 100000000000000000, min, min1;
            for (int i = 0; i < dim; i++)
            {
                for (int j = i + 1; j < dim; j++)
                {
                   min = p[i].prezzo;
                    min1 = p[j].prezzo;
                    if(min < min1)
                    {
                        if (minf > min)
                        {
                            minf = min;
                        }
                    }
                    else
                    {
                        if (minf > min1)
                        {
                            minf = min1;
                        }
                    }
                }
            }
            MessageBox.Show("Il prezzo minimo è " + minf + "€");
        }

        private void Massimo_Click(object sender, EventArgs e)
        {
            double maxf = 0, max, max1;
            for (int i = 0; i < dim; i++)
            {
                for (int j = i + 1; j < dim; j++)
                {
                    max = p[i].prezzo;
                    max1 = p[j].prezzo;
                    if (max > max1)
                    {
                        if (maxf < max)
                        {
                            maxf = max;
                        }
                    }
                    else
                    {
                        if (maxf < max1)
                        {
                            maxf = max1;
                        }
                    }
                }
            }
            MessageBox.Show("Il prezzo massimo è " + maxf + "€");
        }
    }
}


