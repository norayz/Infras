using System;
using Infras.Logger.Providers.NLogProvider;
using Infras.Logger;
using Infras.Logger.Appenders;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new LoggerBuilder()
                .AddAppender(new ColorConsoleAppender())
                .AddAppender(new FileAppender(path:@"C:\logs\log.txt"))
                .Logger;

            logger.Info("some info in here");
            logger.Warn("some warn in here");
            logger.Error("some error in here");

            var logger2 = new LoggerBuilder()
             .AddAppender(new ColorConsoleAppender())
             .AddAppender(new FileAppender())
             .Logger;

            logger2.Info("some info in here");
            logger2.Warn("some warn in here");
            logger2.Error("some error in here");


            Console.ReadKey();
        }
    }
}