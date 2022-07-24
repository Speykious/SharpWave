// Copyright (c) Speykious
// This file is part of SharpWave.
// SharpWave is licensed under the LGPL v3 License. See LICENSE.LESSER for details.

namespace SharpWave.Enums;

/// <summary>
/// The mode of constant/variable-Q transform.
/// Constant-bandwidth works best with linear frequency spectrums,
/// while constant-Q works best for log-frequency spectrums, otherwise variable-Q.
/// </summary>
public enum CQTMode
{
    ConstantBandwidth,
    ConstantQ,
    PseudoConstantQ,
    VariableQ,
}
