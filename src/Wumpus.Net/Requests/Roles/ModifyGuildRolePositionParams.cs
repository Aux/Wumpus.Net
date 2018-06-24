﻿using Voltaic.Serialization;

namespace Wumpus.Requests
{
    /// <summary> xxx </summary>
    public class ModifyGuildRolePositionParams
    {
        /// <summary> xxx </summary>
        [ModelProperty("id")]
        public Snowflake Id { get; }
        /// <summary> xxx </summary>
        [ModelProperty("position")]
        public int Position { get; }

        public ModifyGuildRolePositionParams(Snowflake id, int position)
        {
            Id = id;
            Position = position;
        }

        public void Validate()
        {
            Preconditions.NotNegative(Position, nameof(Position));
        }
    }
}
