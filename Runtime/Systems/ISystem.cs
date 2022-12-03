namespace Battle.Engine.Systems
{
    public interface ISystem<in TWorld> where TWorld : ECS.World
    {
        void OnTick(TWorld world, int tick);
    }

    public interface ISystemInitialize<in TWorld> where TWorld : ECS.World
    {
        void OnInitialize(TWorld world);
    }
}