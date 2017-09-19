using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 馬力歐
{
    class Initializing:Charactor
    {
        public static string [,] map=new string [40,1000];
        public static int position_x,position_y, map_x,map_y;
        public static string face_side;
        public static void map_build()
        {
            position_x = 20; position_y = 3; map_x = 0; map_y = 0;
            face_side = "r";

        Console.SetWindowSize(105,34);
            for (int i = 0; i <21; i++)/////土地之上 [0-20] 土地[21-29] 長度 [0-999]
            {
                for (int k = 0; k < 500; k++)
                {
                    map[i, k] = "      ";
                }
            }
            for (int k = 0; k < 500; k++)
            {
                map[21, k] = "======";
            }
            for (int i = 22; i < 30; i++)
            {
                for (int k = 0; k < 500; k++)
                {
                    map[i, k] = "******";
                }
            }
            //建立各種東西
            starblock_set(7);starblock_set(9);
            block_set(10);
            starblock_set(11);
            pipe_set(13);pipe_set(20);
            starblock_set(23);starblock_set(24);
            block_set(25);
            pipe_set(30);
            block_set(38);
            block_set(49);starblock_set(50);block_set(51);
            bridge_set(59);
            block_set(63); block_set(65); block_set(67);
            starblock_set(75);
            stair_set(79);
            flag_set(95);
            princess(110);
            me();
            for (int i = 0; i < 30; i++)
            {
                for (int k = 0; k < 17; k++)
                {
                    Console.Write(map[i, k]);
                }
                Console.WriteLine("");
            }
            
        }
        public static void block_set(int y)
        {
            map[ 8, y] = "╔═╗";
            map[ 9, y] = "║╬║";
            map[10, y] = "╚═╝";
        }
        public static void unstarblock_set(int y)
        {
            map[ 8, y] = "╔═╗";
            map[ 9, y] = "║  ║";
            map[10, y] = "╚═╝";
        }
        public static void starblock_set(int y)
        {
            map[ 8, y] = "╔═╗";
            map[ 9, y] = "║★║";
            map[10, y] = "╚═╝";
        }
        public static void pipe_set(int y) //左下角開始 
        {
            map[16, y] = "╔==╗";
            map[17, y] = "║  ║";
            map[18, y] = "║  ║";
            map[19, y] = "║  ║";
            map[20, y] = "║  ║";
            map[21, y] = "╝  ╚";
        }
        public static void cliff_set(int y)
        {
            map[21, y] = "╖    ";map[21, y+1] = "      ";map[21, y+2] = "    ╓";
            map[22, y] = "║    ";map[22, y+1] = "      ";map[22, y+2] = "    ║";
            map[23, y] = "║    ";map[23, y+1] = "      ";map[23, y+2] = "    ║";
            map[24, y] = "║    ";map[24, y+1] = "      ";map[24, y+2] = "    ║";
            map[25, y] = "║    ";map[25, y+1] = "      ";map[25, y+2] = "    ║";
            map[26, y] = "║    ";map[26, y+1] = "      ";map[26, y+2] = "    ║";
            map[27, y] = "║    ";map[27, y+1] = "      ";map[27, y+2] = "    ║";
            map[28, y] = "║    ";map[28, y+1] = "      ";map[28, y+2] = "    ║";
            map[29, y] = "║    ";map[29, y+1] = "      ";map[29, y+2] = "    ║";
        }
        public static void bridge_set(int y)
        {
            map[21, y] = "＊－。"; map[21, y + 1] = "－。－"; map[21, y + 2] = "。－＊";
            map[22, y] = "║    "; map[22, y + 1] = "      "; map[22, y + 2] = "    ║";
            map[23, y] = "║    "; map[23, y + 1] = "      "; map[23, y + 2] = "    ║";
            map[24, y] = "║    "; map[24, y + 1] = "      "; map[24, y + 2] = "    ║";
            map[25, y] = "║    "; map[25, y + 1] = "      "; map[25, y + 2] = "    ║";
            map[26, y] = "║    "; map[26, y + 1] = "      "; map[26, y + 2] = "    ║";
            map[27, y] = "║    "; map[27, y + 1] = "      "; map[27, y + 2] = "    ║";
            map[28, y] = "║    "; map[28, y + 1] = "      "; map[28, y + 2] = "    ║";
            map[29, y] = "║    "; map[29, y + 1] = "      "; map[29, y + 2] = "    ║";
        }
        public static void stair_set(int y)
        {
            map[16, y  ] = "      ";map[16, y+1] = "      ";map[16, y+2] = "      ";map[16, y+3 ] = "      ";map[16, y+4] = "╔═╗";
            map[17, y  ] = "      ";map[17, y+1] = "      ";map[17, y+2] = "      ";map[17, y+3 ] = "╔═╝";map[17, y+4] = "    ║";
            map[18, y  ] = "      ";map[18, y+1] = "      ";map[18, y+2] = "╔═╝";map[18, y+3 ] = "      ";map[18, y+4] = "    ║";
            map[19, y  ] = "      ";map[19, y+1] = "╔═╝";map[19, y+2] = "      ";map[19, y+3 ] = "      ";map[19, y+4] = "    ║";
            map[20, y  ] = "╔═╝";map[20, y+1] = "      ";map[20, y+2] = "      ";map[20, y+3 ] = "      ";map[20, y+4] = "    ║";
            map[21, y  ] = "╝    ";map[21, y+1] = "      ";map[21, y+2] = "      ";map[21, y+3 ] = "      ";map[21, y+4] = "    ╚";
            map[16, y+7] = "╔═╗"; map[16, y+8] = "      ";map[16, y+9] = "      ";map[16, y+10] = "      ";map[16,y+11] = "      ";
            map[17, y+7] = "║    ";map[17, y+8] = "╚═╗";map[17, y+9] = "      ";map[17, y+10] = "      ";map[17,y+11] = "      ";
            map[18, y+7] = "║    ";map[18, y+8] = "      ";map[18, y+9] = "╚═╗";map[18, y+10] = "      ";map[18,y+11] = "      ";
            map[19, y+7] = "║    ";map[19, y+8] = "      ";map[19, y+9] = "      ";map[19, y+10] = "╚═╗";map[19,y+11] = "      ";
            map[20, y+7] = "║    ";map[20, y+8] = "      ";map[20, y+9] = "      ";map[20, y+10] = "      ";map[20,y+11] = "╚═╗";
            map[21, y+7] = "╝    ";map[21, y+8] = "      ";map[21, y+9] = "      ";map[21, y+10] = "      ";map[21,y+11] = "    ╚";

        }
        public static void flag_set(int y)
        {
            map[10, y] = "  ◣  ";
            map[11, y] = "  ▉◣";
            map[12, y] = "  ║  ";
            map[13, y] = "  ║  ";
            map[14, y] = "  ║  ";
            map[15, y] = "  ║  ";
            map[16, y] = "  ║  ";
            map[17, y] = "  ║  ";
            map[18, y] = "  ║  ";
            map[19, y] = "  ║  ";
            map[20, y] = "╔═╗";
            map[21, y] = "╚═╝";
        }
        public static void princess(int y)
        {
            map[16, y] = "╭─╮";
            map[17, y] = "≧▽≦";
            map[18, y] = "╰  ╯";
            map[19, y] = "╰█╯";
            map[20, y] = " ╯╰ ";
        }
        public static void love(int y)
        {
            map[10, y + 1] = "  ▼  ";System.Threading.Thread.Sleep(50);Process.Map_reload();
            map[9, y + 1] = "◥▉◤"; System.Threading.Thread.Sleep(50);Process.Map_reload();
            map[8, y] = "    ◥"; map[8, y + 1] = "▉▉▉"; map[8, y + 2] = "◤    ";System.Threading.Thread.Sleep(50);Process.Map_reload();
            map[7, y] = "  ◥▉"; map[7, y + 1] = "▉▉▉"; map[7, y + 2] = "▉◤  ";System.Threading.Thread.Sleep(50);Process.Map_reload();
            map[6, y] = "◥▉▉"; map[6, y + 1] = "▉▉▉"; map[6, y + 2] = "▉▉◤";System.Threading.Thread.Sleep(50);Process.Map_reload();
            map[5, y] = "◢▉▉"; map[5, y + 1] = "▉▉▉"; map[5, y + 2] = "▉▉◣";System.Threading.Thread.Sleep(50);Process.Map_reload();
            map[4, y] = "  ◢▉"; map[4, y + 1] = "◣  ◢"; map[4, y + 2] = "▉◣  ";
        }
        public static void pass_clean()
        {
            map[position_x - 4, position_y] = "      ";
            map[position_x - 3, position_y] = "      ";
            map[position_x - 2, position_y] = "      ";
            map[position_x - 1, position_y] = "      ";
            map[position_x    , position_y] = "      ";
        }


    }
}
