using System;
using System.Collections.Generic;

namespace Mission08_Roney.Models;

public partial class AwardsShareManager
{
    public string? AwardId { get; set; }

    public int? YearId { get; set; }

    public string? LgId { get; set; }

    public string? PlayerId { get; set; }

    public int? PointsWon { get; set; }

    public int? PointsMax { get; set; }

    public int? VotesFirst { get; set; }
}
