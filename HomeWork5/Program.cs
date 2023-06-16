namespace HomeWork5
{
    public class Program
    {
        static class MyString
        {
            public static string TrimStart(string A)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] != ' ')
                    {
                        A = A.Substring(i);
                        break;
                    }
                }

                return A;
            }

            public static string TrimEnd(string A)
            {
                for (int i = A.Length - 1; i >= 0; i--)
                {
                    if (A[i] != ' ')
                    {
                        A = A.Substring(0, i + 1);
                        break;
                    }
                }

                return A;
            }
            public static string Trim(string A)
            {
                for (int i = A.Length - 1; i >= 0; i--)
                {
                    if (A[i] != ' ')
                    {
                        A = A.Substring(0, i + 1);
                        break;
                    }
                }
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] != ' ')
                    {
                        A = A.Substring(i);
                        break;
                    }
                }
                return A;
            }
        }


        static void Main(string[] args)
        {
            string str = "  Arzu Mahmudov";
            str = MyString.TrimStart(str);
            Console.WriteLine(str);

            string str2 = "Arzu Mahmudov  ";
            str2 = MyString.TrimEnd(str2);
            Console.WriteLine(str2);

            string str3 = "    Arzu   Mahmudov   ";
            str3 = MyString.Trim(str3);
            Console.WriteLine(str3);
        }
    }
}