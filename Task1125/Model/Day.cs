//это тоже модель, как и лекции
namespace Task1125.Model
{
    public class Day
    {
        public string Title {  get; set; }
        public string Group { get; set; }
        public List<Lesson> Lessons { get; set; }
    }
}
