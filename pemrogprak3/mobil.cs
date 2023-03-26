using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pemrogprak3
{
    internal class mobil
    {
        //propertis
        public string Warna { get; set; }
        public int JumlahPintu { get; set; }
        public string Merk { get; set; }
        public string Model { get; set; }
        public int TahunKeluar { get; set; }

        //method
        public void Gas(int kecepatan)
        {
            Console.WriteLine("========================================================");
            Console.WriteLine("Mobil {0} berjalan dengan kecepatan {1} KM/H", Model, kecepatan);
        }

        public void Klakson(string suara)
        {
            Console.WriteLine("output klakson: {0}\n",suara);
        }

        public void tampilkaninfo()  
        {
            Console.WriteLine("Mobil saya berwarna {0},merek {1} model {2} keluaran tahun {3} dengan jumlah pintu sebanyak {4}\n",Warna,Merk,Model,TahunKeluar,JumlahPintu);
        }

    }
}
