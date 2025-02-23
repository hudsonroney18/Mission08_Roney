﻿using System;
using System.Collections.Generic;

namespace Mission08_Roney.Models;

public partial class Person
{
    public int? Id { get; set; }

    public string? PlayerId { get; set; }

    public int? BirthYear { get; set; }

    public int? BirthMonth { get; set; }

    public int? BirthDay { get; set; }

    public string? BirthCity { get; set; }

    public string? BirthCountry { get; set; }

    public string? BirthState { get; set; }

    public string? DeathYear { get; set; }

    public string? DeathMonth { get; set; }

    public string? DeathDay { get; set; }

    public string? DeathCountry { get; set; }

    public string? DeathState { get; set; }

    public string? DeathCity { get; set; }

    public string? NameFirst { get; set; }

    public string? NameLast { get; set; }

    public string? NameGiven { get; set; }

    public string? Weight { get; set; }

    public string? Height { get; set; }

    public string? Bats { get; set; }

    public string? Throws { get; set; }

    public DateOnly? Debut { get; set; }

    public string? BbrefId { get; set; }

    public DateOnly? FinalGame { get; set; }

    public string? RetroId { get; set; }
}
