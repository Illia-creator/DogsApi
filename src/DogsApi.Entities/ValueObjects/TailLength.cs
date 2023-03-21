namespace DogsApi.Entities.ValueObjects
{
    public class TailLength
    {
        public double Value { get; set; }
        public TailLength(double value)
        {
            if (value <= 0 ) throw new Exception("Tail Lenth Must Be Positive And Not Null");
            else Value = value;
        }
        public static implicit operator TailLength(double value) {  return new TailLength(value); }
    }
}
