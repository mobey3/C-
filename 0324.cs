using System;

namespace _0324
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.Write("숫자 입력: ");
            double input = double.Parse(Console.ReadLine());

             if (input % 2 == 0)
             {
                 Console.WriteLine("짝수입니다!");
             }
             if (input % 2 != 0)
             {
                 Console.WriteLine("홀수입니다!");
             }*/

            /* Console.WriteLine(DateTime.Now.Year);  //AddYears(-1) (.Year << 년도만)
             Console.WriteLine(DateTime.Now.Month);  //AddMonths() (.Month<<분만)
             Console.WriteLine(DateTime.Now.Day);   //AddDays() (.Day<<날짜만)
             Console.WriteLine(DateTime.Now.Hour);  //AddHours() (.Hour <<시간만)
             Console.WriteLine(DateTime.Now.Minute);
             Console.WriteLine(DateTime.Now.Second);*/

            /* if (DateTime.Now.AddHours(5).Hour < 12)
             {
                 Console.WriteLine("오전입니다.");
             }    
             else 
             {
                 Console.WriteLine("오후입니다.");
             }    */

            /* if (DateTime.Now.Hour < 11)
             {
                 Console.WriteLine("아침 먹을 시간입니다.");
             }
             else
             {
                 if (DateTime.Now.Hour < 15)
                 {
                     Console.WriteLine("점심 먹을 시간입니다.");
                 }
                 else
                 {
                     Console.WriteLine("저녁 먹을 시간입니다.");
                 }*/

            /*Console.Write("성적 입력(4.5까지): ");
            double score = double.Parse(Console.ReadLine());
            
            if (score == 4.5)
                Console.WriteLine("신");

            else if (4.2 <= score)
                Console.WriteLine("교수님의 사랑");

            else if (3.5 <= score)
                Console.WriteLine("현 체제의 수호자");

            else if (2.8 <= score)
                Console.WriteLine("일반인");

            else if (2.3 <= score)
                Console.WriteLine("일탈을 꿈꾸는 소시민");

            else if (1.75 <= score)
                Console.WriteLine("오락문화의 선구자");

            else if (1.0 <= score)
                Console.WriteLine("불가촉천민");

            else if (0.5 <= score)
                Console.WriteLine("자벌레");

            else if (0 < score)
                Console.WriteLine("플랑크톤");
            else
                Console.WriteLine("시대를 앞서나가는 혁명의 씨앗");*/

            /*Console.Write("이번 달은 몇 달인가요: ");
            int input = int.Parse(Console.ReadLine());

            switch(input)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가을");
                    break;
                default :
                    Console.WriteLine("돌앗나");
                    break;
        }*/

            /*string input = Console.ReadLine();
            int number = int.Parse(input);

            //Console.WriteLine(number > 0 ? (number == 12? "12" : "12아님")
            Console.WriteLine(number > 0 ? "자연수입니다" : 0);*/

            /*            ConsoleKeyInfo info = Console.ReadKey();
                        switch(info.Key)
                        {
                            case ConsoleKey.UpArrow:
                                Console.WriteLine("위로 이동");
                                break;
                            case ConsoleKey.RightArrow:
                                Console.WriteLine("오른쪽으로 이동");
                                break;
                            case ConsoleKey.DownArrow:
                                Console.WriteLine("아래로 이동");
                                break;
                            case ConsoleKey.LeftArrow:
                                Console.WriteLine("왼쪽으로 이동");
                                break;
                            default:
                                Console.WriteLine("눈깔없나");
                                break;
                        }*/

            /* Console.Write("태어난 년도: ");
             int A = int.Parse(Console.ReadLine());
             int B = A % 12;

             switch (B)
             {
                 case 0:
                     Console.WriteLine("원숭이");
                     break;
                 case 1:
                     Console.WriteLine("닭");
                     break;
                 case 2:
                     Console.WriteLine("개");
                     break;
                 case 3:
                     Console.WriteLine("돼지");
                     break;
                 case 4:
                     Console.WriteLine("쥐");
                     break;
                 case 5:
                     Console.WriteLine("소");
                     break;
                 case 6:
                     Console.WriteLine("범");
                     break;
                 case 7:
                     Console.WriteLine("토끼");
                     break;
                 case 8:
                     Console.WriteLine("용");
                     break;
                 case 9:
                     Console.WriteLine("뱀");
                     break;
                 case 10:
                     Console.WriteLine("말");
                     break;
                 case 11:
                     Console.WriteLine("양");
                     break;
             }*/

            /* Console.Write("학점: ");
             int C = int.Parse(Console.ReadLine());

             if (98 <= C)
                 Console.WriteLine("A+");
             else if (94 <= C)
                 Console.WriteLine("A");
             else if (90 <= C)
                 Console.WriteLine("A-");
             else if (88 <= C)
                 Console.WriteLine("B+");
             else if (84 <= C)
                 Console.WriteLine("B");
             else if (80 <= C)
                 Console.WriteLine("B-");
             else if (78 <= C)
                 Console.WriteLine("C+");
             else if (74 <= C)
                 Console.WriteLine("C");
             else if (70 <= C)
                 Console.WriteLine("C-");
             else if (68 <= C)
                 Console.WriteLine("D+");
             else if (64 <= C)
                 Console.WriteLine("D");
             else if (60 <= C)
                 Console.WriteLine("D-");
             else 
                 Console.WriteLine("F");*/

            /* Console.WriteLine("주민번호: ");
             string D = Console.ReadLine();

             if (D[0] == '0')
             {
                 Console.WriteLine("00년 이후");
             }
             else
             {
                 Console.WriteLine("00년 이전");
             }
             if (D[6] == '1')
             {
                 Console.WriteLine("남자");
             }
             else if (D[6] == '3')
             {
                 Console.WriteLine("남자");
             }
             else if (D[6] == '2')
             {
                 Console.WriteLine("여자");
             }
             else if (D[6] == '4')
             {
                 Console.WriteLine("여자");
             }*/

            /* Console.WriteLine("사용량: ");
             double amount = double.Parse(Console.ReadLine());
             //basic , price , total

             if (501 <= amount)
             {
                 amount = 9330 + 5200 + 8850 + 12780 + 18430 + 27430 + (amount - 500) * 494;
                 double total = amount * 0.09;
                 Console.WriteLine((amount + total) + "원");
             }
             else if (401 <= amount)
             {
                 amount = 5130 + 5200 + 8850 + 12780 + 18430 + ((amount - 400) * 274.3);
                 double total = amount * 0.09;
                 Console.WriteLine((amount + total) + "원");
             }
             else if (301 <= amount)
             {
                 amount = 2710 + 5200 + 8850 + 12780 + ((amount - 300) * 184.3);
                 double total = amount * 0.09;
                 Console.WriteLine((amount + total) + "원");
             }
             else if (201 <= amount)
             {
                 amount = 1130 + 5200 + 8850 + ((amount - 200) * 127.8);
                 double total = amount * 0.09;
                 Console.WriteLine((amount + total) + "원");
             }
             else if (101 <= amount)
             {
                 amount = 660 + 5200 + ((amount - 100) * 88.5);
                 double total = amount * 0.09;
                 Console.WriteLine((amount + total) + "원");
             }
             else if (1 <= amount)
             {
                 amount = 370 + (amount * 52);
                 double total = amount * 0.09;
                 Console.WriteLine((amount + total) + "원");
             }
             else
                 Console.WriteLine("0원");*/

            /*int[] intArray = new int[100];

            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[99]);*/

            /*int i = 0;
            int[] intArray = { 52, 273, 32, 65, 103 };

            while(i < intArray.Length)
            {
                Console.WriteLine(i+1 + "번째 출력: " + intArray[i]);
                i++;
            }*/

            /*string input;
            do
            {
                Console.Write("입력(exit을 입력하면 종료): \n");
                input = Console.ReadLine();
            } while (input != "exit");*/
        }

    }
}
