﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YURT_OTOMASYONU.ViewModels.Personel
{
    public   class PersonelViewModel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public Nullable<int> TCKimlikNo { get; set; }
        public string KanGrubu { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string DogumYeri { get; set; }
        public Nullable<System.DateTime> DogumTarihi { get; set; }
        public string AnneAdi { get; set; }
        public string BabaAdi { get; set; }
        public Nullable<int> TelefonNo { get; set; }
        public string Adres { get; set; }
        public Nullable<System.DateTime> GirisTarihi { get; set; }
        public Nullable<System.DateTime> AyrilisTarihi { get; set; }
        public string Email { get; set; }
        public Nullable<int> SigortaNo { get; set; }
        public string GörevAdi { get; set; }
        public Nullable<decimal> PersonelMaas { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
    }
}
