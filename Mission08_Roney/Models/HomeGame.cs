using System;
using System.Collections.Generic;

namespace Mission08_Roney.Models;

public partial class HomeGame
{
    public int? Yearkey { get; set; }

    public string? Leaguekey { get; set; }

    public string? Teamkey { get; set; }

    public string? Parkkey { get; set; }

    public DateOnly? Spanfirst { get; set; }

    public DateOnly? Spanlast { get; set; }

    public int? Games { get; set; }

    public int? Openings { get; set; }

    public int? Attendance { get; set; }
}
