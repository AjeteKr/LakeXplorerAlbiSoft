﻿namespace LakeXplorer.DTOs
{

    // Data Transfer Object for representing a lake sighting.
    public class LakeSightingDto
    {
        public int Id { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string Image { get; set; }
        public string FunFact { get; set; }
        public int UserId { get; set; }
        public int LakeId { get; set; }
    }
}