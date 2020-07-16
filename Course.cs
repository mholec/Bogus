namespace BogusApp
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public override string ToString()
        {
            return $"{Id} {Title}";
        }
    }
}