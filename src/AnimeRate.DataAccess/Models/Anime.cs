using System;
using System.Collections.Generic;

namespace AnimeRate.DataAccess.Models;

public partial class Anime
{
    public int AnimeId { get; set; }

    public string? Name { get; set; }

    public string? Genre { get; set; }

    public string? Type { get; set; }

    public short? Episodes { get; set; }

    public double? Rating { get; set; }

    public int? Members { get; set; }
}
