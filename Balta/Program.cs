using System.Linq;
using Balta.ContentContext;
namespace Balta;

class Program
{
    static void Main(string[] args)
    {
        var articles = new List<Article>();

        articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
        articles.Add(new Article("Artigo sobre C#", "csharp"));
        articles.Add(new Article("Artigo sobre .NET", "dotnet"));

        // foreach (var article in articles)
        //  {
        //      Console.WriteLine(article.Id);
        //      Console.WriteLine(article.Title);
        //      Console.WriteLine(article.URL);
        //  }

        var courses = new List<Course>();
        var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
        var courseCSharp = new Course("Fundamentos C#", "fundamentos-csharp");
        var courseAspNet = new Course("Fundamentos ASP .NET", "fundamentos-aspnet");

        courses.Add(courseCSharp);
        courses.Add(courseOOP);
        courses.Add(courseAspNet);

        var careers = new List<Career>();
        var careerDotNet = new Career("Especialista .NET", "especialista-dotnet");
        var careerItem2 = new CareerItem(2, "Aprenda C#", "", courseCSharp);
        var careerItem = new CareerItem(1, "Começe por aqui", "", courseOOP);
        var careerItem3 = new CareerItem(3, "Aprenda .NET", "", courseAspNet);
        careerDotNet.Items.Add(careerItem2);
        careerDotNet.Items.Add(careerItem);
        careerDotNet.Items.Add(careerItem3);
        careers.Add(careerDotNet);

        foreach (var career in careers)
        {
            Console.WriteLine(career.Title);
            //Pode usar OrderByDescending
            foreach (var item in career.Items.OrderBy(x => x.Order))
            {
                Console.WriteLine($"{item.Order} - {item.Title}");
                Console.WriteLine(item.Course.Title);
                Console.WriteLine(item.Course.Level);
            }
        }
    }
}
