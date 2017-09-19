using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 馬力歐
{
    class Game
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Initializing.map_build();
                game();
            }
        }
        static void game()
        {
            while (true)
            {
                Process.move_where();
                Process.Map_reload();
                if (Initializing.position_x > 27) {Console.Clear(); break; }//墜落死亡
                if (Initializing.map[Initializing.position_x, Initializing.position_y+2] == " ╯╰ ")
                {
                    Initializing.map[Initializing.position_x - 3, Initializing.position_y] = "≧▽≦";
                    Initializing.love(Initializing.position_y);
                }
            }
        }
    }
}
