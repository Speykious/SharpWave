// Copyright (c) Speykious
// This file is part of SharpWave.
// SharpWave is licensed under the LGPL v3 License. See LICENSE.LESSER for details.

namespace SharpWave.Enums;

public enum WindowFunction
{
    #region B-splines
    Rectangular,
    /// Triangular (Bartlett)
    Triangular,
    Quadratic,
    Parzen,
    #endregion

    #region Other polynomial
    Welch,
    #endregion

    #region Cosine sums and power of sines
    Hann,
    Hamming,
    PowerOfSine,
    Blackman,
    Nuttall,
    FlatTop,
    #endregion

    #region Adjustable
    Gaussian,
    Kaiser,
    Tukey,
    /// Exponential (Poisson)
    Exponential,
    /// Hyperbolic secant (Sech)
    HyperbolicSecant,
    #endregion
}
