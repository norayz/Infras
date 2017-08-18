using System;
using NLog.Targets;
using Infras.Logger.Appenders;

namespace Infras.Logger.Providers.NLogProvider
{
    public class ColoredConsoleAdapter : IAppenderAdapter
    {
        public Target GetTargetFromAppender(IAppender appender)
        {
            var colorConnsoleAppender = appender as ColorConsoleAppender;
            if (colorConnsoleAppender == null)
            {
                throw new ArgumentException("Appender must be of type ColorConsoleAppender", nameof(appender));
            }

            return new ColoredConsoleTarget()
            {
                Name = colorConnsoleAppender.Name,
                Layout = colorConnsoleAppender.Layout
            };
        }
    }
}
