using System;
using System.Collections.Generic;
using System.Text;

namespace Dolgozat_gyakorló_feladat
{
    public static class KoltsegKalkulator
    {
        public static double BérletiDijKedvezmennyel(double alapAr, int napokSzama)
        {
            if (napokSzama >= 7)
            {
                return alapAr * napokSzama * 0.85;
            }
            else
            {
                return alapAr * napokSzama;
            }
        }

    }
}
