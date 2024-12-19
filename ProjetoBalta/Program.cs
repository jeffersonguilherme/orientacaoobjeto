using ProjetoBalta.ContentContext;

namespace ProjetoBalta {
    class Program {
    static void Main(string[] args){

        var articles = new List<Article>();
        articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
        articles.Add(new Article("Artigo sobre C#", "orientacao-c#"));
        articles.Add(new Article("Artigo sobre .NET", "orientacao-net"));

            foreach(var article in articles){
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }
            var courses = new List<Course>();
            var courseOOP = new Course("Fundamento OOP", "fundamentos-oop");
            var courseCsharp = new Course("Fundamento C#", "fundamentos-csharp");
            var courseAspNet = new Course("Fundamento ASP.NET", "fundamentos-aspnet");

            courses.Add(courseOOP);
            courses.Add(courseCsharp);
            courses.Add(courseAspNet);

            var careers = new List<Career>();
            var careerDotnet = new Career("Espercialista .NET", "espercialis-dotnet");
            var carrerItem = new CareerItem(1, "Comece por aqui", "", null);
            careerDotnet.Items.Add(carrerItem);
            careers.Add(careerDotnet);

            foreach(var career in careers){
                Console.WriteLine(career.Title);
                foreach(var item in career.Items){
                    Console.WriteLine($"{item.Order} - {item.Title}");
                }
            }

        }
    }

}