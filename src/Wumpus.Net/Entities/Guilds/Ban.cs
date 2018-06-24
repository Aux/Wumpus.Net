﻿using Voltaic;
using Voltaic.Serialization;

namespace Wumpus.Entities
{
    /// <summary> xxx </summary>
    public class Ban
    {
        /// <summary> xxx </summary>
        [ModelProperty("reason")]
        public Utf8String Reason { get; set; }
        /// <summary> xxx </summary>
        [ModelProperty("user")]
        public User User { get; set; }
    }
}
