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
                img_player1.BackgroundImage = Image.FromFile("C:/Csharp/GitHub/Pedra_Papel_Tesoura/pedra2.png");
                    break;

                case Opcoes.Papel:
                    img_player1.BackgroundImage = Image.FromFile("C:/Csharp/GitHub/Pedra_Papel_Tesoura/papel2.png");
                    break;

                case Opcoes.Tesoura:
                    img_player1.BackgroundImage = Image.FromFile("C:/Csharp/GitHub/Pedra_Papel_Tesoura/tesoura.png");
                    break;

            }
        }

        void EscolhaCPU()
        {
            int numero = rdm.Next(1,4);

            if (numero == 1)
            {
                CPU = Opcoes.Pedra;
                img_cpu.BackgroundImage = Image.FromFile("C:/Csharp/GitHub/Pedra_Papel_Tesoura/pedra2.png");
            }
            else if (numero == 2)
            {
                CPU = Opcoes.Papel;
                img_cpu.BackgroundImage = Image.FromFile("C:/Csharp/GitHub/Pedra_Papel_Tesoura/papel2.png");
            }
            else if (numero == 3)
            {
                CPU = Opcoes.Tesoura;
                img_cpu.BackgroundImage = Image.FromFile("C:/Csharp/GitHub/Pedra_Papel_Tesoura/tesoura.png");
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


        }









        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
