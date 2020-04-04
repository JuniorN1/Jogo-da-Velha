using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogo_da_velha
{
    public partial class velha : Form
    {
        Form start;
      
        public velha()
        {
            InitializeComponent();
          
        }
       
        private void jogodavelha_Load(object sender, EventArgs e)
        {
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(p_1.Text=="" || p_2.Text == "")
            {
                MessageBox.Show("VOCE DEVE INSERIR O NOME DOS JOGADORES PARA CONTINUAR!!");
            }
            else
            {
                start = new Inicio();
                start.Show();               
                (start as Inicio).pp_1.Text = p_1.Text;
                (start as Inicio).pp_2.Text = p_2.Text;
                (start as Inicio).playGame = this;
                this.Hide();
            }
        }

        private void p_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PROGRAMA CRIADO COM INTUITO DE DEMOSTRA APLICAÇÕES PARA WINDOWS FEITO NO VISUAL STUDIO 2017!\n \n\n" +
                "CRIADO POR: JUNIOR SILVA\n" +
                "VER       : 1.5 \n" +
                "DATA      : 21/03/2019\n"
                             );
        }
    }
}
