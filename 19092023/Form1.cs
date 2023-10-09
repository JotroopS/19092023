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
        public void aggiorna(int dim)
        {
            ElencoProdotti.Items.Clear();
            for (int i = 0; i < dim; i++)

            {
                ElencoProdotti.Items.Add(p[i].nome + ": " + p[i].prezzo.ToString() + "€");


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
            Ricerc = Ricerca.Text;
            for (int i = 0; i < dim; ++i)
            {
                if (p[i].nome == Ricerc)
                {
                    for (int j = i; j> dim -1; j++)
                    {
                        p[j] = p[j + i];
                    }
                    dim--;
                    MessageBox.Show("Eliminato");
                    aggiorna(dim);
                    return;
                }
            }
        }

        private void Ordina_Click(object sender, EventArgs e)
        {
            
        }

        private void Percent_Click(object sender, EventArgs e)
        {
            double percentuale; 
            if(double.TryParse(Perce.Text, out percentuale))
            {
                for(int i = 0; i < dim; i++)
                {
                    p[i].prezzo += p[i].prezzo * (percentuale / 100); 
                }
                aggiorna(dim);
                return;
            }
            {

            }
        }
        private void Salva_Click(object sender, EventArgs e)
        {
            using (StreamWriter salva = new StreamWriter("Salva.Txt")
            { 
                for ( int i = 0; i < dim;i++)
                {
                    salva.WriteLine(p[i].nome + ": " + p[i].prezzo);
                }
            }
        }
    private void Leggi_Click(object sender, EventArgs e)
    {
        if (File.Exists("Salva.txt"))
        {
            using (StreamReader leggi = new StreamReader("Salva.Txt")
            {

            }
        }
    }
}


