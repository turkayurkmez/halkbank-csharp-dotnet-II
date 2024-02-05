using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public class Geometry
    {
        /*
         *   a * a 
         *   a * b
         *   (a * h) / 2
         *   (a * a) * PI
         *   
         */


        /// <summary>
        /// Kare veya daire alanlarını hesaplar
        /// </summary>
        /// <param name="unitLength">Birim uzunluk değeri</param>
        /// <param name="sekil">Kare ya da Daire</param>
        /// <returns></returns>
        public double GetArea(int unitLength, string sekil)
        {
            switch (sekil)
            {
                case "Kare":
                    return Math.Pow(unitLength, 2);
                case "Daire":
                    return Math.Pow(unitLength, 2) * Math.PI;
                default:
                    return 0;
            }
        }

        public double GetArea(int uLength1, int uLength2, string sekil)
        {
            switch (sekil)
            {
                case "Üçgen":
                    return (uLength1 * uLength2) / 2;
                case "Dikdörtgen":
                    return uLength1 * uLength2;
                default:
                    return 0;
            }
        }

        public double GetAreaOptional(int uLength1, int uLength2 = 1, string sekil = "Kare")
        {
            switch (sekil)
            {
                case "Kare":
                    return Math.Pow(uLength1, 2);
                case "Daire":
                    return Math.Pow(uLength1, 2) * Math.PI;
                case "Üçgen":
                    return (uLength1 * uLength2) / 2;
                case "Dikdörtgen":
                    return uLength1 * uLength2;
                default:
                    return 0;
            }
        }


    }
}
