// Copyright (c) Speykious
// This file is part of SharpWave.
// SharpWave is licensed under the LGPL v3 License. See LICENSE.LESSER for details.

namespace SharpWave;

/// <summary>
/// Class holding a bunch of options to display an audio frame.
/// </summary>
public class AudioSpectrum
{
    #region General settings
    /// <summary>
    /// Position of the spectrum.
    /// </summary>
    /// <remarks>
    /// Each coordinate maps the screen on the [0, 1] interval,
    /// so (0, 0) is the top left corner and (1, 1) is the bottom right corner.
    /// </remarks>
    public (float, float) Position { get; set; }

    /// <summary>
    /// Scale of the spectrum. Linear, with 1 being the default.
    /// </summary>
    public float Scale { get; set; }

    /// <summary>
    /// Multiplies the amplitude (or bar height) of the spectrum.
    /// </summary>
    public float AmplitudeMultiplier { get; set; }

    /// <summary>
    /// Maximum amplitude (or bar height) of the spectrum.
    /// </summary>
    public float MaxAmplitude { get; set; }

    /// <summary>
    /// Fixed height of the bars. The amplitude of the sound gets added to it.
    /// </summary>
    public float FixedHeight { get; set; }
    #endregion

    /// <summary>
    /// How the spectrum will be drawn - with bars, lines or with a filled shape.
    /// </summary>
    public SpectrumDrawingMode DrawingMode { get; set; }

    #region Mirror settings
    /// <summary>
    /// Whether to mirror the spectrum horizontally.
    /// </summary>
    public bool MirrorH { get; set; }

    /// <summary>
    /// Multiplies the amplitude (or bar height) of the mirror spectrum.
    /// </summary>
    public float MirrorAmplitudeMultiplier { get; set; }
    #endregion

    #region Bar and line settings
    /// <summary>
    /// Shape used to draw the end points of lines, but also bars.
    /// </summary>
    public LineCap LineCap { get; set; }

    /// <summary>
    /// Shape used to join two line segments where they meet (only applies in line mode).
    /// </summary>
    public LineJoin LineJoin { get; set; }

    /// <summary>
    /// The miter limit ratio (only applies in line mode).
    /// </summary>
    /// <remarks>
    /// Higher values makes the line more miter.
    /// </remarks>
    public float LineMiterLimit { get; set; }

    /// <summary>
    /// Width of a spectrum bar (only applies in bar mode).
    /// </summary>
    public float BarWidth { get; set; }

    /// <summary>
    /// Width of a spectrum line (only applies in line mode).
    /// </summary>
    public float LineWidth { get; set; }
    #endregion

    #region Smoothing settings
    /// <summary>
    /// Length of the smoothing filter (basically softness).
    /// </summary>
    public int SmoothingFilterLength { get; set; }

    /// <summary>
    /// Shape of the smoothing filter.
    /// TODO: replace string type with some enum type
    /// </summary>
    public WindowFunction? SmoothingFilterShape { get; set; }

    /// <summary>
    /// The parameter of the smoothing filter
    /// </summary>
    public float SmoothingFilterParameter { get; set; }

    /// <summary>
    /// Index clipping mode for smoothness
    /// </summary>
    /// <value></value>
    public IndexClipMode? SmoothingIndexClipMode { get; set; }
    #endregion
}
