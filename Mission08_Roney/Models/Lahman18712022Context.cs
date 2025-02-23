using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Mission08_Roney.Models;

public partial class Lahman18712022Context : DbContext
{
    public Lahman18712022Context()
    {
    }

    public Lahman18712022Context(DbContextOptions<Lahman18712022Context> options)
        : base(options)
    {
    }

    public virtual DbSet<AllstarFull> AllstarFulls { get; set; }

    public virtual DbSet<Appearance> Appearances { get; set; }

    public virtual DbSet<AwardsManager> AwardsManagers { get; set; }

    public virtual DbSet<AwardsPlayer> AwardsPlayers { get; set; }

    public virtual DbSet<AwardsShareManager> AwardsShareManagers { get; set; }

    public virtual DbSet<AwardsSharePlayer> AwardsSharePlayers { get; set; }

    public virtual DbSet<Batting> Battings { get; set; }

    public virtual DbSet<BattingPost> BattingPosts { get; set; }

    public virtual DbSet<CollegePlaying> CollegePlayings { get; set; }

    public virtual DbSet<Fielding> Fieldings { get; set; }

    public virtual DbSet<FieldingOf> FieldingOfs { get; set; }

    public virtual DbSet<FieldingOfsplit> FieldingOfsplits { get; set; }

    public virtual DbSet<FieldingPost> FieldingPosts { get; set; }

    public virtual DbSet<HallOfFame> HallOfFames { get; set; }

    public virtual DbSet<HomeGame> HomeGames { get; set; }

    public virtual DbSet<Manager> Managers { get; set; }

    public virtual DbSet<ManagersHalf> ManagersHalves { get; set; }

    public virtual DbSet<Park> Parks { get; set; }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<Pitching> Pitchings { get; set; }

    public virtual DbSet<PitchingPost> PitchingPosts { get; set; }

    public virtual DbSet<Salary> Salaries { get; set; }

    public virtual DbSet<School> Schools { get; set; }

    public virtual DbSet<SeriesPost> SeriesPosts { get; set; }

    public virtual DbSet<Team> Teams { get; set; }

    public virtual DbSet<TeamsFranchise> TeamsFranchises { get; set; }

    public virtual DbSet<TeamsHalf> TeamsHalves { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=lahman_1871-2022.sqlite");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AllstarFull>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AllstarFull");

            entity.HasIndex(e => e.GameId, "AllstarFull_gameID");

            entity.HasIndex(e => e.GameNum, "AllstarFull_gameNum");

            entity.HasIndex(e => e.LgId, "AllstarFull_lgID");

            entity.HasIndex(e => e.PlayerId, "AllstarFull_playerID");

            entity.HasIndex(e => e.TeamId, "AllstarFull_teamID");

            entity.HasIndex(e => e.YearId, "AllstarFull_yearID");

            entity.Property(e => e.GameId).HasColumnName("gameID");
            entity.Property(e => e.GameNum).HasColumnName("gameNum");
            entity.Property(e => e.Gp).HasColumnName("GP");
            entity.Property(e => e.LgId).HasColumnName("lgID");
            entity.Property(e => e.PlayerId).HasColumnName("playerID");
            entity.Property(e => e.StartingPos).HasColumnName("startingPos");
            entity.Property(e => e.TeamId).HasColumnName("teamID");
            entity.Property(e => e.YearId).HasColumnName("yearID");
        });

        modelBuilder.Entity<Appearance>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.PlayerId, "Appearances_AppearancesplayerID");

            entity.HasIndex(e => new { e.YearId, e.TeamId, e.PlayerId }, "Appearances_Index_70924BF9_C76C_4076").IsUnique();

            entity.HasIndex(e => e.LgId, "Appearances_lgID");

            entity.Property(e => e.G1b).HasColumnName("G_1b");
            entity.Property(e => e.G2b).HasColumnName("G_2b");
            entity.Property(e => e.G3b).HasColumnName("G_3b");
            entity.Property(e => e.GAll).HasColumnName("G_all");
            entity.Property(e => e.GBatting).HasColumnName("G_batting");
            entity.Property(e => e.GC).HasColumnName("G_c");
            entity.Property(e => e.GCf).HasColumnName("G_cf");
            entity.Property(e => e.GDefense).HasColumnName("G_defense");
            entity.Property(e => e.GDh).HasColumnName("G_dh");
            entity.Property(e => e.GLf).HasColumnName("G_lf");
            entity.Property(e => e.GOf).HasColumnName("G_of");
            entity.Property(e => e.GP).HasColumnName("G_p");
            entity.Property(e => e.GPh).HasColumnName("G_ph");
            entity.Property(e => e.GPr).HasColumnName("G_pr");
            entity.Property(e => e.GRf).HasColumnName("G_rf");
            entity.Property(e => e.GSs).HasColumnName("G_ss");
            entity.Property(e => e.Gs).HasColumnName("GS");
            entity.Property(e => e.LgId).HasColumnName("lgID");
            entity.Property(e => e.PlayerId).HasColumnName("playerID");
            entity.Property(e => e.TeamId).HasColumnName("teamID");
            entity.Property(e => e.YearId).HasColumnName("yearID");
        });

        modelBuilder.Entity<AwardsManager>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.PlayerId, "AwardsManagers_AwardsManagersplayerID");

            entity.HasIndex(e => new { e.YearId, e.AwardId, e.LgId, e.PlayerId }, "AwardsManagers_Index_5B79AD08_A7C1_426E").IsUnique();

            entity.Property(e => e.AwardId).HasColumnName("awardID");
            entity.Property(e => e.LgId).HasColumnName("lgID");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.PlayerId).HasColumnName("playerID");
            entity.Property(e => e.Tie).HasColumnName("tie");
            entity.Property(e => e.YearId).HasColumnName("yearID");
        });

        modelBuilder.Entity<AwardsPlayer>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.PlayerId, "AwardsPlayers_AwardsPlayersplayerID");

            entity.Property(e => e.AwardId).HasColumnName("awardID");
            entity.Property(e => e.LgId).HasColumnName("lgID");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.PlayerId).HasColumnName("playerID");
            entity.Property(e => e.Tie).HasColumnName("tie");
            entity.Property(e => e.YearId).HasColumnName("yearID");
        });

        modelBuilder.Entity<AwardsShareManager>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.PlayerId, "AwardsShareManagers_AwardsShareManagersplayerID");

            entity.HasIndex(e => new { e.AwardId, e.YearId, e.LgId, e.PlayerId }, "AwardsShareManagers_Index_4D947987_0BEF_4B9B").IsUnique();

            entity.Property(e => e.AwardId).HasColumnName("awardID");
            entity.Property(e => e.LgId).HasColumnName("lgID");
            entity.Property(e => e.PlayerId).HasColumnName("playerID");
            entity.Property(e => e.PointsMax).HasColumnName("pointsMax");
            entity.Property(e => e.PointsWon).HasColumnName("pointsWon");
            entity.Property(e => e.VotesFirst).HasColumnName("votesFirst");
            entity.Property(e => e.YearId).HasColumnName("yearID");
        });

        modelBuilder.Entity<AwardsSharePlayer>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.PlayerId, "AwardsSharePlayers_AwardsSharePlayersplayerID");

            entity.HasIndex(e => new { e.AwardId, e.YearId, e.LgId, e.PlayerId }, "AwardsSharePlayers_Index_020E6DB1_95E2_44F1").IsUnique();

            entity.Property(e => e.AwardId).HasColumnName("awardID");
            entity.Property(e => e.LgId).HasColumnName("lgID");
            entity.Property(e => e.PlayerId).HasColumnName("playerID");
            entity.Property(e => e.PointsMax).HasColumnName("pointsMax");
            entity.Property(e => e.PointsWon).HasColumnName("pointsWon");
            entity.Property(e => e.VotesFirst).HasColumnName("votesFirst");
            entity.Property(e => e.YearId).HasColumnName("yearID");
        });

        modelBuilder.Entity<Batting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Batting");

            entity.HasIndex(e => e.PlayerId, "Batting_BattingplayerID");

            entity.HasIndex(e => new { e.PlayerId, e.YearId, e.Stint }, "Batting_Index_7170BE9D_268A_46B8").IsUnique();

            entity.HasIndex(e => e.LgId, "Batting_lgID");

            entity.HasIndex(e => e.TeamId, "Batting_teamID");

            entity.Property(e => e.Ab).HasColumnName("AB");
            entity.Property(e => e.Bb).HasColumnName("BB");
            entity.Property(e => e.Cs).HasColumnName("CS");
            entity.Property(e => e.GBatting).HasColumnName("G_batting");
            entity.Property(e => e.GOld).HasColumnName("G_old");
            entity.Property(e => e.Gidp).HasColumnName("GIDP");
            entity.Property(e => e.Hbp).HasColumnName("HBP");
            entity.Property(e => e.Hr).HasColumnName("HR");
            entity.Property(e => e.Ibb).HasColumnName("IBB");
            entity.Property(e => e.LgId).HasColumnName("lgID");
            entity.Property(e => e.PlayerId).HasColumnName("playerID");
            entity.Property(e => e.Rbi).HasColumnName("RBI");
            entity.Property(e => e.Sb).HasColumnName("SB");
            entity.Property(e => e.Sf).HasColumnName("SF");
            entity.Property(e => e.Sh).HasColumnName("SH");
            entity.Property(e => e.So).HasColumnName("SO");
            entity.Property(e => e.Stint).HasColumnName("stint");
            entity.Property(e => e.TeamId).HasColumnName("teamID");
            entity.Property(e => e.YearId).HasColumnName("yearID");
            entity.Property(e => e._2b).HasColumnName("2B");
            entity.Property(e => e._3b).HasColumnName("3B");
        });

        modelBuilder.Entity<BattingPost>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BattingPost");

            entity.HasIndex(e => e.PlayerId, "BattingPost_BattingPostplayerID");

            entity.HasIndex(e => new { e.YearId, e.Round, e.PlayerId }, "BattingPost_Index_8C81D106_6E96_4318").IsUnique();

            entity.HasIndex(e => e.LgId, "BattingPost_lgID");

            entity.HasIndex(e => e.TeamId, "BattingPost_teamID");

            entity.Property(e => e.Ab).HasColumnName("AB");
            entity.Property(e => e.Bb).HasColumnName("BB");
            entity.Property(e => e.Cs).HasColumnName("CS");
            entity.Property(e => e.Gidp).HasColumnName("GIDP");
            entity.Property(e => e.Hbp).HasColumnName("HBP");
            entity.Property(e => e.Hr).HasColumnName("HR");
            entity.Property(e => e.Ibb).HasColumnName("IBB");
            entity.Property(e => e.LgId).HasColumnName("lgID");
            entity.Property(e => e.PlayerId).HasColumnName("playerID");
            entity.Property(e => e.Rbi).HasColumnName("RBI");
            entity.Property(e => e.Round).HasColumnName("round");
            entity.Property(e => e.Sb).HasColumnName("SB");
            entity.Property(e => e.Sf).HasColumnName("SF");
            entity.Property(e => e.Sh).HasColumnName("SH");
            entity.Property(e => e.So).HasColumnName("SO");
            entity.Property(e => e.TeamId).HasColumnName("teamID");
            entity.Property(e => e.YearId).HasColumnName("yearID");
            entity.Property(e => e._2b).HasColumnName("2B");
            entity.Property(e => e._3b).HasColumnName("3B");
        });

        modelBuilder.Entity<CollegePlaying>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CollegePlaying");

            entity.HasIndex(e => e.PlayerId, "CollegePlaying_CollegePlayingplayerID");

            entity.HasIndex(e => e.SchoolId, "CollegePlaying_CollegePlayingschoolID");

            entity.Property(e => e.PlayerId).HasColumnName("playerID");
            entity.Property(e => e.SchoolId).HasColumnName("schoolID");
            entity.Property(e => e.YearId).HasColumnName("yearID");
        });

        modelBuilder.Entity<Fielding>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Fielding");

            entity.HasIndex(e => e.PlayerId, "Fielding_FieldingplayerID");

            entity.HasIndex(e => new { e.PlayerId, e.YearId, e.Stint, e.Pos }, "Fielding_Index_97751AED_0076_4367").IsUnique();

            entity.HasIndex(e => e.LgId, "Fielding_lgID");

            entity.HasIndex(e => e.TeamId, "Fielding_teamID");

            entity.Property(e => e.Cs).HasColumnName("CS");
            entity.Property(e => e.Dp).HasColumnName("DP");
            entity.Property(e => e.Gs).HasColumnName("GS");
            entity.Property(e => e.LgId).HasColumnName("lgID");
            entity.Property(e => e.Pb).HasColumnName("PB");
            entity.Property(e => e.PlayerId).HasColumnName("playerID");
            entity.Property(e => e.Po).HasColumnName("PO");
            entity.Property(e => e.Pos).HasColumnName("POS");
            entity.Property(e => e.Sb).HasColumnName("SB");
            entity.Property(e => e.Stint).HasColumnName("stint");
            entity.Property(e => e.TeamId).HasColumnName("teamID");
            entity.Property(e => e.Wp).HasColumnName("WP");
            entity.Property(e => e.YearId).HasColumnName("yearID");
            entity.Property(e => e.Zr).HasColumnName("ZR");
        });

        modelBuilder.Entity<FieldingOf>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FieldingOF");

            entity.HasIndex(e => e.PlayerId, "FieldingOF_FieldingOFplayerID");

            entity.HasIndex(e => new { e.PlayerId, e.YearId, e.Stint }, "FieldingOF_Index_8983CB74_6371_424E").IsUnique();

            entity.Property(e => e.PlayerId).HasColumnName("playerID");
            entity.Property(e => e.Stint).HasColumnName("stint");
            entity.Property(e => e.YearId).HasColumnName("yearID");
        });

        modelBuilder.Entity<FieldingOfsplit>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FieldingOFsplit");

            entity.HasIndex(e => e.PlayerId, "FieldingOFsplit_FieldingOFsplitplayerID");

            entity.HasIndex(e => new { e.PlayerId, e.YearId, e.Stint, e.Pos }, "FieldingOFsplit_Index_97751AED_0076_4367").IsUnique();

            entity.HasIndex(e => e.LgId, "FieldingOFsplit_lgID");

            entity.HasIndex(e => e.TeamId, "FieldingOFsplit_teamID");

            entity.Property(e => e.Cs).HasColumnName("CS");
            entity.Property(e => e.Dp).HasColumnName("DP");
            entity.Property(e => e.Gs).HasColumnName("GS");
            entity.Property(e => e.LgId).HasColumnName("lgID");
            entity.Property(e => e.Pb).HasColumnName("PB");
            entity.Property(e => e.PlayerId).HasColumnName("playerID");
            entity.Property(e => e.Po).HasColumnName("PO");
            entity.Property(e => e.Pos).HasColumnName("POS");
            entity.Property(e => e.Sb).HasColumnName("SB");
            entity.Property(e => e.Stint).HasColumnName("stint");
            entity.Property(e => e.TeamId).HasColumnName("teamID");
            entity.Property(e => e.Wp).HasColumnName("WP");
            entity.Property(e => e.YearId).HasColumnName("yearID");
            entity.Property(e => e.Zr).HasColumnName("ZR");
        });

        modelBuilder.Entity<FieldingPost>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FieldingPost");

            entity.HasIndex(e => e.PlayerId, "FieldingPost_FieldingPostplayerID");

            entity.HasIndex(e => new { e.PlayerId, e.YearId, e.Round, e.Pos }, "FieldingPost_Index_E1DA201A_3B38_486D").IsUnique();

            entity.HasIndex(e => e.LgId, "FieldingPost_lgID");

            entity.HasIndex(e => e.TeamId, "FieldingPost_teamID");

            entity.Property(e => e.Cs).HasColumnName("CS");
            entity.Property(e => e.Dp).HasColumnName("DP");
            entity.Property(e => e.Gs).HasColumnName("GS");
            entity.Property(e => e.LgId).HasColumnName("lgID");
            entity.Property(e => e.Pb).HasColumnName("PB");
            entity.Property(e => e.PlayerId).HasColumnName("playerID");
            entity.Property(e => e.Po).HasColumnName("PO");
            entity.Property(e => e.Pos).HasColumnName("POS");
            entity.Property(e => e.Round).HasColumnName("round");
            entity.Property(e => e.Sb).HasColumnName("SB");
            entity.Property(e => e.TeamId).HasColumnName("teamID");
            entity.Property(e => e.Tp).HasColumnName("TP");
            entity.Property(e => e.YearId).HasColumnName("yearID");
        });

        modelBuilder.Entity<HallOfFame>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HallOfFame");

            entity.HasIndex(e => e.PlayerId, "HallOfFame_HallOfFameplayerID");

            entity.HasIndex(e => new { e.PlayerId, e.Yearid, e.VotedBy }, "HallOfFame_PrimaryKey").IsUnique();

            entity.Property(e => e.Ballots).HasColumnName("ballots");
            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.Inducted).HasColumnName("inducted");
            entity.Property(e => e.Needed).HasColumnName("needed");
            entity.Property(e => e.NeededNote).HasColumnName("needed_note");
            entity.Property(e => e.PlayerId).HasColumnName("playerID");
            entity.Property(e => e.VotedBy).HasColumnName("votedBy");
            entity.Property(e => e.Votes).HasColumnName("votes");
            entity.Property(e => e.Yearid).HasColumnName("yearid");
        });

        modelBuilder.Entity<HomeGame>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.Leaguekey, "HomeGames_leaguekey");

            entity.HasIndex(e => e.Parkkey, "HomeGames_parkkey");

            entity.HasIndex(e => e.Teamkey, "HomeGames_teamkey");

            entity.HasIndex(e => e.Yearkey, "HomeGames_yearkey");

            entity.Property(e => e.Attendance).HasColumnName("attendance");
            entity.Property(e => e.Games).HasColumnName("games");
            entity.Property(e => e.Leaguekey).HasColumnName("leaguekey");
            entity.Property(e => e.Openings).HasColumnName("openings");
            entity.Property(e => e.Parkkey).HasColumnName("parkkey");
            entity.Property(e => e.Spanfirst).HasColumnName("spanfirst");
            entity.Property(e => e.Spanlast).HasColumnName("spanlast");
            entity.Property(e => e.Teamkey).HasColumnName("teamkey");
            entity.Property(e => e.Yearkey).HasColumnName("yearkey");
        });

        modelBuilder.Entity<Manager>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.YearId, e.TeamId, e.Inseason }, "Managers_Index_836DE8E8_FEBD_469A").IsUnique();

            entity.HasIndex(e => e.LgId, "Managers_lgID");

            entity.HasIndex(e => e.PlayerId, "Managers_managerID");

            entity.Property(e => e.Inseason).HasColumnName("inseason");
            entity.Property(e => e.LgId).HasColumnName("lgID");
            entity.Property(e => e.PlayerId).HasColumnName("playerID");
            entity.Property(e => e.PlyrMgr).HasColumnName("plyrMgr");
            entity.Property(e => e.Rank).HasColumnName("rank");
            entity.Property(e => e.TeamId).HasColumnName("teamID");
            entity.Property(e => e.YearId).HasColumnName("yearID");
        });

        modelBuilder.Entity<ManagersHalf>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ManagersHalf");

            entity.HasIndex(e => new { e.YearId, e.TeamId, e.PlayerId, e.Half }, "ManagersHalf_Index_C2906EEF_9F52_4968").IsUnique();

            entity.HasIndex(e => e.PlayerId, "ManagersHalf_ManagersHalfplayerID");

            entity.HasIndex(e => e.LgId, "ManagersHalf_lgID");

            entity.Property(e => e.Half).HasColumnName("half");
            entity.Property(e => e.Inseason).HasColumnName("inseason");
            entity.Property(e => e.LgId).HasColumnName("lgID");
            entity.Property(e => e.PlayerId).HasColumnName("playerID");
            entity.Property(e => e.Rank).HasColumnName("rank");
            entity.Property(e => e.TeamId).HasColumnName("teamID");
            entity.Property(e => e.YearId).HasColumnName("yearID");
        });

        modelBuilder.Entity<Park>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.Id, "Parks_ID").IsUnique();

            entity.HasIndex(e => e.Parkkey, "Parks_parkkey");

            entity.Property(e => e.City).HasColumnName("city");
            entity.Property(e => e.Country).HasColumnName("country");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Parkalias).HasColumnName("parkalias");
            entity.Property(e => e.Parkkey).HasColumnName("parkkey");
            entity.Property(e => e.Parkname).HasColumnName("parkname");
            entity.Property(e => e.State).HasColumnName("state");
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.Id, "People_ID").IsUnique();

            entity.HasIndex(e => e.BbrefId, "People_bbrefID");

            entity.HasIndex(e => e.PlayerId, "People_playerID");

            entity.HasIndex(e => e.RetroId, "People_retroID");

            entity.Property(e => e.Bats).HasColumnName("bats");
            entity.Property(e => e.BbrefId).HasColumnName("bbrefID");
            entity.Property(e => e.BirthCity).HasColumnName("birthCity");
            entity.Property(e => e.BirthCountry).HasColumnName("birthCountry");
            entity.Property(e => e.BirthDay).HasColumnName("birthDay");
            entity.Property(e => e.BirthMonth).HasColumnName("birthMonth");
            entity.Property(e => e.BirthState).HasColumnName("birthState");
            entity.Property(e => e.BirthYear).HasColumnName("birthYear");
            entity.Property(e => e.DeathCity).HasColumnName("deathCity");
            entity.Property(e => e.DeathCountry).HasColumnName("deathCountry");
            entity.Property(e => e.DeathDay).HasColumnName("deathDay");
            entity.Property(e => e.DeathMonth).HasColumnName("deathMonth");
            entity.Property(e => e.DeathState).HasColumnName("deathState");
            entity.Property(e => e.DeathYear).HasColumnName("deathYear");
            entity.Property(e => e.Debut).HasColumnName("debut");
            entity.Property(e => e.FinalGame).HasColumnName("finalGame");
            entity.Property(e => e.Height).HasColumnName("height");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.NameFirst).HasColumnName("nameFirst");
            entity.Property(e => e.NameGiven).HasColumnName("nameGiven");
            entity.Property(e => e.NameLast).HasColumnName("nameLast");
            entity.Property(e => e.PlayerId).HasColumnName("playerID");
            entity.Property(e => e.RetroId).HasColumnName("retroID");
            entity.Property(e => e.Throws).HasColumnName("throws");
            entity.Property(e => e.Weight).HasColumnName("weight");
        });

        modelBuilder.Entity<Pitching>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Pitching");

            entity.HasIndex(e => new { e.PlayerId, e.YearId, e.Stint }, "Pitching_Index_481778A5_18F2_430E").IsUnique();

            entity.HasIndex(e => e.PlayerId, "Pitching_PitchingplayerID");

            entity.HasIndex(e => e.LgId, "Pitching_lgID");

            entity.HasIndex(e => e.TeamId, "Pitching_teamID");

            entity.Property(e => e.Baopp).HasColumnName("BAOpp");
            entity.Property(e => e.Bb).HasColumnName("BB");
            entity.Property(e => e.Bfp).HasColumnName("BFP");
            entity.Property(e => e.Bk).HasColumnName("BK");
            entity.Property(e => e.Cg).HasColumnName("CG");
            entity.Property(e => e.Er).HasColumnName("ER");
            entity.Property(e => e.Era).HasColumnName("ERA");
            entity.Property(e => e.Gf).HasColumnName("GF");
            entity.Property(e => e.Gidp).HasColumnName("GIDP");
            entity.Property(e => e.Gs).HasColumnName("GS");
            entity.Property(e => e.Hbp).HasColumnName("HBP");
            entity.Property(e => e.Hr).HasColumnName("HR");
            entity.Property(e => e.Ibb).HasColumnName("IBB");
            entity.Property(e => e.Ipouts).HasColumnName("IPouts");
            entity.Property(e => e.LgId).HasColumnName("lgID");
            entity.Property(e => e.PlayerId).HasColumnName("playerID");
            entity.Property(e => e.Sf).HasColumnName("SF");
            entity.Property(e => e.Sh).HasColumnName("SH");
            entity.Property(e => e.Sho).HasColumnName("SHO");
            entity.Property(e => e.So).HasColumnName("SO");
            entity.Property(e => e.Stint).HasColumnName("stint");
            entity.Property(e => e.Sv).HasColumnName("SV");
            entity.Property(e => e.TeamId).HasColumnName("teamID");
            entity.Property(e => e.Wp).HasColumnName("WP");
            entity.Property(e => e.YearId).HasColumnName("yearID");
        });

        modelBuilder.Entity<PitchingPost>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PitchingPost");

            entity.HasIndex(e => new { e.PlayerId, e.YearId, e.Round }, "PitchingPost_Index_E71336E6_AB00_432C").IsUnique();

            entity.HasIndex(e => e.PlayerId, "PitchingPost_PitchingPostplayerID");

            entity.HasIndex(e => e.LgId, "PitchingPost_lgID");

            entity.HasIndex(e => e.TeamId, "PitchingPost_teamID");

            entity.Property(e => e.Baopp).HasColumnName("BAOpp");
            entity.Property(e => e.Bb).HasColumnName("BB");
            entity.Property(e => e.Bfp).HasColumnName("BFP");
            entity.Property(e => e.Bk).HasColumnName("BK");
            entity.Property(e => e.Cg).HasColumnName("CG");
            entity.Property(e => e.Er).HasColumnName("ER");
            entity.Property(e => e.Era).HasColumnName("ERA");
            entity.Property(e => e.Gf).HasColumnName("GF");
            entity.Property(e => e.Gidp).HasColumnName("GIDP");
            entity.Property(e => e.Gs).HasColumnName("GS");
            entity.Property(e => e.Hbp).HasColumnName("HBP");
            entity.Property(e => e.Hr).HasColumnName("HR");
            entity.Property(e => e.Ibb).HasColumnName("IBB");
            entity.Property(e => e.Ipouts).HasColumnName("IPouts");
            entity.Property(e => e.LgId).HasColumnName("lgID");
            entity.Property(e => e.PlayerId).HasColumnName("playerID");
            entity.Property(e => e.Round).HasColumnName("round");
            entity.Property(e => e.Sf).HasColumnName("SF");
            entity.Property(e => e.Sh).HasColumnName("SH");
            entity.Property(e => e.Sho).HasColumnName("SHO");
            entity.Property(e => e.So).HasColumnName("SO");
            entity.Property(e => e.Sv).HasColumnName("SV");
            entity.Property(e => e.TeamId).HasColumnName("teamID");
            entity.Property(e => e.Wp).HasColumnName("WP");
            entity.Property(e => e.YearId).HasColumnName("yearID");
        });

        modelBuilder.Entity<Salary>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.YearId, e.TeamId, e.LgId, e.PlayerId }, "Salaries_Index_E5568031_00FA_49CA").IsUnique();

            entity.HasIndex(e => e.PlayerId, "Salaries_SalariesplayerID");

            entity.Property(e => e.LgId).HasColumnName("lgID");
            entity.Property(e => e.PlayerId).HasColumnName("playerID");
            entity.Property(e => e.Salary1).HasColumnName("salary");
            entity.Property(e => e.TeamId).HasColumnName("teamID");
            entity.Property(e => e.YearId).HasColumnName("yearID");
        });

        modelBuilder.Entity<School>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.SchoolId, "Schools_Index_3D308CF0_821E_4DAB").IsUnique();

            entity.Property(e => e.City).HasColumnName("city");
            entity.Property(e => e.Country).HasColumnName("country");
            entity.Property(e => e.NameFull).HasColumnName("name_full");
            entity.Property(e => e.SchoolId).HasColumnName("schoolID");
            entity.Property(e => e.State).HasColumnName("state");
        });

        modelBuilder.Entity<SeriesPost>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SeriesPost");

            entity.HasIndex(e => new { e.YearId, e.Round }, "SeriesPost_Index_4F4214D5_9891_4F3C").IsUnique();

            entity.Property(e => e.LgIdloser).HasColumnName("lgIDloser");
            entity.Property(e => e.LgIdwinner).HasColumnName("lgIDwinner");
            entity.Property(e => e.Losses).HasColumnName("losses");
            entity.Property(e => e.Round).HasColumnName("round");
            entity.Property(e => e.TeamIdloser).HasColumnName("teamIDloser");
            entity.Property(e => e.TeamIdwinner).HasColumnName("teamIDwinner");
            entity.Property(e => e.Ties).HasColumnName("ties");
            entity.Property(e => e.Wins).HasColumnName("wins");
            entity.Property(e => e.YearId).HasColumnName("yearID");
        });

        modelBuilder.Entity<Team>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.YearId, e.LgId, e.TeamId }, "Teams_Index_285058F1_D841_4142").IsUnique();

            entity.HasIndex(e => e.TeamId, "Teams_TeamsteamID");

            entity.HasIndex(e => e.DivId, "Teams_divID");

            entity.HasIndex(e => e.FranchId, "Teams_franchID");

            entity.Property(e => e.Ab).HasColumnName("AB");
            entity.Property(e => e.Attendance).HasColumnName("attendance");
            entity.Property(e => e.Bb).HasColumnName("BB");
            entity.Property(e => e.Bba).HasColumnName("BBA");
            entity.Property(e => e.Bpf).HasColumnName("BPF");
            entity.Property(e => e.Cg).HasColumnName("CG");
            entity.Property(e => e.Cs).HasColumnName("CS");
            entity.Property(e => e.DivId).HasColumnName("divID");
            entity.Property(e => e.Dp).HasColumnName("DP");
            entity.Property(e => e.Er).HasColumnName("ER");
            entity.Property(e => e.Era).HasColumnName("ERA");
            entity.Property(e => e.Fp).HasColumnName("FP");
            entity.Property(e => e.FranchId).HasColumnName("franchID");
            entity.Property(e => e.Ha).HasColumnName("HA");
            entity.Property(e => e.Hbp).HasColumnName("HBP");
            entity.Property(e => e.Hr).HasColumnName("HR");
            entity.Property(e => e.Hra).HasColumnName("HRA");
            entity.Property(e => e.Ipouts).HasColumnName("IPouts");
            entity.Property(e => e.LgId).HasColumnName("lgID");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Park).HasColumnName("park");
            entity.Property(e => e.Ppf).HasColumnName("PPF");
            entity.Property(e => e.Ra).HasColumnName("RA");
            entity.Property(e => e.Sb).HasColumnName("SB");
            entity.Property(e => e.Sf).HasColumnName("SF");
            entity.Property(e => e.Sho).HasColumnName("SHO");
            entity.Property(e => e.So).HasColumnName("SO");
            entity.Property(e => e.Soa).HasColumnName("SOA");
            entity.Property(e => e.Sv).HasColumnName("SV");
            entity.Property(e => e.TeamId).HasColumnName("teamID");
            entity.Property(e => e.TeamIdbr).HasColumnName("teamIDBR");
            entity.Property(e => e.TeamIdlahman45).HasColumnName("teamIDlahman45");
            entity.Property(e => e.TeamIdretro).HasColumnName("teamIDretro");
            entity.Property(e => e.Wcwin).HasColumnName("WCWin");
            entity.Property(e => e.Wswin).HasColumnName("WSWin");
            entity.Property(e => e.YearId).HasColumnName("yearID");
            entity.Property(e => e._2b).HasColumnName("2B");
            entity.Property(e => e._3b).HasColumnName("3B");
        });

        modelBuilder.Entity<TeamsFranchise>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.FranchId, "TeamsFranchises_Index_D181F923_2BF9_4281").IsUnique();

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.FranchId).HasColumnName("franchID");
            entity.Property(e => e.FranchName).HasColumnName("franchName");
            entity.Property(e => e.Naassoc).HasColumnName("NAassoc");
        });

        modelBuilder.Entity<TeamsHalf>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TeamsHalf");

            entity.HasIndex(e => new { e.YearId, e.TeamId, e.LgId, e.Half }, "TeamsHalf_Index_3FD773F5_2FC0_415C").IsUnique();

            entity.HasIndex(e => e.TeamId, "TeamsHalf_TeamsHalfteamID");

            entity.HasIndex(e => e.DivId, "TeamsHalf_divID");

            entity.Property(e => e.DivId).HasColumnName("divID");
            entity.Property(e => e.LgId).HasColumnName("lgID");
            entity.Property(e => e.TeamId).HasColumnName("teamID");
            entity.Property(e => e.YearId).HasColumnName("yearID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
