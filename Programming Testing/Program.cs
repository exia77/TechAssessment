using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String: {}");
            string input = "{}";
            Console.WriteLine(TestString(input));
            
            Console.WriteLine("String: }{");
            input = "String: }{";
            Console.WriteLine(TestString(input));
            
            Console.WriteLine("String: {{}");
            input = "String: {{}";
            Console.WriteLine(TestString(input));
            
            Console.WriteLine("String: \"\"");
            input = "String:\"\"";
            Console.WriteLine(TestString(input));
            
            Console.WriteLine("String: {abcdefghijklmnopqrstuvwxyz}");
            input = "{abcdefghijklmnopqrstuvwxyz}";
            Console.WriteLine(TestString(input));
           
            Console.WriteLine("String: {{{}}{}}{");
            input = "{{{}}{}}{";
            Console.WriteLine(TestString(input));
            
            Console.WriteLine("String: {asdada}{ad{asdasd}}");
            input = "{asdada}{ad{asdasd}}";
            Console.WriteLine(TestString(input));

            Console.WriteLine("String: {{{}}{}}");
            input = "{{{}}{}}";
            Console.WriteLine(TestString(input));

            Console.WriteLine("String: {asdasdaasdad}asdasdas}asdasd{assad}");
            input = "{asdasdaasdad}asdasdas}asdasd{assad}";
            Console.WriteLine(TestString(input));

            Console.WriteLine("String: ");
            input = " ";
            Console.WriteLine(TestString(input));


            Console.ReadLine();
        }

        public static string TestString(string input)
        {
            int countOpen = input.ToCharArray().Count(x => x == '{');
            int countClose = input.ToCharArray().Count(x => x == '}');

            if (countOpen != countClose)
            {
                return "False";
            }
            else if (countOpen == 0 && countClose == 0)
            {
                return "True";
            }
            else
            {
                for (int x = 0; x < input.Length; x++)
                {
                    if (x < input.Length - 1)
                    {
                        if (input.IndexOf('{') < input.IndexOf('}'))
                        {
                            input = input.Remove(input.IndexOf('{'), 1);
                            input = input.Remove(input.IndexOf('}'), 1);
                            x = -1;
                        }
                    }
                }

                countOpen = input.ToCharArray().Count(x => x == '{');
                countClose = input.ToCharArray().Count(x => x == '}');

                if (countOpen > 0 || countClose > 0)
                {
                    return "False";
                }
                else
                    return "True";

            }
        }


    }
}
