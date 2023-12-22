using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fonksiyonornek5
{
    internal class Program
    {
        static void yaz()
        {
            for (int i = 0; i <5;i++)
            {
                for(int j = 0; j < 5;j++)
                {
                    Console.Write("A");
                }
                Console.WriteLine("");
            }
        }
        static void Main(string[] args)
        {
            /*
             Örnek: çağırıldığı zaman ekrana aşağıdaki matrisi
            oluşturacak fonksiyonu yazınız.
            AAAAA
            AAAAA
            AAAAA
            AAAAA
            AAAAA
             */
            yaz();
        }
    }
}
