using Battle.Engine.Outputs;

namespace Battle.Engine
{
    public class WorldOutput<TWorld> where TWorld : ECS.World
    {
        private readonly Engine<TWorld> _engine;

        public WorldOutput(Engine<TWorld> engine)
        {
            _engine = engine;
            IsGenerate = engine.Environment.IsGenerateOutputs();
        }

        public bool IsGenerate { get; }

        public T Enqueue<T>() where T : Output, new() => _engine.EngineOutputs.Enqueue<T>(_engine.Tick);
    }
}