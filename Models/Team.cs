﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace TagProLeague.Models
{
    public class Team
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset? EstablishedOn { get; set; }
        public DateTimeOffset? LastActiveOn { get; set; }
        public string LogoUrl { get; set; }
        public string Abbreviation { get; set; }
        public string Founder { get; set; }
        public List<string> Leagues { get; set; }
        public List<string> Players { get; set; }
        public List<string> Series { get; set; }
        public List<string> Maps { get; set; }
        public List<string> Awards { get; set; }
        public List<string> Games { get; set; }
        public string TotalStatline { get; set; }
    }
}
