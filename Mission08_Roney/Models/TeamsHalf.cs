using System;
using System.Collections.Generic;

namespace Mission08_Roney.Models;

public partial class TeamsHalf
{
    public int? YearId { get; set; }

    public string? LgId { get; set; }

    public string? TeamId { get; set; }

    public string? Half { get; set; }

    public string? DivId { get; set; }

    public string? DivWin { get; set; }

    public int? Rank { get; set; }

    public int? G { get; set; }

    public int? W { get; set; }

    public int? L { get; set; }
}
