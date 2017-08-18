# Infras.Logger

## Basic usage:
```
var logger = new LoggerBuilder()
	.AddAppender(new ColorConsoleAppender())
	.AddAppender(new FileAppender(path:@"C:\logs\log.txt"))
	.Logger;
```