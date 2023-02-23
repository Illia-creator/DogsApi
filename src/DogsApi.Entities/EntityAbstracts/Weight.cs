namespace DogsApi.Entities.EntityAbstracts
{
    public class Weight
    {
        public double value;
        public Weight(double value)
        {
            if (value <= 0) throw new Exception("Tail Lenth Must Be Positive And Not Null");
            else this.value = value;
        }
    }
}
