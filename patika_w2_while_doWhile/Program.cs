namespace patika_w2_while_doWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region WHİLE

            int limite_num = 0, i = 0; //limit ve başlangıç değerlerini tanımladım.
            Console.Write("Kaç defa çalıştırmak istediğinizi yazın.");
            limite_num = int.Parse(Console.ReadLine()); //klavyeden girilen string değeri tam sayıya çevirdim

            while (i < limite_num)
            {
                Console.WriteLine(i + 1 + ". Ben Bir Patika'lıyım");
                i++;
            }
            Console.WriteLine("Negatif değer girdin çalışmadı"); //eğer negatif girilmezse döngüye girmeden kod gösterilcek.


            Console.Read();

            #endregion


            #region Do-While

            int limite_numm = 0, ii = 0;

            Console.Write("Kaç defa çalıştırmak istediğinizi yazın: ");
            limite_numm = int.Parse(Console.ReadLine());


            do
            {
                Console.WriteLine(ii + 1 + ". Ben Bir Patika'lıyım"); //en az 1 kere çalışacak. Negatif olsa bile.
                ii++;

            } while (ii < limite_numm); // basamak sayısı girilen limit'ten küçük olduğu sürece döngü devam edecek.
                                        // false değer döndürdüğünde döngüden çıkacak.

            Console.WriteLine("Biitti"); //false değer gelince ekranda gözüken sonuç.

            Console.Read();

            #endregion



            /*
             * while döngüsünde önce koşul'u kontrol etti "true" olduğunu doğruladıktan sonra çıktı verdi
             * Do-While komutunda ise önce bir çıktı veriyor daha sonra koşulu kontrol ediyor true olursa birdaha çıktı alıyorz.
             */
        }
    }
}
