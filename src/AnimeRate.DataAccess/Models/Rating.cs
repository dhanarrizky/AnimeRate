using System;
using System.Collections.Generic;

namespace AnimeRate.DataAccess.Models;

public partial class Rating
{
    public int UserId { get; set; }

    public int AnimeId { get; set; }

    public int Rating1 { get; set; }
}
