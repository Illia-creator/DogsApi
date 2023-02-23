using DogsApi.Entities.EntityAbstracts;

namespace DogsApi.Entities
{
    public class DogEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public double TailLenth { get; set; }
        public double Weight { get; set; }
    }
}
