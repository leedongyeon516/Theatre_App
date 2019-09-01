using System;

namespace Theatre
{
    [Flags]
    enum Genre
    {
        Unrated = 0,
        Action = 1,
        Romance = 2,
        Documentary = 4,
        Mystery = 8,
        Musical = 16,
        Horror = 32,
        Comedy = 64,
        Fantasy = 128,
        Animation = 256,
        Adventure = 512
    }
}
