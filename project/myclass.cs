namespace edvard
{
    public class Person
    {
        public string? Name { get; set; }
        public string? Address { get; set; }

        public double Register(string? name, string? address) {
            Name = name;
            Address = address;
            int a = 0;
            double b = 1.0/a;
            return b;
        }
    }
}
