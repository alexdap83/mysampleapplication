using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleApplication
{
    public enum ScanSettingMode
    {
        Scanner,
        VRSGeneral,
        VRSColor
    }
    public enum ColorMode
    {
        BlackAndWhite,
        Grayscale,
        Color
    }
    public enum Resolution
    {
        Resolution75,
        Resolution100,
        Resolution150,
        Resolution200,
        Resolution240,
        Resolution300,
        Resolution400,
        Resolution500,
        Resolution600
    }
    public enum FeederMode
    {
        Flatbed,
        Feerder
    }
    public enum Sides
    {
        OneSide,
        BothSides
    }
    public enum Orientation
    {
        Portrait,
        Landscape
    }
    public enum Rotation
    {
        Rotate0,
        Rotate90Left,
        Rotate90Right,
        Rotate180
    }

    public enum PaperSize
    {
        A0,
        A1,
        A2,
        A3,
        A4,
        A5,
        B,
        B0,
        B1,
        B2,
        B3,
        B4,
        B5,
        B6,
        Legal,
        Letter,
        Maximum,
        Minimum
    }
    public enum ViewerType
    {
        CompactThumbnail,
        Thumbnail,
        Single
    }
    public enum FitType
    {
        Page,
        Horizonal,
        Vertical,
        View100
    }
    public enum CursorType
    {
        Zoom,
        Pan,
        Draw
    }

    public enum RawImageType
    {
        Color,
        Grayscale,
        Off
    }
}
