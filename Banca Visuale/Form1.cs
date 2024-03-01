using Banca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banca_Visuale
{
    public partial class Form1 : Form
    {
        Banca banca;
        Conto conto;
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            

        }

        private void creaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conto = new Conto(Convert.ToInt32(TB_ID.Text), TB_NOME.Text, TB_COGNOME.Text);
            TB_SALDO.Text = conto.Saldo.ToString();
            listBox1.Items.Add(conto.ToString());
            //conto = new Conto(1, "Federico", "Melon");
            //listBox1.Items.Add(conto.ToString());
        }

        private void movimentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            conto.Movimento(3);
            listBox1.Items.Add(conto.ToString());
        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TB_SALDO_TextChanged(object sender, EventArgs e)
        {

        }

        private void visualizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            banca.AggiuntiConti(new Conto(Banca.ID, "Mario", "Rossi"));
            banca.AggiuntiConti(new Conto(Banca.ID, "Giuseppe", "Verdi"));
            banca.AggiuntiConti(new Conto(Banca.ID, "Gigi", "Piastrella"));

            foreach (Conto c in banca.Correntisti())
            {
                listBox1.Items.Add(c);
            }
        }

        private void TB_COGNONE_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB_NOME_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
