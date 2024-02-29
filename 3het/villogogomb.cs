using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3het
{
    internal class villogogomb:Button
    {
        public villogogomb()
        {
            MouseEnter += Villogogomb_MouseEnter;
            MouseLeave += Villogogomb_MouseLeave;
        }

        private void Villogogomb_MouseLeave(object? sender, EventArgs e)
        {
           //BackColor= Color.Transparent;
        }

        private void Villogogomb_MouseEnter(object? sender, EventArgs e)
        {
            Random rnd = new Random();
            
            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            BackColor = randomColor;
        }

    }
}
