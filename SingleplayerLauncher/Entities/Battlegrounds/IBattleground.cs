using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingleplayerLauncher.Model
{
    public interface IBattleground
    {
        string Name { get; }
        Map Map { get; set; }
        GameMode GameMode { get; set; }
        Difficulty Difficulty { get; set; }
        int StartingCoin { get; set; }
    }
}
