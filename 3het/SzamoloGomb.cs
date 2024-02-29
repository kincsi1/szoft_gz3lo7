using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3het
{
    internal class SzamoloGomb: villogogomb
    {
        public int count = 0;

        public SzamoloGomb() 
        {
            MouseClick += SzamoloGomb_MouseClick;
        }

        private void SzamoloGomb_MouseClick(object? sender, MouseEventArgs e)
        {
            count++;
            Text= count.ToString();

            if (count == 6) 
            {
                count= 0;
            }
            
        }
    }
}
