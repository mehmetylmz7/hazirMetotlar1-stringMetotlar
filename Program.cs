using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hazirMetotlar1_stringMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp , Hoşgeldiniz!";
            string degisken2 = "Dersimiz CSharp";


            //length
            Console.WriteLine(degisken.Length);


            //ToUpper,ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat
            Console.WriteLine(string.Concat(degisken,"merhaba"));

            //Compara , CompareTo
            Console.WriteLine(degisken.CompareTo(degisken2)); // karekter sayisina gore 1,0,-1 deger doner

            Console.WriteLine(string.Compare(degisken,degisken2,true)); // kucuk buyuk harfe duyarsızlasır
            Console.WriteLine(string.Compare(degisken, degisken2, false)); // kucuk buyuk harfe duyarlı davranır

            //Contains
            Console.WriteLine(degisken.Contains(degisken2));  // degisken içinde degisken2 var mı --> true
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));  //true
            Console.WriteLine(degisken.StartsWith("Merhaba!"));    //false


            //IndexOf
            Console.WriteLine(degisken.IndexOf("CS"));  //9  //girdiğimiz deger kacıncı ındexten baslıyor bulamaz ise -1 deger verir

            //Insert
            Console.WriteLine(degisken.Insert(0,"Merhaba!")); // 0. indexten baslayıp girdigimiz degeri ekler


            //LastIndexOf
            Console.WriteLine(degisken.LastIndexOf("i")); // en sondaki i harfinin kacıncı ındexte oldugunu bulur

            // PadLeft, PadRight
            Console.WriteLine(degisken+degisken2.PadLeft(30)); //degisken2yi 30 indexe tamamlayacak kadar bosluk ekler
            Console.WriteLine(degisken+degisken2.PadLeft(30,'*')); //degisken2yi 30 indexe tamamlayacak kadar * ekler
            Console.WriteLine(degisken2.PadRight(50)+degisken2); //degiskeni 30 indexe tamamlayacak kadar bosluk ekler
            Console.WriteLine(degisken.PadRight(50,'-')+degisken2); //degiskeni 30 indexe tamamlayacak kadar - ekler

            //Remove
            Console.WriteLine(degisken.Remove(10));  // 10. indexten başlayıp siler
            Console.WriteLine(degisken.Remove(5,3)); // 5. indexten başlayıp 3 karakter siler
            Console.WriteLine(degisken.Remove(0,1)); // en bastaki harfi siler

            //Replace
            Console.WriteLine(degisken.Replace("CSharp","C#"));
            Console.WriteLine(degisken.Replace(" ","*"));

            //Split 
            Console.WriteLine(degisken.Split(' ')[1]); // boşluklara ayırıp bir diziye atar ve 1. indexi getirir

            //Substring
            Console.WriteLine(degisken.Substring(4)); // 4. indexten başlayarak sonuna kadar yazar
            Console.WriteLine(degisken.Substring(4,6)); // 4. indexten başlayarak 6 tane karakter yazar

            Console.ReadLine();




        }
    }
}
