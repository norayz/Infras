using System;

namespace Infras.Logger.Providers.NLogProvider
{
    public class NLogAdapter : ILogger
    {
        private readonly NLog.ILogger _logger;

        public NLogAdapter(NLog.ILogger logger)
        {
            if (logger == null)
            {
                throw new ArgumentNullException(nameof(logger));
            }

            _logger = logger;
        }

        public void Error(string msg)
        {
            if (string.IsNullOrEmpty(msg))
            {
                throw new ArgumentException("message", nameof(msg));
            }

            _logger.Error(msg);
        }

        public void Info(string msg)
        {
            if (string.IsNullOrEmpty(msg))
            {
                throw new ArgumentException("message", nameof(msg));
            }

            _logger.Info(msg);
        }

        public void Warn(string msg)
        {
            if (string.IsNullOrEmpty(msg))
            {
                throw new ArgumentException("message", nameof(msg));
            }

            _logger.Warn(msg);
        }
    }
}
