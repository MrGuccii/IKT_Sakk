using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sakk
{
    public class Mezo
    {
        public bool lepesek { get; set; }
        public bool foglalt { get{
				if (babuNeve==null)
				{
                    return false;
				}
				return babuNeve.Length>0;
            }
        }
        public int oszlop { get; set; }
        public int sor { get; set; }
        public string babuNeve { get; set; }
		public BabuSzine babuSzine { get; set; }
		public Button gomb { get; set; }
		public int lepesekSzama { get; set; }

        public Mezo(int sor, int oszlop)
        {
            this.sor = sor;
            this.oszlop = oszlop;
            this.gomb = new Button();
            lepesekSzama = 0;
        }
    }
}
