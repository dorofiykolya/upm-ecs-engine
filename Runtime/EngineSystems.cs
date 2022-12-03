using Battle.Engine.Providers;
using Battle.Engine.Systems;

namespace Battle.Engine
{
    public class EngineSystems<TWorld> where TWorld : ECS.World
    {
        private readonly IEngineSystemsProvider<TWorld> _provider;
        private ISystem<TWorld>[]? _systems;

        public EngineSystems(IEngineSystemsProvider<TWorld> provider)
        {
            _provider = provider;
        }

        public void Initialize(TWorld state)
        {
            _systems = _provider.CreateSystems();

            foreach (var system in _systems)
            {
                var initialize = system as ISystemInitialize<TWorld>;
                if (initialize != null) initialize.OnInitialize(state);
            }
        }

        public void Tick(TWorld world, int currentTick)
        {
            foreach (var system in _systems)
            {
                system.OnTick(world, currentTick);
            }
        }
    }
}