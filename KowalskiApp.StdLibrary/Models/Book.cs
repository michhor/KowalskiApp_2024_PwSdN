namespace KowalskiApp.StdLibrary.Models
{
    public class Book
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public override string ToString()
        {
            return $"{Author}, { Title }";
        }
    }
}