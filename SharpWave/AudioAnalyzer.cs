// Copyright (c) Speykious
// This file is part of SharpWave.
// SharpWave is licensed under the LGPL v3 License. See LICENSE.LESSER for details.

namespace SharpWave;

/// <summary>
/// Class holding a bunch of options to analyze audio.
/// </summary>
public class AudioAnalyzer
{
    #region General settings
    /// <summary>
    /// Sample provider
    /// </summary>
    public SampleProvider SampleProvider { get; set; }
    /// <summary>
    /// Freqency bands provider
    /// </summary>
    public FrequencyBandsProvider FrequencyBandsProvider { get; set; }
    /// <summary>
    /// Number of bands, the higher the value, the more detailed spectrum will bb
    /// </summary>
    public int SampleOutCount { get; set; }
    /// <summary>
    /// Number of bands on each octave
    /// </summary>
    public int SamplesPerOctave { get; set; }
    /// <summary>
    /// Extends the frequency range up to Nyquist frequency
    /// </summary>
    public bool HighQualityAudioCapture { get; set; }
    /// <summary>
    /// Boosts or attenuate output values by dB
    /// </summary>
    public float OutputMultiplier { get; set; }
    /// <summary>
    /// Stop audio analysis
    /// </summary>
    public bool FreezeAnalyzer { get; set; }
    #endregion

    #region FFT settings
    /// <summary>
    /// Audio input size.
    /// The longer the value, the better frequency resolution will be, at the cost of time resolution
    /// </summary>
    public int InputSize { get; set; }
    /// <summary>
    /// FFT size.
    /// The longer the value, the more bins will be
    /// </summary>
    public int FFTSize { get; set; }
    /// <summary>
    /// Stronger windows provide better sidelobe attenuation and time resolution,
    /// while weaker ones provide better frequency resolution
    /// </summary>
    public WindowFunction WindowFunction { get; set; }
    /// <summary>
    /// Higher values provides better sidelobe attenuation at cost of wider mainlobe width (adjustable window functions only)
    /// </summary>
    public float WindowParameter { get; set; }
    /// <summary>
    /// Positive values skew the window towards earlier parts of the waveform,
    /// while negative values skew towards later parts.
    /// </summary>
    public float WindowSkew { get; set; }
    /// <summary>
    /// Same as window function, but for CQT kernel(s)
    /// </summary>
    public WindowFunction CQTWindowFunction { get; set; }
    /// <summary>
    /// CQT kernel window parameter (adjustable window functions only)
    /// </summary>
    public float CQTWindowParameter { get; set; }
    /// <summary>
    /// Makes CQT kernel windows asymmetric
    /// </summary>
    public float CQTWindowSkew { get; set; }
    /// <summary>
    /// The mode of constant/variable-Q transform.
    /// Constant-bandwidth works best with linear frequency spectrums,
    /// while constant-Q works best for log-frequency spectrums, otherwise variable-Q.
    /// </summary>
    public CQTMode CQTMode { get; set; }
    /// <summary>
    /// Frequency resolution of constant-Q transform in octaves
    /// </summary>
    public int ConstantQOctavesResolution { get; set; }
    /// <summary>
    /// CQT kernel bandwidth (Brown-Puckette only)
    /// </summary>
    public int CQTBandwidth { get; set; }
    /// <summary>
    /// Audio input size in milliseconds at specified frequency (Variable-Q transform only)
    /// </summary>
    public int VariableQTimeResolution { get; set; }
    /// <summary>
    /// The center frequency for desired frequency resolution (Variable-Q transform-only)
    /// </summary>
    public int DesiredVariableQTimeResolution { get; set; }
    /// <summary>
    /// Different frequency scales dictates the VQT resolution
    /// </summary>
    public FrequencyScale VariableQFrequencyResolutionScale { get; set; }
    /// <summary>
    /// Controls the distribution of variable-Q frequency resolution.
    /// Lower values make it constant-Q, while higher values make it
    /// constant-bandwidth (Adjustable frequency scaling functions only)
    /// </summary>
    public float VariableQResolutionLinearFactor { get; set; }
    #endregion

    #region Spectrum settings
    /// <summary>
    /// Mode of the bandpower spectrum
    /// </summary>
    public BandpowerMode BandpowerMode { get; set; }
    /// <summary>
    /// Smoother interpolation algorithm gives smoother bandpower spectrum
    /// </summary>
    public Interpolation FFTBinInterpolation { get; set; }
    /// <summary>
    /// Controls the parameter of the interpolation algorithm used for calculating bandpower spectrum
    /// </summary>
    public float InterpolationAlgorithmParameter { get; set; }
    /// <summary>
    /// Makes FFT bin interpolation works on decibels (dB) scale
    /// </summary>
    public bool InterpolationLogarithmicAmplitudeScale { get; set; }
    /// <summary>
    /// The nth root index used in FFT bin interpolation amplitude scale
    /// </summary>
    public float InterpolationAmplitudeNthRootIndex { get; set; }
    /// <summary>
    /// Bandpower attributes
    /// </summary>
    public BandpowerAttributes BandpowerAttributes { get; set; }
    /// <summary>
    /// Audio reaction smoothness. Higher values makes audio spectrum reacts slower
    /// </summary>
    public float SmoothingTimeConstant { get; set; }
    /// <summary>
    /// Tilts frequency spectrum by dB per octaves, applied to each FFT bins
    /// </summary>
    public int PerBinFrequencyTilt { get; set; }
    /// <summary>
    /// Type of frequency weighting, applied to each FFT bins
    /// </summary>
    public Weighting PerBinWeighting { get; set; }
    /// <summary>
    /// Strength of the frequency weighting, applied to each FFT bins
    /// </summary>
    public float PerBinWeightingAmount { get; set; }
    /// <summary>
    /// Tilts frequency spectrum by dB per octaves, applied to each frequency bands
    /// </summary>
    public int PerBandFrequencyTilt { get; set; }
    /// <summary>
    /// Type of frequency weighting, applied to each frequency bands
    /// </summary>
    public Weighting PerBandWeighting { get; set; }
    /// <summary>
    /// Strength of the frequency weighting, applied to each frequency bands
    /// </summary>
    public float PerBandWeightingAmount { get; set; }
    #endregion

    #region Spectrum Hz
    /// <summary>
    /// Lowest frequencies represented in the X-axis of the AudioProvider spectrum output
    /// </summary>
    public int LowerHz { get; set; }
    /// <summary>
    /// Highest frequencies represented in the X-axis of the AudioProvider spectrum output
    /// </summary>
    public int HigherHz { get; set; }
    /// <summary>
    /// Lowest frequencies represented in the X-axis of the AudioProvider octave bands spectrum output
    /// </summary>
    public float LowerNote { get; set; }
    /// <summary>
    /// Highest frequencies represented in the X-axis of the AudioProvider octave bands spectrum output
    /// </summary>
    public float HigherNote { get; set; }
    /// <summary>
    /// Shifts center frequencies in octave bands
    /// </summary>
    public float OctaveBandsDetune { get; set; }
    /// <summary>
    /// Frequency scale dictates the frequency bands distribution
    /// </summary>
    public FrequencyScale FrequencyScale { get; set; }
    /// <summary>
    /// Controls the distribution of frequencies.
    /// Lower values makes low frequencies more dominant (Adjustable frequency scaling functions only)
    /// </summary>
    public float HzLinearFactor { get; set; }
    #endregion

    #region Spectrum dB
    /// <summary>
    /// Makes spectrum use decibels (dB) rather than linear values
    /// </summary>
    public bool LogarithmicAmplitudeScale { get; set; }
    /// <summary>
    /// Amplitude range in decibels (dB)
    /// </summary>
    public int DecibelRange { get; set; }
    /// <summary>
    /// The nth root index used in linear amplitude scale. Higher values increases lower values energy
    /// </summary>
    public float AmplitudeNthRootIndex { get; set; }
    /// <summary>
    /// Makes the lower dB range of linear amplitude spectrum -Infinity
    /// </summary>
    public bool UseAbsoluteValue { get; set; }
    #endregion
}
