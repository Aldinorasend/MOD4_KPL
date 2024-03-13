namespace MOD4_1302223071
{
         class Program
    {
        public class KodeBuah
 
        {
            public enum namaBuah { Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung,Kurma, Durian, Anggur, Melon, Semangka };
            public string getKodeBuah(namaBuah nama)
            {
                string[] kodeBuah = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00" };
                return kodeBuah[(int)nama];
                

            }
            public class PosisiKarakterGame
            {
                public enum Posisi
                {
                    BERDIRI, JONGKOK, TERBANG, TENGKURAP
                }
                public enum Tombol
                {
                    TOMBOLS, TOMBOLW
                }
            }
            static void Main(string[] args)
            {
                Console.Write("Enter Command:  ");
                string command = Console.ReadLine();
                PosisiKarakterGame.Tombol Tombol = PosisiKarakterGame.Tombol.TOMBOLS;
                PosisiKarakterGame.Posisi Posisi = PosisiKarakterGame.Posisi.BERDIRI;
                while (command != "Keluar")
                {
                    switch (Posisi)
                    {
                         case PosisiKarakterGame.Posisi.BERDIRI:
                            if (command == "S")
                            {
                                Tombol = PosisiKarakterGame.Tombol.TOMBOLS;
                                Posisi = PosisiKarakterGame.Posisi.JONGKOK;
                                Console.WriteLine("Tombol Arah Bawah Ditekan");
                            }
                            else if (command == "W")
                            {
                                Tombol = PosisiKarakterGame.Tombol.TOMBOLW;
                                Posisi = PosisiKarakterGame.Posisi.TERBANG;
                                Console.WriteLine("Tombol Arah Atas Ditekan ");
                            }
                            break;
                        case PosisiKarakterGame.Posisi.JONGKOK:
                            if (command == "S")
                            {
                                Tombol = PosisiKarakterGame.Tombol.TOMBOLS;
                                Posisi = PosisiKarakterGame.Posisi.TENGKURAP;
                                Console.WriteLine("Tombol Arah Bawah Ditekan ");
                            }
                            else if (command == "W")
                            {
                                Tombol = PosisiKarakterGame.Tombol.TOMBOLW;
                                Posisi = PosisiKarakterGame.Posisi.BERDIRI;
                                Console.WriteLine("Tombol Arah Atas Ditekan ");
                            }
                            break;
                        case PosisiKarakterGame.Posisi.TENGKURAP:
                            if (command == "S")
                            {
                                Tombol = PosisiKarakterGame.Tombol.TOMBOLS;
                                Posisi = PosisiKarakterGame.Posisi.TENGKURAP;
                                Console.WriteLine("Tombol Arah Bawah Ditekan ");
                            }
                            else if (command == "W")
                            {
                                Tombol = PosisiKarakterGame.Tombol.TOMBOLW;
                                Posisi = PosisiKarakterGame.Posisi.JONGKOK;
                                Console.WriteLine("Tombol Arah Atas Ditekan");
                            }
                            break;
                        case PosisiKarakterGame.Posisi.TERBANG:
                            if (command == "S")
                            {
                                Tombol = PosisiKarakterGame.Tombol.TOMBOLS;
                                Posisi = PosisiKarakterGame.Posisi.BERDIRI;
                                Console.WriteLine("Tombol Arah Bawah Ditekan ");
                            }
                            else if (command == "W")
                            {
                                Tombol = PosisiKarakterGame.Tombol.TOMBOLW;
                                Posisi = PosisiKarakterGame.Posisi.JONGKOK;
                                Console.WriteLine("Tombol Arah Atas Ditekan ");
                            }
                            break;
                    }

                    Console.Write("Enter Command:  ");
                    command = Console.ReadLine();
                }
                KodeBuah kodeBuahObj = new KodeBuah();
                Console.WriteLine("Nama Buah\t\tKode Buah");
                foreach(KodeBuah.namaBuah nama in Enum.GetValues(typeof(namaBuah))) { 
                    String kode1 = kodeBuahObj.getKodeBuah(nama);
                    Console.WriteLine(nama + "     \t\t" + kode1);
                }
                
            }
        }
    }
}
