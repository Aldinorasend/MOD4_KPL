namespace MOD4_1302223071
{
    internal class Program
    {
        public class KodeBuah
 
        {
            public enum namaBuah { Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung,Kurma, Durian, Anggur, Melon, Semangka };
            public string getKodeBuah(namaBuah nama)
            {
                string[] kodeBuah = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00" };
                return kodeBuah[(int)nama];
                

            }
            static void Main(string[] args)
            {
                KodeBuah kodeBuahObj = new KodeBuah();
                Console.WriteLine("Nama Buah\t\tKode Buah");
                foreach(KodeBuah.namaBuah nama in Enum.GetValues(typeof(namaBuah))) { 
                    String kode1 = kodeBuahObj.getKodeBuah(nama);
                    Console.WriteLine(nama + "\t\t" + kode1);
                }
                
            }
        }
    }
}
