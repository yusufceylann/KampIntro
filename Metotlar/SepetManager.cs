﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler, Sepete Eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double Fiyat, int StokAdedi)
        {
            Console.WriteLine("Tebrikler, Sepete Eklendi : " + urunAdi);
        }
    }
}
