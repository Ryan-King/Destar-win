﻿using System;
using System.Collections.Generic;

namespace TagProLeague.Models
{
    public class Season : Document
    {
        public string Abbreviation { get; set; }
        public DateTime? StartedOn { get; set; }
        public DateTime? EndedOn { get; set; }
        public string League { get; set; }
        public List<string> Administrators { get; set; }
        public SeasonFormat SeasonFormat { get; set; }
        public List<TeamGroup> TeamGroups { get; set; }
        public List<SeriesGroup> SeriesGroups { get; set; }
        public List<string> Players { get; set; }
        public List<string> Awards { get; set; }
        public List<string> Games { get; set; }
        public string TotalStatline { get; set; }
    }

    public class SeasonFormat
    {
        public string Type { get; set; }
        public string RulesUrl { get; set; }
        public int TeamCount { get; set; }
        public string TeamGroupIdentifier { get; set; }
    }

    public class TeamGroup
    {
        public string Name { get; set; }
        public List<string> Teams { get; set; }
    }

    public class SeriesGroup
    {
        public string Name { get; set; }
        public List<string> Series { get; set; }
    }
}
