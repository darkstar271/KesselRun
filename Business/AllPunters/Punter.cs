using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KesselRun.Business.AllPunters
{
    public abstract class Punter
    // https://www.infoworld.com/article/2928719/when-to-use-an-abstract-class-vs-interface-in-c.html
    {
        public string PunterName { get; set; }
        public int Ships { get; set; }
        public Single Cash { get; set; }
        public Single Bet { get; set; }
        public Label LabelWinner { get; set; }

        public Color MyColor { get; set; }
        string FavoriteDrink { get; set; }

        int WildCard { get; set; }

    }
}
