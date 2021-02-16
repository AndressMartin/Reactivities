using System;

namespace Domain
{
    public class Activity
    {
        public Guid Id { get; set; } //The ID property is special, the entity framework recognizes that this is the primary key for this table in our database
        public string Title { get; set; } 
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string City { get; set; }
        public string Venue { get; set; }
    }

    
}