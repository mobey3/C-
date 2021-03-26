using System;
using System.Threading;
using System.Collections.Generic;  // list 사용할때 필요


namespace _0326
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int[,] b = new int[5,5];  // new int[,]안에 선언한 값 곱한값이 length에 찍힘
             int[][] j = new int[5][]; // 열 값만 length에 찍힘
             j[0] = new int[] { 1, 24, 5, 6}; //행에 값 초기화

             int[][] a ={     // 인트 선언한 값만 length new int '2'개찍힘
             new int[3],
             new int[5]
             };

             Console.WriteLine("" + a.Length); 

             for(int show1 =0; show1 < a.Length; show1++)
             {      
                 for (int show2 = 0; show2 < a[show1].Length; show2++)
                 {

                 }    
             }*/

            /* Car car = new Car();
             car.SetInTime();
             Thread.Sleep(5000);
             car.SetOutTime();
 */

            /*Random random = new Random();
            Console.WriteLine(random.Next(1, 46));
            Console.WriteLine(random.Next(1, 46));
            Console.WriteLine(random.Next(1, 46));
            Console.WriteLine(random.Next(1, 46));
            Console.WriteLine(random.Next(1, 46));
            Console.WriteLine(random.Next(1, 46));
            Console.WriteLine();
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());*/

            /*List<int> list = new List<int>();

            list.Add(52);
            Console.WriteLine(list.Count);
            list.Add(273);
            Console.WriteLine(list.Count);
            list.Add(32);
            Console.WriteLine(list.Count);
            list.Add(64);
            Console.WriteLine(list.Count);

            foreach (var item in list)
            {
                Console.WriteLine("count: " + list.Count + "\titem: " + item);
            }*/

            /*List<int> list = new List<int>() { 52, 273, 32, 64 };         // 위 내용을 이렇게 변경가능

            foreach(var item in list)
            {
                Console.WriteLine("Count: " + list.Count + "\titem: " + item);
            }*/


            /* List<int> list = new List<int>(){ 52, 273, 32, 64 };

             list.Remove(52);
             list.RemoveAt(0);

             foreach(var item in list)
             {
                 Console.WriteLine("count: " + list.Count + "\titem: " +item);
             }*/

            /*  List<string>list = new List<string>(){ "사과","배","포도","복숭아"};

               list.Add("블루베리");         //list 추가 list.Add 

               foreach(var item in list)
               {
                   Console.WriteLine("Count: " + list.Count + "\titem: " + item);
               }

               list.Remove("포도");
               list.RemoveAt(2);

               foreach(var item in list)
               {
                   Console.WriteLine("Count: " + list.Count + "\titem: " + item);
               }*/

            Console.WriteLine(Math.Abs(-52273));
            Console.WriteLine(Math.Ceiling(52.273));
            Console.WriteLine(Math.Floor(52.273));
            Console.WriteLine(Math.Max(52, 273));
            Console.WriteLine(Math.Min(52, 273));
            Console.WriteLine(Math.Round(52.273));


        }
    }
}
