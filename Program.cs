using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("유저로부터 정수를 입력받기");
            string add = Console.ReadLine();
            int aaa = int.Parse(add);

            if (aaa == 1)
            {
                Console.WriteLine("Cocked Pistol 발령");

            }
            else if (aaa == 2)
            {
                Console.WriteLine("Fast Pace 발령");
            }
            else if (aaa == 3)
            {

                Console.WriteLine("Round House 발령");
            }
            else
            {
                Console.WriteLine("비상사태");
            }



            //switch (aaa)
            //{
            //    case 1:
            //    Console.WriteLine("Cocked Pistol로 발령됩니다");
            //        break;
            //    case 2:
            //        Console.WriteLine("Fast Pace로 발령됩니다");
            //        break;
            //    case 3:
            //        Console.WriteLine("Round House으로 발령됩니다");
            //        break;
            //    default:
            //        Console.WriteLine("비사상태");
            //        break;
            //}


            //Console.WriteLine("몇 회 반복하시겠습니까 ?");
            //string asd = Console.ReadLine();
            //int add = int.Parse(asd);

            //Console.WriteLine("add");

            //int counter;
            //for(int i = 0; i < add; i++)
            //{
            //    Console.WriteLine("add");
            //}

            //

            // if(조건값) else
            //if (4 < 1)
            //{
            //    Console.WriteLine("This is True");
            //}
            //else if (4 > 1)
            //{
            //    Console.WriteLine("This is False");
            //}
            //else 
            //{
            //    Console.WriteLine("Test");
            //}

            //

            // swich-case 문

            //for (int i = 0; i <= 4; i++) 
            //{
            //    switch (i) 
            //    {
            //        case 1:
            //            Console.WriteLine("매일");
            //            break;
            //        case 2:
            //            Console.WriteLine("복습");
            //            break;
            //        case 3:
            //            Console.WriteLine("한다");
            //            break;

            //        default:
            //            Console.WriteLine("매일");
            //            break;

            //

            // 반복문
            // for문에서 사용할 변수등을 초기화 하는 코드가 들어가며 조건문은 for문이
            // 검사할 조건이 들어가며 반복문은 for문안의 코드가 실행될때마다 수행될 코드가 들어감
            // int i = 0 - for문 내에서 사용할 변수를 만들고 변수의 초기화 해주는 문구
            // i는  오직 for문 내에서만 정의된 변수라 for문 내부에서만 사용할 수 있다
            // i<=4 - 조건문. i가 4보다 작거나 같을 경우에만 for문이 반복된다
            // i++ - 반복문. for문 내 코드를 1회 실행한 다음 실행할 코드

            // while, do
            // while (조건문)
            // {
            //    실행할 코드 
            // }


            Console.WriteLine("정수의 합을 구해라");
            //string aaa = Console.ReadLine();
            //int aaa2 = int.Parse(aaa);

            Console.WriteLine("정수");
            string bbb = Console.ReadLine();
            int bbb2 = int.Parse(bbb);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }


            int num = 0;
            while (num < 10)
            {
                Console.WriteLine(num);
                num++;

            }

            //int num = 4;
            int cnt = 0;

            while (num <= 7)

            {

                cnt += num;
                num++;
                Console.WriteLine(cnt);
                num += 1;
                num = num + 1;

                //    4+5+6+7


                }

                 Console.WriteLine("만든다");




                //int add = int.Parse(Console.ReadLine());

                //int add2 = int.Parse(Console.ReadLine());


                //for (int i = add; i < add2; i++)
                //{
                //Console.WriteLine(i);
                //}

                //int add = int.Parse(Console.ReadLine());
                //int add2 = int.Parse(Console.ReadLine());

                //for (int cen = add; cen < add2; cen++) 
                //{
                //    Console.WriteLine(cen);

                //}



                //string aka = Console.ReadLine();
                //int rere = int.Parse(aka);

                //int rere = int.Parse(Console.ReadLine());

                //string akk = Console.ReadLine();
                //int riri = int.Parse(akk);

                //Console.WriteLine($"{rere + riri}");






                //int aka = int.Parse(Console.ReadLine());
                //int aka2 = int.Parse(Console.ReadLine());

                //for (int i = 1; i < 10; i+=2) {

                //}
                //for (int i = 1; i < 10; i ++)
                //{
                //    if (//홀수구별)
                //{

                //}





            }

        }
    }
