using DogsApi.Entities.ValueObjects;

namespace DogsApi.Entities
{
    public class DogEntity
    {
        public int Id { get; set; }
        public Name Name { get; set; }
        public Color Color { get; set; }
        public TailLength TailLength { get; set; }
        public Weight Weight { get; set; }
        public DogEntity()
        {

        }
    }
}
