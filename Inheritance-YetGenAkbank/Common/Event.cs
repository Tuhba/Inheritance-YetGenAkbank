﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_YetGenAkbank.Common
{
    internal class Event
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime FinshTime { get; set; }
    }
    public Event()
    {
        Id = Guid.NewGuid();
    }
}
