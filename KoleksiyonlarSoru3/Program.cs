using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoleksiyonlarSoru3
{
    class Program
    {
        static void Main(string[] args)
        {
            KulaniciGirisi kullanici = new KulaniciGirisi();
            SanalDatabase sanal = new SanalDatabase();

            kullanici.KullaniciGirisi();
            sanal.Sirala();
            sanal.EkranaYazdir();
            Console.ReadLine();
        }
    }
}
