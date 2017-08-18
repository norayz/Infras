using System;
using System.Collections.Generic;
using NLog.Targets;
using Infras.Logger.Appenders;

namespace Infras.Logger.Providers.NLogProvider
{
    public class AppenderAdapter : IAppenderAdapter
    {
        private static readonly IDictionary<Type, Type> _appenders2Adapters;

        static AppenderAdapter()
        {
            _appenders2Adapters = new Dictionary<Type, Type>
            {
                { typeof(ColorConsoleAppender), typeof(ColoredConsoleAdapter) },
                { typeof(FileAppender), typeof(FileAdapter) }
            };
        }

        public Target GetTargetFromAppender(IAppender appender)
        {
            if (appender == null)
            {
                throw new ArgumentNullException(nameof(appender));
            }

            var adapterType = _appenders2Adapters[appender.GetType()];
            var adapter = (IAppenderAdapter)Activator.CreateInstance(adapterType);

            return adapter.GetTargetFromAppender(appender);
        }
    }
}
