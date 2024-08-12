namespace Projeto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnPare_click_infoVermelho(object sender, EventArgs e)
        {
            /*Acessar um componente pelo código -> nomeComponente.Propriedade
             * Passar um valor ao componente:
             * nomeComponente.Propriedade = novoValor;
             * 
             * Ler um valor de um componente:
             * variavel = nomeComponente.Propriedade;
            */

            lbInfo.Text = "Deve-se parar o veículo para evitar acidentes!";
            pictureBox1.Load("../../../img/pare_vermelho.jpg");
        }

        private void btnAtencao_click_mudaCor(object sender, EventArgs e)
        {
            lbInfo.Text = "Cuidade,o sinal vai fechar. Reduza velocidade!";
            pictureBox1.Load("../../../img/amarelo.png");
        }

        private void btnIr_click_infoVerde(object sender, EventArgs e)
        {
            lbInfo.Text = "Passagem permitida, acelere!";
            pictureBox1.Load("../../../img/verde.png");
        }
    }
}
