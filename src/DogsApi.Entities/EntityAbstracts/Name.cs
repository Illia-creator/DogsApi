namespace DogsApi.Entities.EntityAbstracts
{
    public class Name
    {
        public string value;
        public Name(string value) 
        {
            if (value == string.Empty) throw new Exception("Name Cannot Be Empty");
            else this.value = value;
        }
    }
}
