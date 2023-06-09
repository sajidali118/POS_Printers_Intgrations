﻿using System;

namespace ESCPOS_NET.Emitters
{
    [Flags]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "Enums are easier to read if they have whitespace alignment.")]
    public enum Color
    {
        Black = 0,
        Red   = 1
    }
}
