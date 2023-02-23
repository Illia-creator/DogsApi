namespace DogsApi.Entities.EntityAbstracts
{
    public class Color
    {
        public string value;
        public Color(string value)
        {
            if (value == string.Empty) throw new Exception("Color Cannot Be Empty");
            else this.value = value;
        }
    }
}
