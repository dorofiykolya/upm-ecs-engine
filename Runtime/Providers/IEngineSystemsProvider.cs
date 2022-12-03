using Battle.Engine.Systems;

namespace Battle.Engine.Providers
{
    public interface IEngineSystemsProvider<TWorld> where TWorld : ECS.World
    {
        ISystem<TWorld>[] CreateSystems();
    }
}