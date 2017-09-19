using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 馬力歐
{
    class Process:Initializing
    {
        public static void Map_reload()
        {
            Console.Clear();
            for (int i=map_x; i < 30; i++)
            {
                for (int k=map_y; k < 17+map_y; k++)
                {
                    Console.Write(map[i, k]);
                }
                Console.WriteLine("");
            }
        }
        public static void move_where()
        {
            ConsoleKeyInfo go = Console.ReadKey();
            switch (go.Key)
            {//移動方向
                case ConsoleKey.LeftArrow: Move_Direction.left(); break;
                case ConsoleKey.RightArrow: Move_Direction.right(); break;
                case ConsoleKey.UpArrow: Move_Direction.up(); break;
                case ConsoleKey.DownArrow: Move_Direction.down(); break;
                default: break;
            }
            while (map[position_x + 1, position_y] == "      ") { Move_Direction.down();}//墜落
        }
    }
    class Move_Direction:Initializing
    {
        public static void right()
        {
            if (map[position_x, position_y + 1] != "║  ║"&& map[position_x, position_y + 1] != "║    "&& map[position_x, position_y + 1] != " ╯╰ ")
            {
               pass_clean(); //清除原位置
               face_side = "r";//面相右
               if (position_y > 4)
                {
                    if (map[position_x, position_y + 1] == "╔═╝"|| map[position_x, position_y + 1] == "╔═╗")
                    {//若前方為階梯 上樓梯
                        position_x--;
                    }
                    map_y++;
                }
               position_y++; me();
               
               if (map[position_x - 1, position_y] == "╔==╗")
               {
                   down();
               }

                
            }
        }
        public static void left()
        {
            if (map[position_x, position_y - 1] != "║  ║"&& map[position_x, position_y - 1] != "    ║"&&position_y>1)
            {
                pass_clean(); //清除原位置
                face_side = "l";//面向左
                if (position_y > 4 && map_y > 0)
                {
                    if (map[position_x, position_y - 1] == "╚═╗"|| map[position_x, position_y - 1] == "╔═╗")
                    {//若前方為階梯 上樓梯
                        position_x--;
                    }
                    map_y--;
                }
                position_y--; me();
            }
        }
        public static void up()
        {
            pass_clean(); //清除原位置
            position_x-=5; me();
            hit_detect();//判斷有無撞到東西XD
            Process.Map_reload() ; System.Threading.Thread.Sleep(100);
            if (map[20, position_y + 1] == "║  ║" || map[20, position_y + 1] == "║    " && face_side == "r") right(); //前方為障礙物則跳上去
            else if (map[20, position_y - 1] == "║  ║"|| map[20, position_y - 1] == "    ║" && face_side == "l") left();
            else
            {//單純跳
                pass_clean(); //清除原位置
                position_x += 5; me();
                Process.Map_reload();
            }

        
         }
        public static void down()
        {
            pass_clean(); //清除原位置
            if (map[position_x + 1, position_y] != "======")  position_x += 1; me();
        }
        public static void hit_detect()
        {
            if (map[position_x - 6, position_y] == "║★║")
            {//撞擊星星方塊
                map[position_x - 6, position_y] = "║☆║";
                map[position_x - 8, position_y] = "  ★  "; Process.Map_reload();
                System.Threading.Thread.Sleep(40); map[position_x - 8, position_y] = "      ";
                map[position_x - 9, position_y] = "  ★  "; Process.Map_reload();
                System.Threading.Thread.Sleep(40); map[position_x - 9, position_y] = "      ";
            }
            else if (map[position_x - 5, position_y] == "﹋﹋﹋")
            {//撞擊被撞過的普通方塊
                map[position_x - 5, position_y] = "      "; Process.Map_reload();
                map[position_x - 6, position_y] = "﹋﹋﹋"; Process.Map_reload(); System.Threading.Thread.Sleep(10);
                map[position_x - 6, position_y] = "      "; Process.Map_reload(); System.Threading.Thread.Sleep(10);
                map[position_x - 7, position_y] = "﹋﹋﹋"; Process.Map_reload(); System.Threading.Thread.Sleep(10);
                map[position_x - 7, position_y] = "      "; Process.Map_reload(); 
            }
            else if (map[position_x - 6, position_y] == "║╬║")
            {//撞擊普通方塊
                map[position_x - 5, position_y] = "﹋﹋﹋"; Process.Map_reload();
            }


        }
    }
}
