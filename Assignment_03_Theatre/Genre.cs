using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_Theatre
{
    [Flags]
    public enum Genre
    {
        Unrated = 1,
        Action = 2,
        Romance = 4,
        Documentary = 8,
        Mystry = 16,
        Musical = 32,
        Horror = 64,
        Comedy = 128,
        Fantasy = 256,
        Animation = 512,
        Adventure = 1024
    }
}
