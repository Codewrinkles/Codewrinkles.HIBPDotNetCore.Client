﻿namespace Codewrinkles.HIBP.Client.Responses
{
    internal class Paste
    {
        public string Source { get; set; }
        public string Id { get; set; }
        public string? Title { get; set; }
        public DateTime? PostedDate { get; set; }
        public int EmailCount { get; set; }
    }
}