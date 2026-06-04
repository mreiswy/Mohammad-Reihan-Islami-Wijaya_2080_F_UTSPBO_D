using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Mohammad_Reihan_Islami_Wijaya_2080_F_UTSPBO_D
{
    public abstract class PesananMakanan
    {
        private string namaPemesan;
        private string nomorMeja;
        private string menuUtama;

        public string NamaPemesan { get => namaPemesan; set => namaPemesan = value; }
        public string NomorMeja { get => nomorMeja; set => nomorMeja = value; }
        public string MenuUtama { get => menuUtama; set => menuUtama = value; }

        public PesananMakanan(string nama, string meja, string menu)
        {
            this.namaPemesan = nama;
            this.nomorMeja = meja;
            this.menuUtama = menu;
        }

        public abstract double hitungTotalBill();

        public virtual void tampilInfo()
        {
            Console.WriteLine($"Pemesan : {namaPemesan} | Meja: {nomorMeja} | Menu: {menuUtama}");
        }
    }
}