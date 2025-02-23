using System;
using System.Collections.Generic;

namespace Mission08_Roney.Models;

public partial class Fielding
{
    public string? PlayerId { get; set; }

    public int? YearId { get; set; }

    public int? Stint { get; set; }

    public string? TeamId { get; set; }

    public string? LgId { get; set; }

    public string? Pos { get; set; }

    public int? G { get; set; }

    public int? Gs { get; set; }

    public int? InnOuts { get; set; }

    public int? Po { get; set; }

    public int? A { get; set; }

    public int? E { get; set; }

    public int? Dp { get; set; }

    public int? Pb { get; set; }

    public int? Wp { get; set; }

    public int? Sb { get; set; }

    public int? Cs { get; set; }

    public double? Zr { get; set; }
}
