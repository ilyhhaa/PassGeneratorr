namespace PassGenerator.Models
{
    public class PassModel
    {
        public string chars = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&";

        public int size { get; set; }

        public List<char> ResultCharsList { get; set; }
    }

}
