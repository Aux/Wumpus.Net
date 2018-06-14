﻿using System;
using System.Buffers.Text;

namespace Voltaic.Serialization.Utf8
{
    public static partial class Utf8Reader
    {
        public static bool TryReadGuid(ref ReadOnlySpan<byte> remaining, out Guid result)
        {
            if (!Utf8Parser.TryParse(remaining, out result, out int bytesConsumed))
                return false;
            remaining = remaining.Slice(bytesConsumed);
            return true;
        }
    }
}
