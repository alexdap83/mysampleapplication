using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        #endregion

        #region PropertyVRSGeneral

        public bool Desknew { get; set; }
        public bool AutoCrop { get; set; }
        public bool EdgeCleanup { get; set; }
        public bool RemoveHole { get; set; }
        public bool RemoveBlank { get; set; }
        public int BlankContentSensitivity { get; set; }
        public int IgnoreHolePunches { get; set; }
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
        #endregion

        #region VRSColor
        public bool DetectColor { get; set; }
        public bool DetectSmallColorObject { get; set; }
        public int ContentSensitivity { get; set; }
        public int ObjectSensitivity { get; set; }
        public bool IgnoreBackgroundColor { get; set; }
        #endregion


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
