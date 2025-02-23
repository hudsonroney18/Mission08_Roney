using System;
using System.Collections.Generic;

namespace Mission08_Roney.Models;

public partial class SeriesPost
{
    public int? YearId { get; set; }

    public string? Round { get; set; }

    public string? TeamIdwinner { get; set; }

    public string? LgIdwinner { get; set; }

    public string? TeamIdloser { get; set; }

    public string? LgIdloser { get; set; }

    public int? Wins { get; set; }

    public int? Losses { get; set; }

    public int? Ties { get; set; }
}
