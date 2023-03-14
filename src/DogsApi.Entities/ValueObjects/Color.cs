namespace DogsApi.Entities.ValueObjects
{
    public class Color
    {
        public string Value { get; set; }
        public Color(string value)
        {
            if (value == string.Empty) throw new Exception("Color Cannot Be Empty");
            else Value = value;
        }
        public static implicit operator Color (string value) { return new Color(value); }
    }
}
