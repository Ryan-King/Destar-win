﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace TagProLeague.Models
{
    public class Game
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset? Date { get; set; }
        public int Result { get; set; }
        public string EuUrl { get; set; }
        public string Series { get; set; }
        public string Map { get; set; }
        public string Format { get; set; }
        public string Season { get; set; }
        public List<string> Players { get; set; }
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public List<string> Statlines { get; set; }
        public string TotalStatline { get; set; }
    }
}
