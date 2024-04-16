namespace Balta.ContentContext
{
    public abstract class Content : Base
    {
        public Content(string title, string url)
        {
            Title = title;
            URL = url;
        }

        public string Title { get; set; }

        public string URL { get; set; }

    }
}