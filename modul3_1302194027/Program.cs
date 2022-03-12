using System;

public class KodeBuah
{
    public static void Main(string[] args)
    {

        static string getKodeBuah(int kodeBuah)
        {
            string[] KB = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00",
                         "K00", "L00", "M00", "N00", "O00" };

            string[] nmBuah = { "Apel", "Aprikot", "Alpukat", "Pisang", "Paprika", "Blackberry", 
                         "Ceri", "Kelapa", "Jagung", "Kurma", "Durian", "Anggur", "Melon", "Semangka" };

            return KB[kodeBuah];

        }
        Console.WriteLine("Kode Buah : ");

        int i = 0;
        while (i < 11)
        {
            Console.WriteLine(getKodeBuah(i));
            i++;
        }


    }
}


