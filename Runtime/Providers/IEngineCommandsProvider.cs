using System;
using Battle.Engine.Commands;

namespace Battle.Engine.Providers
{
    public interface IEngineCommandsProvider<TWorld> where TWorld : ECS.World
    {
        InputCommand<TWorld>? GetCommand(Type inputType);
    }
}