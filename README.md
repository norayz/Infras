# Infras.Logger

## Basic usage:
```
var logger = new LoggerBuilder()
	.AddAppender(new ColorConsoleAppender())
	.AddAppender(new FileAppender(path:@"C:\logs\log.txt"))
	.Logger;

logger.Info("some info in here");
logger.Warn("some warn in here");
logger.Error("some error in here");
```