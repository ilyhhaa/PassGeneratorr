namespace PassGenerator.Models
{
    public class PassModel
    {
        public string chars = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&";

        public int size = 6;

        //public List<char> ResultCharsList { get; set; }

        public string GeneratingPass { get; set; }
    }

}
