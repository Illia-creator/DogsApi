namespace DogsApi.Entities.Dto
{
    public class UpdateDogDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public double TailLength { get; set; }
        public double Weight { get; set; }
    }
}
