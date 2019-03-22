using System.Windows.Forms;
using System.Drawing;
using System;

namespace Jogo_Pedra_Papel_Tesoura
{
    public partial class Form1 : Form
    {

        enum Opcoes { Pedra, Papel, Tesoura};
        enum Resultado {Jogador, Cpu, Empate};
        Opcoes player1 = new Opcoes();
        Opcoes CPU = new Opcoes();
        Random rdm = new Random();
        Resultado ganhador = new Resultado();


        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_pedra_Click(object sender, System.EventArgs e)
        {
            player1 = Opcoes.Pedra;
            EscolhaJogador();
            EscolhaCPU();
            VerificarGanhardor();
            
        }

        private void btn_papel_Click(object sender, System.EventArgs e)
        {
            player1 = Opcoes.Papel;
            EscolhaJogador();
            EscolhaCPU();
            VerificarGanhardor();
        }

        private void btn_tesoura_Click(object sender, System.EventArgs e)
        {
            player1 = Opcoes.Tesoura;
            EscolhaJogador();
            EscolhaCPU();
            VerificarGanhardor();
        }

        void EscolhaJogador()
        {
            switch (player1)
            {
                
                case Opcoes.Pedra:
                img_player1.BackgroundImage = Properties.Resources.res_papel;
                    break;

                case Opcoes.Papel:
                    img_player1.BackgroundImage = Properties.Resources.res_papel; 
                    break;

                case Opcoes.Tesoura:
                    img_player1.BackgroundImage = Properties.Resources.res_tesoura;
                    break;

                    

            }
        }

        void EscolhaCPU()
        {
            int numero = rdm.Next(1,4);

            if (numero == 1)
            {
                CPU = Opcoes.Pedra;
                img_cpu.BackgroundImage = Properties.Resources.res_papel;
            }
            else if (numero == 2)
            {
                CPU = Opcoes.Papel;
                img_cpu.BackgroundImage = Properties.Resources.res_papel;
            }
            else if (numero == 3)
            {
                CPU = Opcoes.Tesoura;
                img_cpu.BackgroundImage = Properties.Resources.res_tesoura;
            }
                                          
        }

        void VerificarGanhardor()
        {
            switch (player1)
            {
                case Opcoes.Pedra:
                    if (CPU == Opcoes.Pedra)
                        ganhador = Resultado.Empate;
                    else if (CPU == Opcoes.Papel)
                        ganhador = Resultado.Cpu;
                    else if (CPU == Opcoes.Tesoura)
                        ganhador = Resultado.Jogador;
                    break;

                case Opcoes.Papel:
                    if (CPU == Opcoes.Pedra)
                        ganhador = Resultado.Jogador;
                    else if (CPU == Opcoes.Papel)
                        ganhador = Resultado.Empate;
                    else if (CPU == Opcoes.Tesoura)
                        ganhador = Resultado.Cpu;
                    break;

                case Opcoes.Tesoura:
                    if (CPU == Opcoes.Pedra)
                        ganhador = Resultado.Cpu;
                    else if (CPU == Opcoes.Papel)
                        ganhador = Resultado.Jogador;
                    else if (CPU == Opcoes.Tesoura)
                        ganhador = Resultado.Empate;
                    break;


            }

            if (ganhador == Resultado.Jogador)
            {

                label_resultado.ForeColor = Color.DarkGreen;
                label_resultado.Text = ("Você Venceu!");
                label_player1.Text = (int.Parse(label_player1.Text) + 1).ToString();

            }

            else if (ganhador == Resultado.Cpu)
            {

                label_resultado.ForeColor = Color.Red;
                label_resultado.Text = ("Você Perdeu!");
                label_CPU.Text = (int.Parse(label_CPU.Text) + 1).ToString();

            }
            else if (ganhador == Resultado.Empate)
            {


                label_resultado.ForeColor = Color.Black;
                label_resultado.Text = ("Empate!");

            }

            if (int.Parse(label_CPU.Text) > (int.Parse(label_player1.Text)))
            {

                label_CPU.ForeColor = Color.DarkGreen;
                label_player1.ForeColor = Color.Red;

            }
            else if (int.Parse(label_CPU.Text) < (int.Parse(label_player1.Text)))
            {

                label_CPU.ForeColor = Color.Red;
                label_player1.ForeColor = Color.DarkGreen;

            }

            if (int.Parse(label_CPU.Text) == 10)
            {
                btn_papel.Enabled = false;
                btn_pedra.Enabled = false;
                btn_tesoura.Enabled = false;
                label_fimdejogo.Text = ("Fim de Jogo!");
            }

            if (int.Parse(label_player1.Text) == 10)
            {
                btn_papel.Enabled = false;
                btn_pedra.Enabled = false;
                btn_tesoura.Enabled = false;
                label_fimdejogo.Text = ("Fim de Jogo!");

            }



        }

   
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reiniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label_player1.Text = 0.ToString(); ;
            label_CPU.Text = 0.ToString(); ;
            btn_papel.Enabled = true;
            btn_pedra.Enabled = true;
            btn_tesoura.Enabled = true;
            img_cpu.BackgroundImage = null;
            img_player1.BackgroundImage = null;
            label_resultado.Text = null;
            label_fimdejogo.Text = null;
            label_CPU.ForeColor = Color.Black;
            label_player1.ForeColor = Color.Black;

        }
    }
}
