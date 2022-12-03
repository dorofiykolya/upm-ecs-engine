namespace Battle.Engine
{
    public class EngineFactory
    {
        public IEngine Create<TWorld, TConfiguration>(TConfiguration config,
            IExternalProvider<TWorld, TConfiguration> externalProvider)
            where TWorld : ECS.World
            where TConfiguration : EngineConfiguration
        {
            var engine = new Engine<TWorld, TConfiguration>(config, externalProvider);
            return engine;
        }
    }
}