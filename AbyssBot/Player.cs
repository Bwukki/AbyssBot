using System;
using System.Collections.Generic;
using System.Text;

namespace AbyssBot
{
    class Player : Agent
    {
        int xp;
        int stamina;
        string buffs; //probably separate them with some kind of delimiter then iterate through whenever you want them.. alternative use a List<t> or maybe an array
    }
}
