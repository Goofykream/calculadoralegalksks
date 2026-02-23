using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace calculadorarealksks
{
    public partial class FormHistorico : Form
    {
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
        public FormHistorico(List<string> historico)
        {
            InitializeComponent();

            foreach (string item in historico)
            {
                lstHistorico.Items.Add(item);
            }
        }

        private void FormHistorico_Load(object sender, EventArgs e)
        {
            ArredondarPanel(panel1, 30);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
