// Copyright (c) Speykious
// This file is part of SharpWave.
// SharpWave is licensed under the LGPL v3 License. See LICENSE.LESSER for details.

namespace SharpWave.Enums;

/// <summary>
/// Index clipping mode for smoothness
/// </summary>
public enum IndexClipMode
{
    /// Clip
    Clip,
    /// Periodic (circular)
    Periodic,
    /// Mirror
    Mirror,
    /// Zero
    Zero,
}
