using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SampleApplication
{
    public class ScanProfile: XMLData
    {
        #region PropertyScanner

        public ScanSettingMode CurrentScanSettingMode { get; set; }
        public ColorMode CurrentColorMode { get; set; }
        public Resolution CurrentResolution { get; set; }
        public FeederMode CurrentFeeder { get; set; }
        public FeederMode CurrentRescanFeeder { get; set; }
        public Sides CurrentSides { get; set; }
        public PaperSize CurrentPaperSize { get; set; }
        public Orientation CurrentOrientation { get; set; }
        public Rotation FontRotation { get; set; }
        public Rotation BackRotation { get; set; }
        public bool OutOfPaperAutoResolve { get; set; }
        public bool PaperJamAutoResolve { get; set; }
        public bool CoverOpenAutoResolve { get; set; }
        public bool MultiFeedAutoResolve { get; set; }

        [XmlIgnore]
        public int ResolutionValue
        {
            get
            {
                switch (CurrentResolution)
                {
                    case Resolution.Resolution75:
                        return 75;
                 
                    case Resolution.Resolution100:
                        return 100;
                        
                    case Resolution.Resolution150:
                        return 150;
                        
                    case Resolution.Resolution200:
                        return 200;
                        
                    case Resolution.Resolution240:
                        return 240;
                        
                    case Resolution.Resolution300:
                        return 300;
                        
                    case Resolution.Resolution400:
                        return 400;
                    
                    case Resolution.Resolution500:
                        return 500;
                    default:
                        throw new Exception("Invalid Value");
                }
            }
            set
            {
                switch (value)
                {
                    case 75:
                        CurrentResolution = Resolution.Resolution75;
                        break;
                    case 100:
                        CurrentResolution = Resolution.Resolution100;
                        break;
                    case 150:
                        CurrentResolution = Resolution.Resolution150;
                        break;
                    case 200:
                        CurrentResolution = Resolution.Resolution200;
                        break;
                    case 240:
                        CurrentResolution = Resolution.Resolution240;
                        break;
                    case 300:
                        CurrentResolution = Resolution.Resolution300;
                        break;
                    case 400:
                        CurrentResolution = Resolution.Resolution400;
                        break;
                    case 500:
                        CurrentResolution = Resolution.Resolution500;
                        break;
                    default:
                        throw new Exception("Invalid Value");
                }
            }
        }
        [XmlIgnore]
        public string CurrentPaperSizeValue
        {
            get
            {
                switch (CurrentPaperSize)
                {
                    case PaperSize.A0:
                        return "A0";
                    case PaperSize.A1:
                        return "A1";
                    case PaperSize.A2:
                        return "A2";
                    case PaperSize.A3:
                        return "A3";
                    case PaperSize.A4:
                        return "A4";
                    case PaperSize.A5:
                        return "A5";
                    case PaperSize.B:
                        return "B";
                    case PaperSize.B0:
                        return "B0";
                    case PaperSize.B1:
                        return "B1";
                    case PaperSize.B2:
                        return "B2";
                    case PaperSize.B3:
                        return "B3";
                    case PaperSize.B4:
                        return "B4";
                    case PaperSize.B5:
                        return "B5";
                    case PaperSize.B6:
                        return "B6";
                    case PaperSize.Legal:
                        return "Legal";
                    case PaperSize.Letter:
                        return "Letter";
                    case PaperSize.Maximum:
                        return "Maximum";
                    case PaperSize.Minimum:
                        return "Minimum";
                    default:
                        throw new Exception("Invalid Value");
                }
            }
            set
            {
                switch (value)
                {
                    case "A0":
                        CurrentPaperSize = PaperSize.A0;
                        break;
                    case "A1":
                        CurrentPaperSize = PaperSize.A1;
                        break;
                    case "A2":
                        CurrentPaperSize = PaperSize.A2;
                        break;
                    case "A3":
                        CurrentPaperSize = PaperSize.A3;
                        break;
                    case "A4":
                        CurrentPaperSize = PaperSize.A4;
                        break;
                    case "A5":
                        CurrentPaperSize = PaperSize.A5;
                        break;
                    case "B":
                        CurrentPaperSize = PaperSize.B;
                        break;
                    case "B0":
                        CurrentPaperSize = PaperSize.B0;
                        break;
                    case "B1":
                        CurrentPaperSize = PaperSize.B1;
                        break;
                    case "B2":
                        CurrentPaperSize = PaperSize.B2;
                        break;
                    case "B3":
                        CurrentPaperSize = PaperSize.B3;
                        break;
                    case "B4":
                        CurrentPaperSize = PaperSize.B4;
                        break;
                    case "B5":
                        CurrentPaperSize = PaperSize.B5;
                        break;
                    case "B6":
                        CurrentPaperSize = PaperSize.B6;
                        break;
                    case "Legal":
                        CurrentPaperSize = PaperSize.Legal;
                        break;
                    case "Letter":
                        CurrentPaperSize = PaperSize.Letter;
                        break;
                    case "Maximum":
                        CurrentPaperSize = PaperSize.Maximum;
                        break;
                    case "Minimum":
                        CurrentPaperSize = PaperSize.Minimum;
                        break;
                    default:
                        throw new Exception("Invalid Value");
                }
            }
        }
        #endregion

        #region PropertyVRSGeneral

        public bool Desknew { get; set; }
        public bool AutoCrop { get; set; }
        public bool EdgeCleanup { get; set; }
        public bool RemoveHole { get; set; }
        public bool DeleteBlank { get; set; }
        public int BlankContentSensitivity { get; set; }
        public bool IgnoreHolePunches { get; set; }
        public bool AutoRotate { get; set; }
        public int BrightnessBlackAndWhite { get; set; }
        public int BrightnessGrayScale { get; set; }
        public int BrightnessColor { get; set; }
        public int ContrastBlackAndWhite { get; set; }
        public int ContrastGrayScale { get; set; }
        public int ContrastColor { get; set; }
        public int GammaBlackAndWhite { get; set; }
        public int GammaGrayScale { get; set; }
        public int GammaColor { get; set; }
        public bool AutoBrightness { get; set; }
        public bool AdvanceClarity { get; set; }
        public int  AdvanceClarityValue { get; set; }
        public bool AnalyzeColor { get; set; }
        public bool IgnorePicture { get; set; }
        public int Thickness { get; set; }
        public int Speckle { get; set; }
        
        [XmlIgnore]
        public int Brightness
        {
            get
            {
                if (CurrentColorMode == ColorMode.BlackAndWhite)
                    return BrightnessBlackAndWhite;
                if (CurrentColorMode == ColorMode.Grayscale)
                    return BrightnessGrayScale;
                return BrightnessColor;
                
            }
            set
            {
                if (CurrentColorMode == ColorMode.BlackAndWhite)
                    BrightnessBlackAndWhite = value;
                else if (CurrentColorMode == ColorMode.Grayscale)
                    BrightnessGrayScale = value;
                else BrightnessColor = value;
            }
        }
        [XmlIgnore]
        public int Contrast
        {
            get
            {
                if (CurrentColorMode == ColorMode.BlackAndWhite)
                    return ContrastBlackAndWhite;
                if (CurrentColorMode == ColorMode.Grayscale)
                    return ContrastGrayScale;
                return ContrastColor;
                
            }
            set
            {
                if (CurrentColorMode == ColorMode.BlackAndWhite)
                    ContrastBlackAndWhite = value;
                else if (CurrentColorMode == ColorMode.Grayscale)
                    ContrastGrayScale = value;
                else ContrastColor = value;
            }
        }
        [XmlIgnore]
        public int Gamma
        {
            get
            {
                if (CurrentColorMode == ColorMode.BlackAndWhite)
                    return GammaBlackAndWhite;
                if (CurrentColorMode == ColorMode.Grayscale)
                    return GammaGrayScale;
                return GammaColor;
                
            }
            set
            {
                if (CurrentColorMode == ColorMode.BlackAndWhite)
                    GammaBlackAndWhite = value;
                else if (CurrentColorMode == ColorMode.Grayscale)
                    GammaGrayScale = value;
                else GammaColor = value;
            }
        }
        #endregion

        #region VRSColor
        public bool DetectColor { get; set; }
        public bool DetectSmallColorObject { get; set; }
        public int ContentSensitivity { get; set; }
        public int ObjectSensitivity { get; set; }
        public bool IgnoreBackgroundColor { get; set; }
        public bool Smoothing { get; set; }
        public int SmoothingValue { get; set; }
        public bool SnapToWhite { get; set; }
        public bool BackgroundColorToWhite { get; set; }
        #endregion

        #region Job

        public RawImageType RawImageType { get; set; }
#endregion


        public static void Reload()
        {
            _currentSetting = null;
        }
        private static ScanProfile _currentSetting;

        public static ScanProfile CurrentSetting
        {
            get
            {
                if (_currentSetting == null)
                {
                    try
                    {
                        _currentSetting = Load<ScanProfile>("ScanProfile.xml");
                    }
                    catch
                    {
                        _currentSetting = new ScanProfile();
                    }
                }
                return _currentSetting;
            }
        }
    }
}
