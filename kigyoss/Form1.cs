namespace kigyoss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int count = 0;
        int fej_x = 100;
        int fej_y = 100;
        int irány_x = 1;
        int irány_y = 0;
        int hossz = 5;
        List<KigyóElem> kígyó = new List<KigyóElem>();

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;

            //Fejnövesztés
            fej_x += irány_x * KigyóElem.Méret;
            fej_y += irány_y * KigyóElem.Méret;

            foreach (object item in Controls)
            {
                if (item is KigyóElem)
                {
                    KigyóElem kk = (KigyóElem)item;
                    if (kk.Top == fej_y && kk.Left == fej_x)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }
                //Ha vannak már valami ott, ahova az új fejet tenném, vége a játéknak

            }

            KigyóElem ke = new KigyóElem();
            ke.Top = fej_y;
            ke.Left = fej_x;
            kígyó.Add(ke);
            Controls.Add(ke);


            Alma a = new Alma();
            a.Top = 100;
            a.Left = 100;
            Controls.Add(a);

            if (a.Top==fej_y&& a.Left==fej_x)
            {
                hossz++;

            }

            if (count % 2 == 0) ke.BackColor = Color.Yellow;

            //Farokvágás
            if (Controls.Count > hossz)
            {
                KigyóElem levágandó = kígyó[0];
                Controls.RemoveAt(0);
            }
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                irány_y = -1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                irány_y = 1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                irány_y = 0;
                irány_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                irány_y = 0;
                irány_x = 1;
            }
        }
    }
}