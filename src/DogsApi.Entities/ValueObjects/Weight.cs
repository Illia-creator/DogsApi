namespace DogsApi.Entities.EntityAbstracts
{
    public class Weight
    {
        public double Value { get; set; }
        public Weight(double value)
        {
            if (value <= 0) throw new Exception("Tail Lenth Must Be Positive And Not Null");
            else Value = value;
        }
    }
}
