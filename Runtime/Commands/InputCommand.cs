using System;
using Battle.Engine.Inputs;

namespace Battle.Engine.Commands
{
    public abstract class InputCommand<TWorld> where TWorld : ECS.World
    {
        protected InputCommand(Type inputType)
        {
            Type = inputType;
        }

        public Type Type { get; }

        public abstract void ExecuteCommand(Input action, TWorld state);
    }

    public abstract class InputCommand<T, TWorld> : InputCommand<TWorld> where T : Input where TWorld : ECS.World
    {
        protected InputCommand() : base(typeof(T))
        {
        }

        public override void ExecuteCommand(Input action, TWorld state)
        {
            Execute((T)action, state);
        }

        protected abstract void Execute(T action, TWorld state);
    }
}