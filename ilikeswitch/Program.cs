using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ilikeswitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("학년을 입력하세요 : ");
            int level = int.Parse(Console.ReadLine());
            int hakjum = 0;
            switch(level){
                case 1:
                    hakjum = 12;
                    break;
                case 2:
                    hakjum = 18;
                    break;
                case 3:
                    hakjum = 10;
                    break;
                case 4:
                    hakjum = 18;
                    break;
                default:
                    Console.WriteLine("잘못입력하셨습니다.");
                    break;
            }
            Console.WriteLine("수강해야 하는 전공 학점 : "+hakjum+"학점")
        }
    }
}
