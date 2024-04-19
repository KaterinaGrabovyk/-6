namespace ПР6
{
    internal class Program
    {/*Написати програму, яка використовує алгоритм сортування підрахунком для сортування масиву цілих чисел у діапазоні від 0 до 100.*/
        static int[] Sort(int[] chisla, int k)
        {
            var count = new int[k + 1];
            for (var i = 0; i < chisla.Length; i++)
            {
                count[chisla[i]]++;
            }

            var index = 0;
            for (var i = 0; i < count.Length; i++)
            {
                for (var j = 0; j < count[i]; j++)
                {
                    chisla[index] = i;
                    index++;
                }
            }

            return chisla;
        }
        static void Main(string[] args)
        {
            Random rand=new Random();
            Console.Write("Array lenght: ");
            int n=int.Parse(Console.ReadLine());
            int[] chisla =new int [n];
            for(int i=0;i<chisla.Length;i++)
            {
                chisla[i] = rand.Next(0, 100);
            }
            Console.WriteLine("Array: [{0}]", string.Join(", ", chisla));
            Console.WriteLine("Sorted: [{0}]", string.Join(", ", Sort(chisla,100)));
        }
    }
}
