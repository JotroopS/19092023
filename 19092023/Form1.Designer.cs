namespace _19092023
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.TextBox();
            this.q2 = new System.Windows.Forms.Label();
            this.Prezzo = new System.Windows.Forms.TextBox();
            this.Aggiungi = new System.Windows.Forms.Button();
            this.ElencoProdotti = new System.Windows.Forms.ListBox();
            this.ModificaNome = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NuovoNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Ricerca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NuovoPrezzo = new System.Windows.Forms.TextBox();
            this.ModificaPrezzo = new System.Windows.Forms.Button();
            this.Cancella = new System.Windows.Forms.Button();
            this.Ordina = new System.Windows.Forms.Button();
            this.Percent = new System.Windows.Forms.Button();
            this.Perce = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Salva = new System.Windows.Forms.Button();
            this.Leggi = new System.Windows.Forms.Button();
            this.Somma = new System.Windows.Forms.Button();
            this.Minimo = new System.Windows.Forms.Button();
            this.Massimo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(3, 23);
            this.Nome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(189, 22);
            this.Nome.TabIndex = 1;
            // 
            // q2
            // 
            this.q2.AutoSize = true;
            this.q2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q2.Location = new System.Drawing.Point(-1, 52);
            this.q2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.q2.Name = "q2";
            this.q2.Size = new System.Drawing.Size(68, 20);
            this.q2.TabIndex = 2;
            this.q2.Text = "Prezzo";
            // 
            // Prezzo
            // 
            this.Prezzo.Location = new System.Drawing.Point(3, 75);
            this.Prezzo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Prezzo.Name = "Prezzo";
            this.Prezzo.Size = new System.Drawing.Size(189, 22);
            this.Prezzo.TabIndex = 3;
            // 
            // Aggiungi
            // 
            this.Aggiungi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aggiungi.Location = new System.Drawing.Point(313, 23);
            this.Aggiungi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Aggiungi.Name = "Aggiungi";
            this.Aggiungi.Size = new System.Drawing.Size(156, 72);
            this.Aggiungi.TabIndex = 4;
            this.Aggiungi.Text = "Aggiungi";
            this.Aggiungi.UseVisualStyleBackColor = true;
            this.Aggiungi.Click += new System.EventHandler(this.Aggiungi_Click);
            // 
            // ElencoProdotti
            // 
            this.ElencoProdotti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElencoProdotti.FormattingEnabled = true;
            this.ElencoProdotti.ItemHeight = 25;
            this.ElencoProdotti.Location = new System.Drawing.Point(640, 34);
            this.ElencoProdotti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ElencoProdotti.Name = "ElencoProdotti";
            this.ElencoProdotti.Size = new System.Drawing.Size(426, 454);
            this.ElencoProdotti.TabIndex = 5;
            // 
            // ModificaNome
            // 
            this.ModificaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificaNome.Location = new System.Drawing.Point(313, 118);
            this.ModificaNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModificaNome.Name = "ModificaNome";
            this.ModificaNome.Size = new System.Drawing.Size(156, 71);
            this.ModificaNome.TabIndex = 7;
            this.ModificaNome.Text = "Modifica il nome";
            this.ModificaNome.UseVisualStyleBackColor = true;
            this.ModificaNome.Click += new System.EventHandler(this.ModificaNome_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Inserisci il nuovo nome";
            // 
            // NuovoNome
            // 
            this.NuovoNome.Location = new System.Drawing.Point(3, 193);
            this.NuovoNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NuovoNome.Name = "NuovoNome";
            this.NuovoNome.Size = new System.Drawing.Size(215, 22);
            this.NuovoNome.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-1, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Inserisci il prodotto da cercare";
            // 
            // Ricerca
            // 
            this.Ricerca.Location = new System.Drawing.Point(3, 142);
            this.Ricerca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Ricerca.Name = "Ricerca";
            this.Ricerca.Size = new System.Drawing.Size(285, 22);
            this.Ricerca.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-1, 222);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Inserisci il nuovo prezzo";
            // 
            // NuovoPrezzo
            // 
            this.NuovoPrezzo.Location = new System.Drawing.Point(3, 245);
            this.NuovoPrezzo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NuovoPrezzo.Name = "NuovoPrezzo";
            this.NuovoPrezzo.Size = new System.Drawing.Size(225, 22);
            this.NuovoPrezzo.TabIndex = 16;
            // 
            // ModificaPrezzo
            // 
            this.ModificaPrezzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificaPrezzo.Location = new System.Drawing.Point(313, 194);
            this.ModificaPrezzo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModificaPrezzo.Name = "ModificaPrezzo";
            this.ModificaPrezzo.Size = new System.Drawing.Size(156, 73);
            this.ModificaPrezzo.TabIndex = 17;
            this.ModificaPrezzo.Text = "Modifica il prezzo";
            this.ModificaPrezzo.UseVisualStyleBackColor = true;
            this.ModificaPrezzo.Click += new System.EventHandler(this.ModificaPrezzo_Click);
            // 
            // Cancella
            // 
            this.Cancella.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancella.Location = new System.Drawing.Point(313, 275);
            this.Cancella.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cancella.Name = "Cancella";
            this.Cancella.Size = new System.Drawing.Size(156, 81);
            this.Cancella.TabIndex = 18;
            this.Cancella.Text = "Elimina";
            this.Cancella.UseVisualStyleBackColor = true;
            this.Cancella.Click += new System.EventHandler(this.Cancella_Click);
            // 
            // Ordina
            // 
            this.Ordina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ordina.Location = new System.Drawing.Point(313, 366);
            this.Ordina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Ordina.Name = "Ordina";
            this.Ordina.Size = new System.Drawing.Size(156, 81);
            this.Ordina.TabIndex = 19;
            this.Ordina.Text = "Ordina";
            this.Ordina.UseVisualStyleBackColor = true;
            this.Ordina.Click += new System.EventHandler(this.Ordina_Click);
            // 
            // Percent
            // 
            this.Percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Percent.Location = new System.Drawing.Point(477, 366);
            this.Percent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Percent.Name = "Percent";
            this.Percent.Size = new System.Drawing.Size(156, 81);
            this.Percent.TabIndex = 20;
            this.Percent.Text = "Aggiungi/sottrai";
            this.Percent.UseVisualStyleBackColor = true;
            this.Percent.Click += new System.EventHandler(this.Percent_Click);
            // 
            // Perce
            // 
            this.Perce.Location = new System.Drawing.Point(3, 334);
            this.Perce.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Perce.Name = "Perce";
            this.Perce.Size = new System.Drawing.Size(215, 22);
            this.Perce.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-1, 310);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Inserisci la percentuale";
            // 
            // Salva
            // 
            this.Salva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salva.Location = new System.Drawing.Point(477, 23);
            this.Salva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Salva.Name = "Salva";
            this.Salva.Size = new System.Drawing.Size(156, 72);
            this.Salva.TabIndex = 23;
            this.Salva.Text = "Salva";
            this.Salva.UseVisualStyleBackColor = true;
            this.Salva.Click += new System.EventHandler(this.Salva_Click);
            // 
            // Leggi
            // 
            this.Leggi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Leggi.Location = new System.Drawing.Point(477, 118);
            this.Leggi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Leggi.Name = "Leggi";
            this.Leggi.Size = new System.Drawing.Size(156, 72);
            this.Leggi.TabIndex = 24;
            this.Leggi.Text = "LeggiFile";
            this.Leggi.UseVisualStyleBackColor = true;
            this.Leggi.Click += new System.EventHandler(this.Leggi_Click);
            // 
            // Somma
            // 
            this.Somma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Somma.Location = new System.Drawing.Point(313, 461);
            this.Somma.Name = "Somma";
            this.Somma.Size = new System.Drawing.Size(156, 81);
            this.Somma.TabIndex = 25;
            this.Somma.Text = "Somma totale";
            this.Somma.UseVisualStyleBackColor = true;
            this.Somma.Click += new System.EventHandler(this.Somma_Click);
            // 
            // Minimo
            // 
            this.Minimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimo.Location = new System.Drawing.Point(477, 193);
            this.Minimo.Name = "Minimo";
            this.Minimo.Size = new System.Drawing.Size(156, 74);
            this.Minimo.TabIndex = 26;
            this.Minimo.Text = "Prezzo minimo";
            this.Minimo.UseVisualStyleBackColor = true;
            this.Minimo.Click += new System.EventHandler(this.Minimo_Click);
            // 
            // Massimo
            // 
            this.Massimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Massimo.Location = new System.Drawing.Point(477, 275);
            this.Massimo.Name = "Massimo";
            this.Massimo.Size = new System.Drawing.Size(156, 80);
            this.Massimo.TabIndex = 27;
            this.Massimo.Text = "Prezzo massimo";
            this.Massimo.UseVisualStyleBackColor = true;
            this.Massimo.Click += new System.EventHandler(this.Massimo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Massimo);
            this.Controls.Add(this.Minimo);
            this.Controls.Add(this.Somma);
            this.Controls.Add(this.Leggi);
            this.Controls.Add(this.Salva);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Perce);
            this.Controls.Add(this.Percent);
            this.Controls.Add(this.Ordina);
            this.Controls.Add(this.Cancella);
            this.Controls.Add(this.ModificaPrezzo);
            this.Controls.Add(this.NuovoPrezzo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Ricerca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NuovoNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ModificaNome);
            this.Controls.Add(this.ElencoProdotti);
            this.Controls.Add(this.Aggiungi);
            this.Controls.Add(this.Prezzo);
            this.Controls.Add(this.q2);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.Label q2;
        private System.Windows.Forms.TextBox Prezzo;
        private System.Windows.Forms.Button Aggiungi;
        private System.Windows.Forms.ListBox ElencoProdotti;
        private System.Windows.Forms.Button ModificaNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NuovoNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Ricerca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NuovoPrezzo;
        private System.Windows.Forms.Button ModificaPrezzo;
        private System.Windows.Forms.Button Cancella;
        private System.Windows.Forms.Button Ordina;
        private System.Windows.Forms.Button Percent;
        private System.Windows.Forms.TextBox Perce;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Salva;
        private System.Windows.Forms.Button Leggi;
        private System.Windows.Forms.Button Somma;
        private System.Windows.Forms.Button Minimo;
        private System.Windows.Forms.Button Massimo;
    }
}

