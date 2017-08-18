namespace Infras.Logger.Appenders
{
    public class ColorConsoleAppender : IAppender
    {
        private const string DEFAULT_NAME = "ColorConsoleLogger";
        private const string DEFAULT_LAYOUT = @"${date:format=HH\:mm\:ss} ${level} ${logger} - ${message}";

        public string Name { get; }

        public string Layout { get; }

        public ColorConsoleAppender(string name = DEFAULT_NAME, string layout = DEFAULT_LAYOUT)
        {
            Name = name;
            Layout = layout;
        }
    }
}
