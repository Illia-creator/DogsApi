using DogsApi.Entities.EntityAbstracts;
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
        public Name Name { get; set; }
        public Color Color { get; set; }
        public TailLenth TailLenth { get; set; }
        public Weight Weight { get; set; }
    }
}
