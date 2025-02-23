using System;
using System.Collections.Generic;

namespace Mission08_Roney.Models;

public partial class HallOfFame
{
    public string? PlayerId { get; set; }

    public int? Yearid { get; set; }

    public string? VotedBy { get; set; }

    public int? Ballots { get; set; }

    public int? Needed { get; set; }

    public int? Votes { get; set; }

    public string? Inducted { get; set; }

    public string? Category { get; set; }

    public string? NeededNote { get; set; }
}
