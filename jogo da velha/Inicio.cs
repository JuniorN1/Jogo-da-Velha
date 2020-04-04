using System;

using System.Drawing;
using System.Windows.Forms;
namespace jogo_da_velha
{
    public partial class Inicio : Form
    {
        WMPLib.WindowsMediaPlayer wplay = new WMPLib.WindowsMediaPlayer();
        public int chek ;
        int p1 = 0;
        int p2 = 0;
        public Form playGame;
        public Inicio()
        {
            InitializeComponent();
        }
        private void Inicio_Load(object sender, EventArgs e)
        {
            pontos1.Text = "0";
            pontos2.Text = "0";
            wplay.URL = "musica.mp3";
            wplay.controls.play();         
            //wplay.controls.pause();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicio.ActiveForm.Close();
            velha.ActiveForm.Close();
        }
        void empare()
        {
            pp_2.BackColor = Color.Transparent;
            pp_1.BackColor = Color.Transparent;
            pp_2.Enabled = false;
            pp_1.Enabled = true;
            x.Checked = true;
            o.Checked = false;


        }
        void winier_p1()
        {
            pp_2.BackColor = Color.Red;
            pp_1.BackColor = Color.Green;
            pp_2.Enabled = false;
            pp_1.Enabled = true;
            x.Checked = true;
            o.Checked = false;

        }
        void winier_p2()
        {
            pp_2.BackColor = Color.Green;
            pp_1.BackColor = Color.Red;
            pp_2.Enabled = true;
            pp_1.Enabled = false;
            x.Checked = false;
            o.Checked = true;
        }
        void msg(string message)
        {
          
           
            string title = "PARABENS!!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message+" Desejam continuar a partida??", title, buttons, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Cancel)
            {
                this.Close();
            }
            else if (result == DialogResult.Yes)
            {
                b1.Enabled = true;
                b2.Enabled = true;
                b3.Enabled = true;
                b4.Enabled = true;
                b5.Enabled = true;
                b6.Enabled = true;
                b7.Enabled = true;
                b8.Enabled = true;
                b9.Enabled = true;
                b1.Text = "";
                b2.Text = "";
                b3.Text = "";
                b4.Text = "";
                b5.Text = "";
                b6.Text = "";
                b7.Text = "";
                b8.Text = "";
                b9.Text = "";
                t_block.Enabled = true;
               
            }
            else
            {
                Close();
            }
        }
        void verificar_ganhador()
        {
            if (b1.Text == "O" && b2.Text == "O" && b3.Text == "O" || 
                b1.Text == "O" && b5.Text == "O" && b9.Text == "O" || 
                b3.Text == "O" && b5.Text == "O" && b7.Text == "O" || 
                b7.Text == "O" && b8.Text == "O" && b9.Text == "O" ||  
                b7.Text == "O" && b4.Text == "O" && b1.Text == "O" ||
                b8.Text == "O" && b5.Text == "O" && b2.Text == "O" ||
                b9.Text == "O" && b6.Text == "O" && b3.Text == "O" ||
                b6.Text == "O" && b5.Text == "O" && b4.Text == "O")
            {
              
                p2++;
                pontos2.Text = p2.ToString();
                t_block.Enabled = false;
                this.msg("Player 2 ganhou !!");
                this.winier_p2();
            }
            else if (
               b1.Text == "X" && b2.Text == "X" && b3.Text == "X" ||
               b1.Text == "X" && b5.Text == "X" && b9.Text == "X" ||
               b3.Text == "X" && b5.Text == "X" && b7.Text == "X" ||
               b7.Text == "X" && b8.Text == "X" && b9.Text == "X" ||
               b7.Text == "X" && b4.Text == "X" && b1.Text == "X" ||
               b8.Text == "X" && b5.Text == "X" && b2.Text == "X" ||
               b9.Text == "X" && b6.Text == "X" && b3.Text == "X" ||
               b6.Text == "X" && b5.Text == "X" && b4.Text == "X" )
            {
                p1++;
                t_block.Enabled = false;
                pontos1.Text = p1.ToString();
                this.msg("Player 1 ganhou !!");
                this.winier_p1();

            }
            else if (
               b1.Text != "" && b2.Text != "" && b3.Text != "" &&
               b4.Text != "" && b5.Text != "" && b6.Text != "" &&
               b7.Text != "" && b8.Text != "" && b9.Text != "")
            {
                this.msg("empataram a partida!!");
                this.empare();
            }
        }
        void check(int che){
            if (che ==1 ){            
                o.Checked = true;
                x.Checked = false;
                pp_2.BackColor = Color.Green;
                pp_1.BackColor = Color.Red;
           }
            else{               
                x.Checked = true;
                o.Checked = false;
                pp_2.BackColor = Color.Red;
                pp_1.BackColor = Color.Green;
            }
            this.verificar_ganhador();
        }
        private void button2_Click(object sender, EventArgs e){          
            if (x.Checked){
                b1.Text = x.Text;               
                chek = 1;
            }else{
                b1.Text = o.Text;               
                chek = 0;
            }
            b1.Enabled = false;
            this.check(chek);
        }

        private void b2_Click(object sender, EventArgs e){
            if (x.Checked){
                b2.Text = x.Text;
                chek = 1;
            }else{
                b2.Text = o.Text;              
                chek = 0;
            }
            b2.Enabled = false;
            this.check(chek);
        }

        private void b3_Click(object sender, EventArgs e){
            if (x.Checked){
                b3.Text = x.Text;              
                chek = 1;
            }else{
                b3.Text = o.Text;              
                chek = 0;
            }
            b3.Enabled = false;
            this.check(chek);
        }

        private void b4_Click(object sender, EventArgs e){
            if (x.Checked){
                b4.Text = x.Text;               
                chek = 1;
            }else{
                b4.Text = o.Text;
                chek = 0;
            }
            b4.Enabled = false;
            this.check(chek);
        }

        private void b5_Click(object sender, EventArgs e){
            if (x.Checked){
                b5.Text = x.Text;
                chek = 1;
            }else{
                b5.Text = o.Text;
                chek = 0;
            }
            b5.Enabled = false;
            this.check(chek);
        }

        private void b6_Click(object sender, EventArgs e){
            if (x.Checked){
                b6.Text = x.Text;
                chek = 1;
            }else{
                b6.Text = o.Text;
                chek = 0;
            }
            b6.Enabled = false;
            this.check(chek);
        }

        private void b7_Click(object sender, EventArgs e){
            if (x.Checked){
                b7.Text = x.Text;
                chek = 1;
            }else{
                b7.Text = o.Text;
                chek = 0;
            }
            b7.Enabled = false;
            this.check(chek);
        }

        private void b8_Click(object sender, EventArgs e){
            if (x.Checked){
                b8.Text = x.Text;
                chek = 1;
            }else{
                b8.Text = o.Text;
                chek = 0;
            }
            b8.Enabled = false;
            this.check(chek);
        }

        private void b9_Click(object sender, EventArgs e){
            if (x.Checked){
                b9.Text = x.Text;
                chek = 1;
            }else{
                b9.Text = o.Text;
                chek = 0;
            }
            b9.Enabled = false;
            this.check(chek);
        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            playGame.Show();
            wplay.controls.stop();
        }
    }
}
