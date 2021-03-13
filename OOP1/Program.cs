using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////Örnek1///////////////////////////////////////////////////////////////////////////////////
            int sayi1 = 30;
            int sayi2 = 60;
            sayi1 = sayi2;
            sayi2 = 100;
            //sayi1=? 
            //sayi1=60


            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0]=?
            //sayilar1[0]=999

            //Bunun sebebi;
            /*
             * int,decimal,float,doule,bool = değer tip
             * stackte tutulur,işimiz sadece değerler. sayi1 = sayi2; dediğimizde sayi2 nin değeri neyse al sayi1 in değeri artık o olsun diyoruz.
            */
            /*
             * array,class,interface = referans tip
             * bunlar hem stack hem heap kullanır. int[] sayilar1 dediğimizde stackte yer açılır. new int[] { 10 , 20 , 30 }; dediğimizde ise 
             * heap te adress tanımlanır.
             * sayilar1 = sayilar2; dediğimizde sayilar2 nin adresini alıyoruz ve artık sayilar1 in adresi sayilar2 nin adresi neyse o oluyor. Yani artık 
             * sayilar1 ve sayilar2 aynı adrese bağlı. O yüzden birinin değerini değiştirdiğimizde heapteki adresteki değeri değiştiriyoruz.
             * ikisi de aynı adrese bağlı olduğu için ikisininde değeri değişmiş oluyor.
             * ilk başta sayilar1 in kullandığı adres artık boşta olduğu için bir süre sonra garbage collector tarafından silinir.
            */


            ///////////Örnek2////////////////////////////////////////////////////////////////

            Product product = new Product { Name = "Kitaplık" };
            int sayi = 100;

            ProductManager productManager = new ProductManager();

            productManager.ChangeName(product);
            //Console.WriteLine(product.Name); 
            //Product.name = ?  Masa
            

            productManager.Decrease(sayi);
            //Console.WriteLine(sayi);
            //sayi = ? 100
            


            ////////////////////////////////////////////////////////////////////////////

        }
    }
}
