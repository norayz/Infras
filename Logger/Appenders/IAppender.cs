namespace Infras.Logger.Appenders
{
    public interface IAppender
    {
        string Name { get; }

        string Layout { get; }
    }
}
