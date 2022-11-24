internal class Program
{
    private static void Main(string[] args)
    {
        //sort(sıralama)
        Console.WriteLine("*******Sırasız Dizi");
        int [] sayıdizisi={23,12,35,14,95,85,12};
        foreach( var item in sayıdizisi)
        {
        Console.WriteLine(item);
        }
        
        Console.WriteLine("*******Sıralı Dizi");
        Array.Sort(sayıdizisi);

         foreach( var item in sayıdizisi)
        {
        Console.WriteLine(item);
        }

        //Clear(verilen elemanı sıfırlar)
        Console.WriteLine("******Array Clear");
        Array.Clear(sayıdizisi,2,2);

         foreach( var item in sayıdizisi)
        {
        Console.WriteLine(item);
        }
        
         //Revorse(verilen dizinin elemanlarını ters çevirir)
         Console.WriteLine("******Array Revorse");
         Array.Reverse(sayıdizisi);
         foreach( var item in sayıdizisi)
        {
        Console.WriteLine(item);
        }

        //IndexOf
         Console.WriteLine("******Array IndexOf");
        
         Console.WriteLine( Array.IndexOf(sayıdizisi,95));

         //Resize
         Console.WriteLine("******Array ReSize");

         Array.Resize<int>(ref sayıdizisi,9);
         sayıdizisi[7]=29;
         sayıdizisi[8]=101;

         foreach( var item in sayıdizisi)
        {
        Console.WriteLine(item);
        }






    }
}