using System;
using System.Drawing;
using System.Windows.Forms;

namespace Jogo_Pedra_Papel_Tesoura
{
    public partial class Form1 : Form
    { 
        enum Opcoes { Pedra, Papel, Tesoura};
        enum Resultado {Jogador, CPU, Empate};
        Opcoes player1 = new Opcoes();
        Opcoes CPU = new Opcoes();
        Random rdm = new Random();
        Resultado quem_venceu = new Resultado();
        int placarP1, placarCPU;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_pedra_Click(object sender, System.EventArgs e)
        {
            player1 = Opcoes.Pedra;
            EscolhaJogador();
            EscolhaCPU();
            VerificaVencerdor();
        }

        private void btn_papel_Click(object sender, System.EventArgs e)
        {
            player1 = Opcoes.Papel;
            EscolhaJogador();
            EscolhaCPU();
            VerificaVencerdor();
        }

        private void btn_tesoura_Click(object sender, System.EventArgs e)
        {
            player1 = Opcoes.Tesoura;
            EscolhaJogador();
            EscolhaCPU();
            VerificaVencerdor();
        }

        void EscolhaJogador()
        {
            switch (player1)
            {
                case Opcoes.Pedra:
                img_player1.BackgroundImage = Properties.Resources.res_pedra;
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
                img_cpu.BackgroundImage = Properties.Resources.res_pedra;
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

        void VerificaVencerdor()
        {
            switch (player1)
            {
                case Opcoes.Pedra:
                    if (CPU == Opcoes.Pedra)
                        quem_venceu = Resultado.Empate;
                    else if (CPU == Opcoes.Papel)
                        quem_venceu = Resultado.CPU;
                    else if (CPU == Opcoes.Tesoura)
                        quem_venceu = Resultado.Jogador;
                    break;

                case Opcoes.Papel:
                    if (CPU == Opcoes.Pedra)
                        quem_venceu = Resultado.Jogador;
                    else if (CPU == Opcoes.Papel)
                        quem_venceu = Resultado.Empate;
                    else if (CPU == Opcoes.Tesoura)
                        quem_venceu = Resultado.CPU;
                    break;

                case Opcoes.Tesoura:
                    if (CPU == Opcoes.Pedra)
                        quem_venceu = Resultado.CPU;
                    else if (CPU == Opcoes.Papel)
                        quem_venceu = Resultado.Jogador;
                    else if (CPU == Opcoes.Tesoura)
                        quem_venceu = Resultado.Empate;
                    break;
            }

            if (quem_venceu == Resultado.Jogador)
            {
                label_resultado.ForeColor = Color.DarkGreen;
                label_resultado.Text = ("Você Venceu!");
                placarP1++;
                label_player1.Text = placarP1.ToString();
            }

            else if (quem_venceu == Resultado.CPU)
            {
                label_resultado.ForeColor = Color.Red;
                label_resultado.Text = ("Você Perdeu!");
                placarCPU++;
                label_CPU.Text = placarCPU.ToString();
            }
            else if (quem_venceu == Resultado.Empate)
            {
                label_resultado.ForeColor = Color.Black;
                label_resultado.Text = ("Empate!");
            }

            if (placarCPU > placarP1)
            {
                label_CPU.ForeColor = Color.DarkGreen;
                label_player1.ForeColor = Color.Red;
            }
            else if (placarCPU < placarP1)
            {
                label_CPU.ForeColor = Color.Red;
                label_player1.ForeColor = Color.DarkGreen;
            }

            if (placarCPU == 10)
            {
                btn_papel.Enabled = false;
                btn_pedra.Enabled = false;
                btn_tesoura.Enabled = false;
                label_fimdejogo.Text = ("Fim de Jogo!");
            }

            else if (placarP1 == 10)
            {
                btn_papel.Enabled = false;
                btn_pedra.Enabled = false;
                btn_tesoura.Enabled = false;
                label_fimdejogo.Text = ("Fim de Jogo!");
            }
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
