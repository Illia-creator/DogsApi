namespace DogsApi.Entities.ValueObjects
{
    public class TailLenth
    {
        public double Value { get; set; }
        public TailLenth(double value)
        {
            if (value <= 0 ) throw new Exception("Tail Lenth Must Be Positive And Not Null");
            else Value = value;
        }
    }
}
