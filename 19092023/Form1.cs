﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19092023
{
    public partial class Form1 : Form
    {
        public struct prodotto
        {
            public string nome;
            public float prezzo;
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


        private void Aggiungi_Click(object sender, EventArgs e)
        {
            p[dim].nome = Nome.Text;
            p[dim].prezzo = float.Parse(Prezzo.Text);
            dim++;
            MessageBox.Show("Aggiunto");
            Nome.Clear();
            Prezzo.Clear();
        }
        public string prodString(prodotto p)
        {
            return "Nome:" + p.nome + " prezzo:" + p.prezzo.ToString();
        }
        public void visualizza(prodotto[] pp)
        {
            ElencoProdotti.Items.Clear();
            for (int i = 0; i < dim; i++)

            {
                ElencoProdotti.Items.Add(prodString(pp[i]));


            }
        }

        private void Visual_Click(object sender, EventArgs e)
        {

            visualizza(p);
        }

        private void Modifica_Click(object sender, EventArgs e)
        {
            string Ricerc = Ricerca.Text;
            for (int i = 0; i < p.Length; ++i)
            {
                if (p[i].nome == Ricerc)
                {
                    p[i].nome = NuovoNome.Text;
                    MessageBox.Show("Modificato");
                    break;
                }
            }
        }
    }
}

