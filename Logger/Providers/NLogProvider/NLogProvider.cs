using Infras.Logger.Appenders;
using NLog;
using NLog.Config;
using NLog.Targets;

namespace Infras.Logger.Providers.NLogProvider
{
    public class NLogProvider : ILoggerProvider
    {
        private readonly LoggingConfiguration _config;
        private readonly AppenderAdapter _appenderAppender;

        public ILogger Logger
        {
            get
            {
                LogManager.Configuration = _config;
                NLog.ILogger nlogger = LogManager.GetLogger("nlog");

                return new NLogAdapter(nlogger);
            }
        }

        public NLogProvider()
        {
            _config = new LoggingConfiguration();
            _appenderAppender = new AppenderAdapter();
        }

        public void AddAppender(IAppender appender)
        {
            if (appender == null)
            {
                throw new System.ArgumentNullException(nameof(appender));
            }

            var target = _appenderAppender.GetTargetFromAppender(appender);
            AddTarget(target);
        }

        private void AddTarget(Target target)
        {
            if (target == null)
            {
                throw new System.ArgumentNullException(nameof(target));
            }

            _config.AddTarget(target);
            _config.AddRuleForAllLevels(target);
        }
    }
}