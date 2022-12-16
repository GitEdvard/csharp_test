namespace edvard
{
    public class Person
    {
        public string? Name { get; set; }
        public string? Address { get; set; }

        public void Register(string? name, string? address) {
            Name = name;
            Address = address;
        }
    }
}
