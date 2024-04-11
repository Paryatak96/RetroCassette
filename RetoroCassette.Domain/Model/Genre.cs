﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoroCassette.Domain.Model
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection <Cassette> Cassettes { get; set; }
    }
}
