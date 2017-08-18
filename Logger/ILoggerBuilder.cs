using Infras.Logger.Appenders;

namespace Infras.Logger
{
    public interface ILoggerBuilder
    {
        ILogger Logger { get; }

        ILoggerBuilder AddAppender(IAppender appender);
    }
}