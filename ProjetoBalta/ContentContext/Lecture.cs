using ProjetoBalta.ContentContext.Enums;

namespace ProjetoBalta.ContentContext{
     public class Lecture{
        public int Ordem { get; set; }
        public string Title { get; set; }
        public int DurationInMinutes { get; set; }
        public EcontentLevel Level { get; set; }
    }
}