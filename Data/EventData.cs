using CodingEvents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEvents.Data
{
    public class EventData
    {
        //store the events
        private static Dictionary<int, Event> Events = new Dictionary<int, Event>();

        //add an event
        public static void Add(Event newEvent)
        {
            Events.Add(newEvent.Id, newEvent);
        }

        //delete an event
        public static void Delete(int id)
        {
            Events.Remove(id);
        }
        
        //retrieve events
        public static IEnumerable<Event> GetAll()
        {
            return Events.Values;
        }

        //retrieve an event
        public static Event GetById(int id)
        {
            return Events.GetValueOrDefault(id);
        }

        public static void Update(int id, string name, string desc)
        {
            EventData.GetById(id).Name = name;
            EventData.GetById(id).Description = desc;
        }
    }
}
