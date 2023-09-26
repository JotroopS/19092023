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
            this.Visual = new System.Windows.Forms.Button();
            this.Modifica = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NuovoNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Ricerca = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(2, 19);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(143, 20);
            this.Nome.TabIndex = 1;
            // 
            // q2
            // 
            this.q2.AutoSize = true;
            this.q2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q2.Location = new System.Drawing.Point(-1, 42);
            this.q2.Name = "q2";
            this.q2.Size = new System.Drawing.Size(54, 16);
            this.q2.TabIndex = 2;
            this.q2.Text = "Prezzo";
            // 
            // Prezzo
            // 
            this.Prezzo.Location = new System.Drawing.Point(2, 61);
            this.Prezzo.Name = "Prezzo";
            this.Prezzo.Size = new System.Drawing.Size(143, 20);
            this.Prezzo.TabIndex = 3;
            // 
            // Aggiungi
            // 
            this.Aggiungi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aggiungi.Location = new System.Drawing.Point(182, 19);
            this.Aggiungi.Name = "Aggiungi";
            this.Aggiungi.Size = new System.Drawing.Size(110, 62);
            this.Aggiungi.TabIndex = 4;
            this.Aggiungi.Text = "Aggiungi";
            this.Aggiungi.UseVisualStyleBackColor = true;
            this.Aggiungi.Click += new System.EventHandler(this.Aggiungi_Click);
            // 
            // ElencoProdotti
            // 
            this.ElencoProdotti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElencoProdotti.FormattingEnabled = true;
            this.ElencoProdotti.ItemHeight = 20;
            this.ElencoProdotti.Location = new System.Drawing.Point(487, 33);
            this.ElencoProdotti.Name = "ElencoProdotti";
            this.ElencoProdotti.Size = new System.Drawing.Size(286, 384);
            this.ElencoProdotti.TabIndex = 5;
            // 
            // Visual
            // 
            this.Visual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Visual.Location = new System.Drawing.Point(298, 16);
            this.Visual.Name = "Visual";
            this.Visual.Size = new System.Drawing.Size(110, 65);
            this.Visual.TabIndex = 6;
            this.Visual.Text = "Visualizza";
            this.Visual.UseVisualStyleBackColor = true;
            this.Visual.Click += new System.EventHandler(this.Visual_Click);
            // 
            // Modifica
            // 
            this.Modifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modifica.Location = new System.Drawing.Point(235, 96);
            this.Modifica.Name = "Modifica";
            this.Modifica.Size = new System.Drawing.Size(110, 62);
            this.Modifica.TabIndex = 7;
            this.Modifica.Text = "Modifica";
            this.Modifica.UseVisualStyleBackColor = true;
            this.Modifica.Click += new System.EventHandler(this.Modifica_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Inserisci il nuovo nome";
            // 
            // NuovoNome
            // 
            this.NuovoNome.Location = new System.Drawing.Point(2, 157);
            this.NuovoNome.Name = "NuovoNome";
            this.NuovoNome.Size = new System.Drawing.Size(162, 20);
            this.NuovoNome.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-1, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Inserisci il prodotto da cercare";
            // 
            // Ricerca
            // 
            this.Ricerca.Location = new System.Drawing.Point(2, 115);
            this.Ricerca.Name = "Ricerca";
            this.Ricerca.Size = new System.Drawing.Size(215, 20);
            this.Ricerca.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ricerca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NuovoNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Modifica);
            this.Controls.Add(this.Visual);
            this.Controls.Add(this.ElencoProdotti);
            this.Controls.Add(this.Aggiungi);
            this.Controls.Add(this.Prezzo);
            this.Controls.Add(this.q2);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Button Visual;
        private System.Windows.Forms.Button Modifica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NuovoNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Ricerca;
    }
}

