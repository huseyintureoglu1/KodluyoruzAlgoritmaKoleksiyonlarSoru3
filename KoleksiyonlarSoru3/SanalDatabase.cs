using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoleksiyonlarSoru3
{
   public class SanalDatabase
    {
        public static ArrayList DataBase = new ArrayList(); 
        public int SesliHarfEkle(char sesliHarf)
        {
            int sonuc = 0;
            try
            {
                DataBase.Add(sesliHarf);
                sonuc = 1;
            }
            catch (Exception)
            {
                Console.WriteLine("Harf eklenemedi");

            }
            return sonuc;
        }
        public void Sirala()
        {
            DataBase.Sort();
        }
        public void EkranaYazdir()
        {
            Console.Write("Sesli harfler: ");
            for (int i = 0; i < DataBase.Count; i++)
            {
                Console.Write(DataBase[i] + " ");
            }
        }
    }
}
