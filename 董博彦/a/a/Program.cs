using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===欢迎使用minibank存取款！===");
            Console.WriteLine("输入阿拉伯一存款，输入阿拉伯二取款.");
            int a = int.Parse(Console.ReadLine());
            switch(a){
                case 1: Console.WriteLine("请输入存钱的金额:");
                    int cq = int.Parse(Console.ReadLine());
                    int zH = 5000;
                    int zhc = zH - cq;
                    if (cq < 0||zhc%100!=0) {
                        Console.WriteLine("输入金额错误，钱归我了,只能输入100元的倍数!");
                    }else {
                        Console.WriteLine("目前账户余额为："+zhc);
                    }

                break;
                case 2:
                Console.WriteLine("请输入取钱的金额:");
                int qq = int.Parse(Console.ReadLine());
                int zH2 = 5000;
                int zhq=zH2-qq;
                if (qq < 0||(zhq%100!=0))
                { Console.WriteLine("输入金额错误，只能输入100元的倍数!");
                }else if(qq>zH2){
                 Console.WriteLine("金额超过账户，瓜娃儿你没得钱了!");
                }else{
                Console.WriteLine("取完钱后你的龟儿账户为"+zhq);
                }
                
                
                break;
            }

        }
    }
}
