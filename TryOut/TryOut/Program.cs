using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryOut
{
    class Program
    {
        static void Main(string[] args)
        {
            #region tuples
            //int[] numbers = new int[10];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    //Console.WriteLine(numbers[i] = i * i);
            //    Console.WriteLine($"numbers[{i}] = {numbers[i]}");
            //}

            //Console.WriteLine("************");

            //Tuple<int, string, bool> tuple = new Tuple<int, string, bool>(54, "bob", true);

            //Console.WriteLine(tuple.Item1);
            //Console.WriteLine(tuple.Item2);
            //Console.WriteLine(tuple.Item3);

            //Console.WriteLine("%%%%%%%%%%%%%%%%%%%%");

            //var tupleMethod = new Tuple<string, string[], int, int[], int, int>("perl",
            //                                                         new string[] { "one", "two" },
            //                                                         1,
            //                                                         new int[] { 2, 4, 6 },
            //                                                         7,
            //                                                         9);
            //Method(tupleMethod);

            //var tups = Tuple.Create(1, "one");
            //Console.WriteLine(tups);     
            #endregion

            var dict = new Dictionary<int, string>
            {
                { 1, ""},
                { 2, ""},
            };

            #region GetValueOrDefault
            //float? num1 = null, num2 = 2;
            //var sum = num1.GetValueOrDefault(0) + num2.GetValueOrDefault(0);
            //Console.WriteLine(sum);
            //Console.WriteLine("num1: {0}", num1);
            //Console.WriteLine("num2: {0}", num2); 
            #endregion

            //var input = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };
            //var output = new int[] { };

            //int i = 0;
            //for (i = 0; i < input.Length -1; i++)
            //{
            //    if (input[i] > 0)
            //    {
            //        Console.WriteLine(input[i]); //count
            //    }
            //    else if (input[i] < 0)
            //    {
            //        output[1] = input[i]+ input[i];

            //    }
            //}

            //foreach (var item in output)
            //{
            //    Console.WriteLine(item);
            //}

            #region Rabdom
            object[] haystack = new object[] { "hay", "junk", "hay", "hay", "moreJunk", "needle", "randomJunk" };

            //FindNeedle(haystack);

            int[] arr = { 1, 2, 3, 4, 10, 11 };

            //string s = "";
            //int h = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    //s = arr[i].ToString();
            //    //Console.WriteLine(s);

            //    h = i + arr[i];

            //    Console.WriteLine(h + "--");
            //}

            var a = new int[] { 5, 6, 7 };
            var b = new int[] { 3, 6, 10 };

            //solve(a, b); 
            #endregion


            //simpleArraySum(arr);

            #region random
            //ArrangeArray(21445);

            //int number = 21445, temp = 0;

            //string numberArr = number.ToString();

            //Console.WriteLine(numberArr.ToArray());

            //if (number > 0)
            //{
            //    if (number > 1000)
            //    {
            //        for (int i = 0; i < numberArr.Length; i++)
            //        {
            //            for (int j = 0; j < numberArr.Length - 1; j++)
            //            {
            //                if (numberArr[j] < numberArr[j + 1])
            //                {
            //                    temp = numberArr[j + 1];
            //                    int plus1 = numberArr[j + 1];
            //                    plus1 = numberArr[j];
            //                    int noPlus1 = numberArr[j];
            //                    noPlus1 = temp;
            //                }
            //            }
            //        }
            //    }
            //}

            //for (int i = 0; i < numberArr.Length; i++)
            //{
            //    Console.Write(numberArr[i]);
            //} 
            #endregion

            //var arra = new int[] { 1, 2, 3, 4, 5 };
            //foreach (var item in arra)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in Power(2, 8))
            //{
            //    Console.WriteLine(item);
            //}

            //string text = "The sunset sets at twelve o' clock.";

            //var l = text.Substring(0, text.Length - 1);
            //var items = text.Split(',').ToString();
            //foreach (var item in text.ToString())
            //{
            //    var itemss = item.ToString();
            //    var k = string.Join(",", itemss);
            //    Console.WriteLine(k);
            //}
            //Console.WriteLine(items);

            //int[] rt = new int[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 };

            //foreach (var item in rt)
            //{
            //    if (item % 0 == 1)
            //    {

            //    }
            //}

            //string h = "    jk  lkdv dv dv d";

            //string g = h.Substring(0, h.Length - 1);
            //h.Replace("", "-");
            //Console.WriteLine(h);
            
        Console.WriteLine("-----");
            Console.ReadLine();
        }

        public static bool XO(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Equals("x"))
                {

                }
            }

            return false;//Code it! 
  }

        public static string Solution(string str)
        {
            string reverse = "";
            for (int i = str.Length-1; i <= str.Length-1; i--)
            {
                if (i >= 0)
                {
                    Console.Write(reverse = str[i].ToString());
                }
            }

            return reverse;
        }

        public static IEnumerable<int> Power(int number, int exponent)
        {
            int result = 1;

            for (int i=0; i < exponent; i++)
            {
                result = result * number;
                
            }

            yield return result;
        }

        public static IEnumerable<int> RunningTotal(int[] arr)
        {
            int runningTotal = 0;

            foreach (var item in arr)
            {
                runningTotal += item;
                yield return runningTotal;
            }
        }

        public static IEnumerable<string> FriendOrFoe(string names)
        {
            var Input = new string[] { "Ryan", "Kieran", "Jason", "Yous"};
            var output = new string[] { };

            for (int i = 0; i < Input.Length; i++)
            {
                if (Input[i].Equals(4))
                {
                    output[i] = Input[i];
                }
            }

            var it = Input.Where(y => y.Length == 4)
                          .Select(x => x);

            if (names.Equals(4))
            {

            }

            return it;
        }

        public static string Likes(string[] name)
        {
            string ans = null;

            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] != name[0])
                {
                    ans = name[i] + " likes this";
                }
                else
                {
                    ans = "No one likes this";
                }
            }

            return ans;
        }

        private static void Method(Tuple<string, string[], int, int[], int, int> tuple)
        {
            Console.WriteLine("Item 1: " + tuple.Item1);
            foreach (var item in tuple.Item2)
            {
                Console.WriteLine("Item 2: " + item);
            }

            Console.WriteLine("Item 3: " + tuple.Item3);
            foreach (var item in tuple.Item4)
            {
                Console.WriteLine("Item 4: " + item);
            }
        }

        private static void ArrangeArray(int num)
        {
            #region MyRegion
            //string item = "";
            //var temp = 0;

            //if (num > 0)
            //{
            //    //if (num > 1000)
            //    //{
            //    //   item = string.Join(" ", num);
            //    //    var items = item.ToArray();                                       

            //    //    for (int i = 0; i < items.Length; i++)
            //    //    {
            //    //        for (int j = 0; j < items.Length - 1; j++)
            //    //        {
            //    //            if (items[j] < items[j + 1])
            //    //            {
            //    //                temp = items[j + 1];
            //    //                items[j + 1] = items[j];
            //    //                items[j] = temp;
            //    //            }
            //    //        }
            //    //    }
            //    //}
            //}
            //else
            //{
            //    Console.WriteLine("number must be positive");
            //} 
            #endregion

            int[] arr = { 802, 34, 5, 65, 76, 2, 23 };

            int temp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public static void FindNeedle(object[] haystack)
        {
            //string answer = "";

            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i].ToString() == "needle")
                {
                    Console.WriteLine("found the needle at position " + i);
                }
            }

            //return answer;
        }

        public static int simpleArraySum(int[] ar)
        {
            int sum = 0;

            for (int i = 0; i < ar.Length; i++)
            {
                sum = ar[i] + ar[i + 1];
            }

            Console.WriteLine(sum);

            return sum;
        }
        private static void solve(int[] a, int[] b)
        {
            var aPoints = new int[] { };
            var bPoints = new int[] { };
            var cPoints = new int[] { };

            List<int> c = new List<int>();
            List<int> d = new List<int>();
            List<int> e = new List<int>();

            if (a[0] > b[0])
            {
                c.Add(1);
            }
            else if (a[1] < b[1])
            {
                d.Add(1);
            }

            foreach (var item in c)
            {
                e.Add(item);
            }

            foreach (var item in d)
            {
                e.Add(item);
            }

            //e.Add(Convert.ToInt32(c));
            //e.Add(Convert.ToInt32(d));



            //cPoints[0] = aPoints[0];
            //cPoints[1] = bPoints[0];

            //for (int i = 0; i < cPoints.Length; i++)
            //{
            //    Console.WriteLine(i);
            //}

            foreach (var item in e)
            {
                Console.WriteLine(item);
            }
        }

        private int[] arrCount()
        {
            var input = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }

            var output = new int[] { 10, -65 };
            return output;
        }
    }
}
