using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KesselRun.Business.AllPunters
{
    public static class Factory
    {
        public static Punter GetAPunter(int id)
        {
            switch (id)
            {
                case 0:
                    return new Creedo();
                case 1:
                    return new Jubba_the_hutt();
                case 2:
                    return new Snoke();
                case 3:
                    return new Watto();

                default: return null;




            }




        }



    }
}
