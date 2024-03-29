﻿using DogsApi.Entities.ValueObjects;

namespace DogsApi.Entities.Dto
{
    public class CreateDogDto
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public double TailLength { get; set; }
        public double Weight { get; set; }
    }
}
