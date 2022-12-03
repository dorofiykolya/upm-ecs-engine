namespace Battle.Engine
{
    public interface IExternalResolver
    {
        T Resolve<T>() where T : class;
    }
}