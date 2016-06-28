using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMirror.Model
{
    class sports
    {
        String yourTeam { get; set; }
        String nextOpponent { get; set; }
        int[] lastResult = new int[2];
        DateTime nextGame { get; set; }
    }
}
