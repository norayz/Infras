namespace Infras.Logger.Appenders
{
    public class FileAppender : IAppender
    {
        private const string DEFAULT_NAME = "FileLogger";

        public string Name { get; }

        public string Layout { get; }

        public string Path { get; }

        public FileAppender(string name = DEFAULT_NAME,
            string layout = @"${date:format=HH\:mm\:ss} ${level} ${logger} - ${message}", 
            string path = "${basedir}/log.txt")
        {
            Name = name;
            Layout = layout;
            Path = path;
        }
    }
}
