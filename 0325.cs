using System;
using System.Threading;

namespace _0325
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int output = 0;

             for (int i = 0; i <= 100; i++)
             {
                 output += i;
             }
             Console.WriteLine(output);

             for (int i = 0; i <= 100; i+=2)
             {
                 output += i;
             }
             Console.WriteLine(output);

             for (int i = 0; i <= 100; i+=3)
             {
                 output += i;
             }
             Console.WriteLine(output);*/

            /*long start = DateTime.Now.Ticks;
            long count = 0;

            while (start + (10000000) > DateTime.Now.Ticks)
            {
                count++;
            }
            Console.WriteLine(count + "만큼 반복했습니다.");*/

            /*int[] intArray = { 1, 2, 3, 4, 5, 6 };

            for (int i = intArray.Length-1; i >=0; i--)
            {
                Console.WriteLine(intArray[i]);
            }*/

            /*string[] array = { "사과", "배", "포도", "딸기", "바나나" };

            foreach (string item in array)
            {
                Console.WriteLine("\n"+item);
            }*/

            /*for (int i = 0; i < 25; i += 1)  //피라미드
            {
                for (int j = 0; j < 25 - i; j++)
                    Console.Write(' ');
                for (int j = 0; j < i * 2 + 1; j++)
                    Console.Write("*");
  
                {
                    for (int j = 40; j > 1; j--)  //역 피라미드
                        Console.Write(' ');
                    for (int j = 40; j > i * 2 - 1; j--)
                        Console.Write("*");
                    Console.Write('\n');
                }
            }*/

            /*while (true)
            {
                Console.Write("숫자를 입력해주세요(짝수를 입력하면 종료): ");
                int input = int.Parse(Console.ReadLine());
                if (input % 2 == 0)
                {
                    break;
                }
            }*/

            /* for (int i = 0; i<10; i++)
             {
                 Console.WriteLine("외부 반복문");
                 for(int j = 0;j < 10; j++)
                 {
                     Console.WriteLine("내부 반복문");
                     goto doNotUse;
                 }
             }
           doNotUse:
               Console.WriteLine("goto 키워드");
 */
            /*for ( int i = 1; i <10; i++)
             {
                 if (i % 2 ==0)
                 {
                     continue;
                 }
                 Console.WriteLine(i);
             }    */

            /*string input = "Potato Tomato";
            Console.WriteLine(input.ToUpper());
            Console.WriteLine(input.ToLower());*/

            /*string input = "감자 고구마 토마토";
            string[] inputs = input.Split(new char[] { ' ' });*/
            //string[] input = input.Split(''); 104대신 사용가능

            /*foreach (var item in inputs)
            {
                Console.WriteLine(item);
            }*/

            /*string input = " test      \n";
            Console.WriteLine("::" + input.Trim() + "::");
            Console.Read(); */

            /*string[] array = { "감자", "고구마", "토마토", "가지" };
            Console.WriteLine(string.Join(",", array));*/

            /* Console.Write("메서드 호출 전");
             Console.SetCursorPosition(5, 5);
             Console.Write("메서드 호출 후");*/

            /*  Console.WriteLine("첫 번째 출력");
              Thread.Sleep(1000);
              Console.WriteLine("두 번째 출력");
              Thread.Sleep(1000);
              Console.WriteLine("세 번째 출력");*/

            /* int x = 1;
             while (x < 100)
             {
                 // 화면을 지우고 커서를 이동합니다.
                 Console.Clear();
                 Console.SetCursorPosition(x, 50); //움직임

                 if (x % 2 == 0)
                 {
                     Console.WriteLine(" --@");
                 }
                 else if (x % 2 == 1)
                 {
                     Console.WriteLine("_^@");
                 }
                 else
                 {
                     Console.WriteLine("^_@");
                 }

                 Thread.Sleep(100); //시간부여
                 x++;
                 Console.WriteLine();
             }*/

            /*            int i = 0;

                        while (i<10)
                        {
                            Console.Write("출력");
                            i++;
                        }*/

            /*for (int i = 0; i < 25; i += 1)  //피라미드
           {
               for (int j = 0; j < 25 - i; j++)
                   Console.Write(' ');
               for (int j = 0; j < i * 2 + 1; j++)
                   Console.Write("*");

               {
                   for (int j = 40; j > 1; j--)  //역 피라미드
                       Console.Write(' ');
                   for (int j = 40; j > i * 2 - 1; j--)
                       Console.Write("*");
                   Console.Write('\n');
               }
           }*/
           /* int i;
            int[] a = new int[5];
            int max = a[0];
            int min = a[0];

            for (i = 0; i < 5; i++)
            {
                Console.Write("5개의 수 입력: ");
                a[i] = int.Parse(Console.ReadLine());
            }
            for (i = 1; i < 5; i++)
            {
                if (max < a[i])
                    max = a[i];
            }

            for (i = 1; i < 5; i++)
            {
                if (min > a[i])
                    min = a[i];
            }
            Console.WriteLine("최댓값: " + max);
            Console.WriteLine("최소값: " + min);
*/

            // 첫 번째 수열 입력
            string start = "1";

            // 계산 시작
            for (int i = 0; i < 20; i++)
            {
                // 출력
                Console.WriteLine((i + 1) + "번째: " + start);

                // 읽고 말하기 수열 계산
                string end = "";
                //말하기 수열 연속자리 비교를 위한 변수
                char number = start[0];
                //각각의 숫자 세기 위해
                int count = 0;
                for (int j = 0; j < start.Length; j++)
                {
                    //연속 숫자가 다르면 end 에 문자열 붙이고
                    //num에 다른 숫자를 대입
                    //횟수(count)는 여기서 부터 시작이므로 1 로 초기화
                    if (number != start[j])
                    {
                        end = end + number + count;
                        number = start[j];
                        count = 1;
                    }
                    else   //연속 숫자의 갯수를 센다
                    {
                        count++;
                    }
                }
                end = end + number + count;

                // 다음 단계 준비
                start = end;
            }


        }
    }
}

            