using System;

class Program
{
    public static void Main(string[] args)
    {

        int[] testMas1 = new []{1, 3, 3, 1, 7, 3 };
        int[] testMas2 = new []{3, 5, 6};

        int[] testRes = Sum(testMas1, testMas2);

        if (testRes!=null)
        {
            foreach (var e in testRes)
            {
                Console.Write($"__{e}");
            }
        }

        Console.ReadKey();

    }

    private static int[] Sum(int[] mas1, int[] mas2)
    {
        int length;
        if (mas1.Length > mas2.Length) length = mas1.Length;
        else length = mas2.Length;
        List<int> resultList = new List<int>();
        int[] result;
        var flag = true;
        var extraNum = false;
        for (int i = 0; i < mas1.Length; i++)
        {
            if (mas1[i] > 9 || mas1[i] < 0)
            {
                Console.WriteLine("Неверный ввод");
                flag = false;
            }
        }
        for (int i = 0; i < mas2.Length; i++)
        {
            if (mas2[i] > 9 || mas2[i] < 0)
            {
                Console.WriteLine("Неверный ввод");
                flag = false;
            }
        }


        if (!flag) result = null;
        else
        {
            int dec = 0;
            for (var i = length - 1; i >= 0; i--)
            {
                var n1 = i < mas1.Length ? mas1[i] : 0;
                var n2 = i < mas2.Length ? mas2[i] : 0;

                if (dec + n1 + n2 > 9 && i == 0)
                {
                    resultList.Add(dec + n1 + n2 - 10);
                    Console.WriteLine("Check");
                    extraNum = true;
                }
                else if (dec + n1 + n2 > 9)
                {
                    resultList.Add(dec + n1 + n2 - 10);
                    dec = 1;
                }
                else
                {
                    resultList.Add(n1 + n2 + dec);
                    dec = 0;
                }
            }

            if (extraNum)
            {
                resultList.Add(1);
            }

            result = resultList.ToArray().Reverse().ToArray();

        }

        return result;
    }

}

