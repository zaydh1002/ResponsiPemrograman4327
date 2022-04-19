using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4327
{
    public class Karyawan
    {
        private string nik;
        private string nama;
        private int gajiBulanan;

        public string Nik
        {
            get { return nik; }
            set { nik = value; }
        }
        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }
        public int GajiBulanan
        {
            get { return gajiBulanan; }
            set { gajiBulanan = value; }
        }

        public Karyawan(string nik, string nama, int gajiBulanan)
        {
            this.nik = nik;
            this.nama = nama;
            this.gajiBulanan = gajiBulanan < 0 ? 0 : gajiBulanan;
        }

        public void tampilkanData()
        {
            Console.WriteLine("{0} {1}      {2}", nik, nama, gajiBulanan);
        }

        public void naikGaji()
        {
            int kenaikan;

            kenaikan = gajiBulanan * 110;
            gajiBulanan = kenaikan / 100;

            Console.WriteLine("asyik naik gaji 10%");
        }
    }
}
