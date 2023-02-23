namespace _05._02._23
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Bilinçsiz Tür Dönüşümü

            #endregion

            #region Bilinçli Tür Dönüşümü

            #endregion
            #region ÖRNEKKKKK

            Console.WriteLine("Büyük Küçük Harf Çevirici\n");
            geri:
            Console.Write("Bir harf giriniz: ");
            char harf = char.Parse(Console.ReadLine());
            if (harf>='A' && harf <= 'Z')
            {
                Console.WriteLine("Büyükten küçüğe çevrildi.\a");
                Console.WriteLine("Sonuç: "+ (char)(harf+32));
            }
            else if (harf>='a' && harf<='z')
            {
                Console.WriteLine("Küçükten büyüğe çevrildi.\a");
                Console.WriteLine("Sonuç: " + Convert.ToChar(harf-32));
            }
            else
            {
                Console.WriteLine("Lütfen sadece harf giriniz.\a");
            }
            goto geri;
            #endregion

        }
    }
}