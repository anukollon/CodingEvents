using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEvents.Models
{
    public class Event
    {
        public string Name { get; set; }
        //[FromForm(Name = "desc")]
        public string Description { get; set; }
        public int Id { get; }
        private static int nextId = 1;

        public Event()
        {
            Id = nextId;
            nextId++;
        }
        public Event(string name, string description):this()
        {
            Name = name;
            Description = description;
        }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
