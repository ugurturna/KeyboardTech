using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardTech
{
    class Degisken
    {

        public static int dk = 0, sn = 0;
        public static string yazi = "", ad = " ", soyad = " ", eposta = "";
        public static bool gonderim = false;


        public static string boslukTemizle(string met)
        {
            string saf = "";

            for (int i = 0; i <= met.Length - 1; i++)
            {
                met = met.Replace("  ", " ");


            }
            saf = met;
            return saf;
        }
        public static int kelimeHesapla(string yazi)
        {

            string metin = yazi;
            int len;

            if (metin != string.Empty)
            {
                len = 1;
            }
            else
            {
                len = 0;
            }

            for (int i = 0; i <= metin.Length - 1; i++)
            {
                if (metin.Substring(i, 1).ToString() == " ")
                {
                    len++;
                }

            }

            return len;
        }

    }
}
