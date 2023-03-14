namespace DogsApi.Entities.ValueObjects
{
    public class Name
    {
        public string Value { get; set; }
        public Name(string value) 
        {
            if (value == string.Empty) throw new Exception("Name Cannot Be Empty");
            else Value = value;
        }

        public static implicit operator Name(string value) {  return new Name(value); }
    }
}
