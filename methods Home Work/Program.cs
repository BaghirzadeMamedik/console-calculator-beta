using System;

namespace Initial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("birinci reqemi daxil edin: ");
            string sreqem = Console.ReadLine();

            Console.WriteLine("ikinci reqemi daxil edin: ");

            string sreqem2 = Console.ReadLine();

            int reqem = Convert.ToInt32(sreqem);

            int reqem2 = Convert.ToInt32(sreqem2);

            Console.WriteLine("Emeli daxil edin: ");

            string emel = Console.ReadLine();

            decimal total;

            if (emel == "+")
            {
                total = reqem + reqem2;
                Console.WriteLine(total);
            }
            else if (emel == "-")
            {
                total = reqem - reqem2;
                Console.WriteLine(total);
            }
            else if (emel == "*")
            {
                total = reqem * reqem2;
                Console.WriteLine(total);
            }
            else if (emel == "/")
            {
                total = reqem / reqem2;
                Console.WriteLine(total);
            }
            else
            {
                Console.WriteLine("duzgun emeli daxil edin!!!");
            }

        }
    }
}
















//    // type safety



//    // decimal ve float 

//    // data type 

//    // float, bool, double

//    // value data types

//    //string soyad = "Muradov"; //
//    //int yas = 999999999;
//    //decimal boy =  1.5M;
//    //bool telebe = false;
//    //long yas2 = 99999999999999;


//    decimal qiymet = 5.555M;

//    float qiymet2 = 5.3555F;


//    // reference data types

//    // class, interfacess // object, array

//    /*string ad = "1";*/ // RAM  stack = 5

//    // array - massiv 
//    string[] telebeler = { "Aytac", "Gunel", "Vahid" }; // RAM // stack = telebeler | heap = 101 = { "Aytac", "Gunel", "Vahid"}

//    string[] telebeler2 = { }; // RAM stack telebeler2 // heap = 102

//    telebeler2 = telebeler; // RAM heap reference 101


//// Garbage Collector
//// Sniped
//// cw TABB 2x




////Console.WriteLine("Adinizi daxil edin:"); // 1
////string ad = Console.ReadLine(); // 2

////// + birlesdirme operatorudur.

////Console.WriteLine("Xos gelmissiniz " + ad); // 3



//// if/else swich case

////string ad = "Aytac";

////string fenn = "Proqramlasdirma";

////int bal = 51;

////int kecidBali = 51;




////if (bal >= kecidBali) // false bal = 50 > kecid bali 51
////{
////    Console.WriteLine("Tebrikler kecdinizi.");
////}
////else
////{
////    Console.WriteLine("Kesildin :D");
////}






//Evvele:
//    Console.WriteLine("Xos gelmissiniz.");
//    Console.WriteLine("Adinizi daxil edin : ");

//    string ad = Console.ReadLine();

//    Console.WriteLine("Balinizi daxil edin : ");

//    string bal = Console.ReadLine();

//    int yekunBal = Convert.ToInt32(bal); // string 56 convert int 56
//    int kecidBali = 51;

//    // E D C B A

//    // yekun bal  = bal
//    //// < > == != >= <= &&  ||
//    int kesirBali = kecidBali - yekunBal;

//    if (yekunBal >= kecidBali)
//    {
//        if (yekunBal >= 51 && yekunBal <= 60) // 55 | true , false
//        {
//            Console.BackgroundColor = ConsoleColor.Green;
//            Console.WriteLine("Qiymet E");
//            Console.BackgroundColor = ConsoleColor.Black;
//        }
//        else if (yekunBal >= 61 && yekunBal <= 70)
//        {
//            Console.BackgroundColor = ConsoleColor.Green;
//            Console.WriteLine("Qiymet D");
//            Console.BackgroundColor = ConsoleColor.Black;
//        }
//        else if (yekunBal >= 71 && yekunBal <= 80)
//        {
//            Console.BackgroundColor = ConsoleColor.Green;
//            Console.WriteLine("Qiymet C");
//            Console.BackgroundColor = ConsoleColor.Black;
//        }
//        else if (yekunBal >= 81 && yekunBal <= 90)
//        {
//            Console.BackgroundColor = ConsoleColor.Green;
//            Console.WriteLine("Qiymet B");
//            Console.BackgroundColor = ConsoleColor.Black;
//        }
//        else
//        {
//            Console.BackgroundColor = ConsoleColor.Green;
//            Console.ForegroundColor = ConsoleColor.Black;
//            Console.WriteLine("Qiymet A");
//            Console.BackgroundColor = ConsoleColor.Black;
//        }
//    }
//    else
//    {
//        Console.BackgroundColor = ConsoleColor.Red;
//        Console.WriteLine(ad + " cemi " + kesirBali + " bal ile kesildin.");
//        Console.BackgroundColor = ConsoleColor.Black;
//    }


//    Console.WriteLine("Davam etmek isteyirsiniz?");
//    var tesdiq = Console.ReadLine();

//    if (tesdiq == "y")
//    {
//        Console.Clear();
//        goto Evvele;
//    }
//    else if (tesdiq == "n")
//    {
//        Console.Clear();
//        Console.WriteLine("Sagolun");
//    }
//    else
//    {
//        Console.WriteLine("Duzgun yazin.");
//    }
