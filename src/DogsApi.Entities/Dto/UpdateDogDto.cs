using DogsApi.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogsApi.Entities.Dto
{
    public class UpdateDogDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public double TailLenth { get; set; }
        public double Weight { get; set; }
    }
}
