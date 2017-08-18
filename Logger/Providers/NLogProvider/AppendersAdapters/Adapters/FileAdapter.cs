using System;
using NLog.Targets;
using Infras.Logger.Appenders;

namespace Infras.Logger.Providers.NLogProvider
{
    public class FileAdapter : IAppenderAdapter
    {
        public Target GetTargetFromAppender(IAppender appender)
        {
            var fileAppender = appender as FileAppender;
            if (fileAppender == null)
            {
                throw new ArgumentException("Appender must be of type FileAppender", nameof(appender));
            }

            return new FileTarget()
            {
                Name = fileAppender.Name,
                FileName = fileAppender.Path,
                Layout = fileAppender.Layout
            };
        }
    }
}
