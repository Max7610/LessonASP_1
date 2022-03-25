namespace LessonASP_1.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public TypeGenre TGenre { get; set; }

        public string NameIMG { get; set; } 
        public string Description { get; set; }

        public int Prise { get; set; }

    }
}
