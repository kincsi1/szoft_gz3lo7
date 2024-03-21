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
        int ir�ny_x = 1;
        int ir�ny_y = 0;
        int hossz = 5;
        List<Kigy�Elem> k�gy� = new List<Kigy�Elem>();

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;

            //Fejn�veszt�s
            fej_x += ir�ny_x * Kigy�Elem.M�ret;
            fej_y += ir�ny_y * Kigy�Elem.M�ret;

            foreach (object item in Controls)
            {
                if (item is Kigy�Elem)
                {
                    Kigy�Elem kk = (Kigy�Elem)item;
                    if (kk.Top == fej_y && kk.Left == fej_x)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }
                //Ha vannak m�r valami ott, ahova az �j fejet tenn�m, v�ge a j�t�knak

            }

            Kigy�Elem ke = new Kigy�Elem();
            ke.Top = fej_y;
            ke.Left = fej_x;
            k�gy�.Add(ke);
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

            //Farokv�g�s
            if (Controls.Count > hossz)
            {
                Kigy�Elem lev�gand� = k�gy�[0];
                Controls.RemoveAt(0);
            }
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                ir�ny_y = -1;
                ir�ny_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                ir�ny_y = 1;
                ir�ny_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                ir�ny_y = 0;
                ir�ny_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                ir�ny_y = 0;
                ir�ny_x = 1;
            }
        }
    }
}