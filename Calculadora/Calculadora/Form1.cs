namespace Calculadora
{
    public partial class Form1 : Form
    {
        //Propriedades
        private Operacao OperacaoSelecionada { get; set; }
        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }
        //Enumerador
        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }
        public Form1()
        {
            InitializeComponent();
        }
        //textBox
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //Zero
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }
        //Um
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }
        //Dois
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }
        //Tr�s
        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }
        //Quatro
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }
        //Cinco
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }
        //Seis
        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }
        //Sete
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }
        //Oito
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }
        //Nove
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }
        private void button16_Click(object sender, EventArgs e)
        {

        }
        //Divis�o
        private void button6_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "";
            lblOperacao.Text = "�";
        }
        //Multiplica��o
        private void button11_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "";
            lblOperacao.Text = "X";
        }
        //Subtra��o
        private void button14_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "";
            lblOperacao.Text = "-";
        }
        //Adi��o
        private void button15_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "";
            lblOperacao.Text = "+";
        }
        //Bot�o 'igual'
        private void button18_Click(object sender, EventArgs e)
        {
            switch(OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(textBox1.Text);
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(textBox1.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(textBox1.Text);
                    break;
                case Operacao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(textBox1.Text);
                    break;
            }
            textBox1.Text = Convert.ToString(Resultado);
            lblOperacao.Text = "=";
        }
        //V�rgula
        private void button4_Click(object sender, EventArgs e)
        {
            if(!textBox1.Text.Contains("."))
                textBox1.Text = textBox1.Text + ".";
        }
        //Apagar
        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            lblOperacao.Text = "";
        }
    }
}