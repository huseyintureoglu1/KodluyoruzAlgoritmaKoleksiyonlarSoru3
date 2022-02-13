using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoleksiyonlarSoru3
{
   public class KulaniciGirisi
    {
        SanalDatabase db = new SanalDatabase();
        public void KullaniciGirisi()
        {
            Console.WriteLine("Lütfen istediğiniz cümleyi giriniz.");
            string cumle= Console.ReadLine();
            if (string.IsNullOrEmpty(cumle) || cumle!=null)
            {
                for (int i = 0; i < cumle.Length; i++)
                {
                    if (cumle[i] =='a'|| cumle[i] == 'e' || cumle[i] == 'u' || cumle[i] == 'ü' || cumle[i] == 'ı' || cumle[i] == 'i' || cumle[i] == 'o' || cumle[i] == 'ö')
                    {
                       int sonuc= db.SesliHarfEkle(cumle[i]);
                        if (sonuc==1)
                        {
                            Console.WriteLine(cumle[i] + " sesli harfi eklendi");
                        }
                        else
                        {
                            Console.WriteLine("Sesli harf eklenemedi!!!");
                        }
                       
                    }
                    else
                    {
                        Console.WriteLine("Sesli harf değil");
                    }
                 
                }
            }
            else
            {
                Console.WriteLine("Lütfen cumle giriniz!!!");
                KullaniciGirisi();
            }
        }
    }
}
