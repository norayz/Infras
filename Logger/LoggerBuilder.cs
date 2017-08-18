using Infras.Logger.Appenders;
using Infras.Logger.Providers;
using Infras.Logger.Providers.NLogProvider;

namespace Infras.Logger
{
    public class LoggerBuilder : ILoggerBuilder
    {
        private readonly ILoggerProvider _provider;

        public ILogger Logger => _provider.Logger;

        public LoggerBuilder()
        {
            _provider = new NLogProvider();
        }

        public ILoggerBuilder AddAppender(IAppender appender)
        {
            _provider.AddAppender(appender);
            return this;
        }
    }
}