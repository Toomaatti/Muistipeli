using System.Configuration;

namespace _120_Muistipeli
{
    public partial class Form1 : Form
    {
        Peli peli = new Peli();
        public TableLayoutPanel tbpKortit;
        int riviLkm = 4;
        int sarakeLkm = 4;
        Pelaaja pelaaja1 = new Pelaaja();
        Pelaaja pelaaja2 = new Pelaaja();
        int i = 1;
        public Form1()
        {
            tbpKortit = new TableLayoutPanel();
            tbpKortit.SuspendLayout();
            Controls.Add(tbpKortit);
            InitializeComponent();
            
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            tbpKortit.Anchor = AnchorStyles.None;
            tbpKortit.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tbpKortit.ColumnCount = sarakeLkm;
            tbpKortit.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tbpKortit.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tbpKortit.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tbpKortit.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tbpKortit.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tbpKortit.ForeColor = SystemColors.ButtonFace;
            tbpKortit.Location = new Point(28, 6);
            tbpKortit.Name = "tbpKortit";
            tbpKortit.RowCount = riviLkm;
            tbpKortit.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tbpKortit.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tbpKortit.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tbpKortit.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tbpKortit.Size = new Size(798, 449);
            tbpKortit.TabIndex = 0;
            peli.AsetaKuviot(this);
            
            // 
        }
        Label Eka, Toka;
        public void Kortti_Click(object sender, EventArgs e)
        {
           

            Label clicked = sender as Label;
            if (clicked == null)
            {
                return;
            }
            if (clicked.ForeColor == Color.Black)
            {
                return;
            }
            if (Eka == null)
            {
                Eka = clicked;
                Eka.ForeColor = Color.Black;
                return;
            }

            Toka = clicked;
            Toka.ForeColor = Color.Black;

            if (Eka.Text == Toka.Text)
            {
                if (i % 2 == 0)
                {
                    pelaaja2.Pisteet++;
                    P2.Text = "P2: " + pelaaja2.Pisteet.ToString();
                }
                else
                {
                    pelaaja1.Pisteet++;
                    P1.Text = "P1: " + pelaaja1.Pisteet.ToString();
                }
                if (pelaaja1.Pisteet + pelaaja2.Pisteet == tbpKortit.Controls.Count/2)
                {
                    Voittaja();
                }
            }
            Ajastin.Start();


        }

        private void Ajastin_Tick(object sender, EventArgs e)
        {
            Ajastin.Stop();
            if (Eka.Text != Toka.Text)
            {
                Eka.ForeColor = tbpKortit.BackColor;
                Toka.ForeColor = tbpKortit.BackColor;

            }
            i++;
            Eka = null;
            Toka = null;
        }
        private void Voittaja()
        {
            if (pelaaja1.Pisteet < pelaaja2.Pisteet)
            {
                MessageBox.Show("Pelaaja 2 voitti");
            }
            else
            {
                MessageBox.Show("Pelaaja 1 Voitt");
            }
        }
    }
}
