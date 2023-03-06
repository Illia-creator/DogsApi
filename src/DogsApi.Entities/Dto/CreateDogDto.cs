using DogsApi.Entities.ValueObjects;

namespace DogsApi.Entities.Dto
{
    public class CreateDogDto
    {
        public Name Name { get; set; }
        public Color Color { get; set; }
        public TailLenth TailLenth { get; set; }
        public Weight Weight { get; set; }
    }
}
