using Infras.Logger.Appenders;

namespace Infras.Logger.Providers
{
    public interface ILoggerProvider
    {
        ILogger Logger { get; }

        void AddAppender(IAppender appender);
    }
}