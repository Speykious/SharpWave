// Copyright (c) Speykious
// This file is part of SharpWave.
// SharpWave is licensed under the LGPL v3 License. See LICENSE.LESSER for details.

namespace SharpWave;

public enum FrequencyScale
{
    #region Common
    Linear,
    Logarithmic,
    #endregion

    #region Perceptual
    Mel,
    Bark,
    EquivalentRectangularBandwidthERB,
    #endregion

    #region Adjustable
    HyperbolicSine,
    ShiftedLogarithmic,
    NthRoot,
    NegativeExponential,
    #endregion
}
