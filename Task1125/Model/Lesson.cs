//Это модель данных, тут ничего менять не нужно

using System.ComponentModel.DataAnnotations.Schema;

namespace Task1125.Model
{
    public class Lesson
    {
        public string Name { get; set; }
        public string Content { get; set; }

        [NotMapped]
        public bool IsLection { get; set; }
        public string Type { get => IsLection ? "лекция" : "практика"; }
    }
}
