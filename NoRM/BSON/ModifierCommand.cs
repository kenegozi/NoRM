﻿
namespace NoRM.BSON
{
    /// <summary>
    /// The modifier command.
    /// </summary>
    public abstract class ModifierCommand : Command
    {
        protected ModifierCommand(string command, object value) : base(command, value)
        {
            
        }
    }
}
