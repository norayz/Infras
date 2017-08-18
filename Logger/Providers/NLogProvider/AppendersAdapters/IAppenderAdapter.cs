using Infras.Logger.Appenders;
using NLog.Targets;

namespace Infras.Logger.Providers.NLogProvider
{
    public interface IAppenderAdapter
    {
        Target GetTargetFromAppender(IAppender appender);
    }
}