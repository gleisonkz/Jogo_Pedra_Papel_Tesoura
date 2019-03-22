using System.Windows.Forms;
using System.Drawing;

namespace Jogo_Pedra_Papel_Tesoura
{
    public partial class Form1 : Form
    {

        enum Opcoes { Pedra, Papel, Tesoura};
        Opcoes player1 = new Opcoes();

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
        }

        private void btn_papel_Click(object sender, System.EventArgs e)
        {
            player1 = Opcoes.Papel;
            EscolhaJogador();
        }

        private void btn_tesoura_Click(object sender, System.EventArgs e)
        {
            player1 = Opcoes.Tesoura;
            EscolhaJogador();
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
    }
}
