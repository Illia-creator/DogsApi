﻿using DogsApi.Entities.ValueObjects;
using System.Xml.Linq;

namespace DogsApi.Entities
{
    public class DogEntity
    {
        public int Id { get; set; }
        public Name Name { get; set; }
        public Color Color { get; set; }
        public TailLenth TailLenth { get; set; }
        public Weight Weight { get; set; }
        public DogEntity()
        {

        }
    }
}
