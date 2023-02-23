namespace DogsApi.Entities.EntityAbstracts
{
    public class Color
    {
        public string Value { get; set; }
        public Color(string value)
        {
            if (value == string.Empty) throw new Exception("Color Cannot Be Empty");
            else Value = value;
        }
    }
}
