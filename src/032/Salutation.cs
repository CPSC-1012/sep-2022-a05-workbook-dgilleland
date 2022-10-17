namespace Demo
{
    public class Salutation
    {
        // These are Properties - they represent information stored in
        // a Salutation object
        public string Greeting { get; set; }
        public string Farewell { get; set; }

        // These are Methods - they represent things that can be done with a
        // Salutation object
        public string SayHello()
        {
            return Greeting;
        }

        public string SayGoodbye()
        {
            return Farewell;
        }
    }
}