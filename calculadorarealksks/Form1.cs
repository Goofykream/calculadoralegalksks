using calculadorarealkss;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text.RegularExpressions;

namespace calculadorarealksks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool limparProximo = false;

        List<string> historico = new List<string>();

        private void button12_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtDisplay.Text += btn.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtDisplay.Text += btn.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtDisplay.Text += btn.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtDisplay.Text += btn.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtDisplay.Text += btn.Text;
        }

        private void ArredondarPanel(Panel panel, int raio)
        {
            GraphicsPath path = new GraphicsPath();

            int r = raio;
            path.StartFigure();
            path.AddArc(0, 0, r, r, 180, 90);
            path.AddArc(panel.Width - r, 0, r, r, 270, 90);
            path.AddArc(panel.Width - r, panel.Height - r, r, r, 0, 90);
            path.AddArc(0, panel.Height - r, r, r, 90, 90);
            path.CloseFigure();

            panel.Region = new Region(path);
        }
        private void button14_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtDisplay.Text += btn.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtDisplay.Text += btn.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtDisplay.Text += btn.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtDisplay.Text += btn.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtDisplay.Text += btn.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtDisplay.Text += btn.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtDisplay.Text += btn.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtDisplay.Text += btn.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtDisplay.Text += btn.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string texto = txtDisplay.Text;

                texto = texto.Replace("÷", "/").Replace("x", "*");

                char operador = texto.First(c => "+-*/".Contains(c));
                string[] partes = texto.Split(operador);

                double a = double.Parse(partes[0]);
                double b = double.Parse(partes[1]);

                IOperacao operacao = operador switch
                {
                    '+' => new Adicao(),
                    '-' => new Subtracao(),
                    '*' => new Multiplicacao(),
                    '/' => new Divisao(),
                };

                double resultado = operacao.Calcular(a, b);
                txtDisplay.Text = resultado.ToString();

                string registro = $"[{DateTime.Now:HH:mm}] {a}{operador}{b}={resultado}";
                historico.Add(registro);

                txtDisplay.Text = resultado.ToString();

                limparProximo = true;

            }
            catch
            {
                MessageBox.Show("hmm, I think there’s been a calculation mistake. Could you check your input? ");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            FormHistorico form = new FormHistorico(historico);
            form.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            ArredondarPanel(panel1, 30);
        }
    }
}
