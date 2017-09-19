using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 馬力歐
{
    class Charactor
    {
        public static void me()
        {
            if (Initializing.face_side == "l") face_left();
            else face_right();
        }
        private static void face_right()
        {
            Initializing.map[Initializing.position_x - 4, Initializing.position_y] = "╭─╮";
            Initializing.map[Initializing.position_x - 3, Initializing.position_y] = "˙ˇ˙";
            Initializing.map[Initializing.position_x - 2, Initializing.position_y] = "╰─╯";
            Initializing.map[Initializing.position_x - 1, Initializing.position_y] = "╭▉╯";
            Initializing.map[Initializing.position_x - 0, Initializing.position_y] = " ╯╰ ";
        }
        private static void face_left()
        {
            Initializing.map[Initializing.position_x - 4, Initializing.position_y] = "╭─╮";
            Initializing.map[Initializing.position_x - 3, Initializing.position_y] = "˙ˇ˙";
            Initializing.map[Initializing.position_x - 2, Initializing.position_y] = "╰─╯";
            Initializing.map[Initializing.position_x - 1, Initializing.position_y] = "╰▉╮";
            Initializing.map[Initializing.position_x - 0, Initializing.position_y] = " ╯╰ ";
        }


    }
}
