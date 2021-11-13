using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            creaCelle();

            InziaPartita();
        }

        CelleSudoku[,] celle = new CelleSudoku[9, 9];

        private void creaCelle()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    celle[i, j] = new CelleSudoku();
                    celle[i, j].Font = new Font(SystemFonts.DefaultFont.FontFamily, 20);
                    celle[i, j].Size = new Size(50, 50);
                    celle[i, j].ForeColor = SystemColors.ControlDarkDark;
                    celle[i, j].Location = new Point(i * 50, j * 50);
                    celle[i, j].BackColor = ((i / 3) + (j / 3)) % 2 == 0 ? SystemColors.Control : Color.LightGray;
                    celle[i, j].FlatStyle = FlatStyle.Flat;
                    celle[i, j].FlatAppearance.BorderColor = Color.Black;
                    celle[i, j].X = i;
                    celle[i, j].Y = j;

                    celle[i, j].KeyPress += cell_keyPressed;

                    pnlGioco.Controls.Add(celle[i, j]);
                }
            }
        }

        private void cell_keyPressed(object sender, KeyPressEventArgs e)
        {
            CelleSudoku cella = sender as CelleSudoku;

            // Se la cella è bloccata non fa niente
            if (cella.IsLocked)
                return;

            int valore;

            // Controlla se l'input è un valore numerico e lo aggiunge alla cella solo se è valido
            if (int.TryParse(e.KeyChar.ToString(), out valore))
            {
                if (valore == 0)
                    cella.Clear();
                else
                    cella.Text = valore.ToString();

                cella.ForeColor = SystemColors.ControlDarkDark;
            }
        }
        
        private void InziaPartita()
        {
            Carica();

            int numeroCelleIniziale = 0;

            if (difficoltàFacile.Checked)
                numeroCelleIniziale = 45;
            else if (difficoltàMedia.Checked)
                numeroCelleIniziale = 30;
            else if (difficoltàDifficile.Checked)
                numeroCelleIniziale = 15;

            RiempiCelleIniziali(numeroCelleIniziale);
        }

        private void RiempiCelleIniziali(int numeroCelleIniziale)
        {
            for (int i = 0; i < numeroCelleIniziale; i++)
            {
                int rX = g.Next(9);
                int rY = g.Next(9);

                // Formatta e blocca le celle riempite automaticamente
                celle[rX, rY].Text = celle[rX, rY].Valore.ToString();
                celle[rX, rY].ForeColor = Color.Black;
                celle[rX, rY].IsLocked = true;
            }
        }

        private void Carica()
        {
            // svuota il contenuto di ogni cella
            foreach (CelleSudoku cell in celle)
            {
                cell.Valore = 0;
                cell.Clear();
            }

            //metodo ricorsivo per aggiungere un valore ad ogni cella
            TrovaValoreCella(0, -1);
        }

        Random g = new Random();

        private bool TrovaValoreCella(int i, int j)
        {
            if (++j > 8)
            {
                j = 0;

                if (++i > 8)
                    return true;
            }

            int num = 0;
            List<int> numRimasti = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // trova un valore adatto alle celle di ogni riga e colonna 
            do
            {
                // se non rimane nessun numero da aggiungere esce
                if (numRimasti.Count < 1)
                {
                    celle[i, j].Valore = 0;
                    return false;
                }

                num = numRimasti[g.Next(0, numRimasti.Count)];
                celle[i, j].Valore = num;

                // rimuove il valore aggiunto dalla lista
                numRimasti.Remove(num);
            }
            while (!NumeroValido(num, i, j) || !TrovaValoreCella(i, j));
            
            return true;
        }

        private bool NumeroValido(int value, int x, int y)
        {
            for (int i = 0; i < 9; i++)
            {
                // controllo celle verticale
                if (i != y && celle[x, i].Valore == value)
                    return false;

                // controllo celle orrizontale
                if (i != x && celle[i, y].Valore == value)
                    return false;
            }
            
            // controllo celle in ogni regione(zona 3x3)
            for (int i = x - (x % 3); i < x - (x % 3) + 3; i++)
            {
                for (int j = y - (y % 3); j < y - (y % 3) + 3; j++)
                {
                    if (i != x && j != y && celle[i, j].Valore == value)
                        return false;
                }
            }

            return true;
        }
        
        private void checkButton_Click(object sender, EventArgs e)
        {
            List<CelleSudoku> wrongCells = new List<CelleSudoku>();

            // cerca gli input sbagliati
            foreach (CelleSudoku cell in celle)
            {
                if (!string.Equals(cell.Valore.ToString(), cell.Text))
                {
                    wrongCells.Add(cell);
                }
            }

            // controlla se il giocatore ha vinto 
            if (wrongCells.Any())
            {
                // indica in rosso gli input sbagliati 
                wrongCells.ForEach(x => x.ForeColor = Color.Red);
                MessageBox.Show("Hai Sbagliato","Peccato");
            }
            else
            {
                MessageBox.Show("Hai vinto", "Congratulazioni");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            foreach (CelleSudoku cell in celle)
            {
                // pulisce ogni cella modificabile dall'utente
                if (cell.IsLocked == false)
                    cell.Clear();
            }
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            InziaPartita();
        }
    }
}
