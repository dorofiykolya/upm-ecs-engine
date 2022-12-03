using System;
using System.Collections.Generic;
using Battle.Engine.Commands;

namespace Battle.Engine.Providers
{
    public class EngineCommandsProvider<TWorld> : IEngineCommandsProvider<TWorld> where TWorld : ECS.World
    {
        private readonly Dictionary<Type, InputCommand<TWorld>> _mapCommands =
            new Dictionary<Type, InputCommand<TWorld>>();

        public InputCommand<TWorld>? GetCommand(Type inputType)
        {
            InputCommand<TWorld>? result;
            _mapCommands.TryGetValue(inputType, out result);
            return result;
        }

        public void Map<TCommand>()
            where TCommand : InputCommand<TWorld>, new()
        {
            var command = new TCommand();
            _mapCommands[command.Type] = command;
        }
    }
}