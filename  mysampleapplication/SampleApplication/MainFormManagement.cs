using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleApplication
{
    public partial class MainForm
    {
        private void LoadScanProfile()
        {
            SetColorSettingMode(scanProfile.CurrentColorMode, false);
            SetResolution(scanProfile.ResolutionValue, false);
            SetFeederMode(scanProfile.CurrentFeeder, false);
            SetSides(scanProfile.CurrentSides, false);
            SetPaperSize(scanProfile.CurrentPaperSizeValue, false);
            SetOrientation(scanProfile.CurrentOrientation, false);
            SetRotationFront(scanProfile.FontRotation, false);
            SetRotationBack(scanProfile.BackRotation, false);
            SetOutOfPaperResolve(scanProfile.OutOfPaperAutoResolve, false);
            SetPaperJamResolve(scanProfile.PaperJamAutoResolve, false);
            SetCoverOpenResolve(scanProfile.CoverOpenAutoResolve, false);
            SetMultilFeedResolve(scanProfile.MultiFeedAutoResolve, false);

            DeskewChangedState(scanProfile.Desknew, false);
            AutoCropChangedState(scanProfile.AutoCrop, false);
            SetEdgeCleanup(scanProfile.EdgeCleanup, false);
            SetHolePunchRemoval(scanProfile.RemoveHole, false);
            SetDeleteBlank(scanProfile.DeleteBlank, false);
            SetBlankContentSensitivityValue(scanProfile.BlankContentSensitivity, false);
            SetIgnoreHole(scanProfile.IgnoreHolePunches, false);
            SetAutoRotate(scanProfile.AutoRotate, false);
            SetAutoBrightness(scanProfile.AutoBrightness, false);
            SetAdvancedClarity(scanProfile.AdvanceClarity, false);
            SetAdvancedClarityValue(scanProfile.AdvanceClarityValue, false);
            SetAnalyzeColor(scanProfile.AnalyzeColor, false);
            SetIgnorePicture(scanProfile.IgnorePicture, false);
            SetThicknessValue(scanProfile.Thickness, false);
            SetSpeckleValue(scanProfile.Speckle, false);

            SetDetectColor(scanProfile.DetectColor, false);
            SetSmoothing(scanProfile.Smoothing, false);

            
            
            //SetRawImageType(scanProfile.RawImageType, false);
        }

        private void LoadJob()
        {
            SetRawImageType(appSetting.RawImageType, false);
            EnableDocumentSeperation(appSetting.UseDocumentSeperation, false);
            SetBarCode(appSetting.BarCode, false);
            SetPatchCode(appSetting.PatchCode, false);
            SetDocumentSeperation(appSetting.DocumentSeparation, false);
            SetWhenValueChanges(appSetting.WhenBarCodeChange, false);
            SetDeleteFirstPage(appSetting.IsDeleteFirstPage,false);
            SetDeleteBatchAfterExport(appSetting.IsDeleteBatchAfterExport,false);
            SetCreateNewBatchAfterExport(appSetting.IsCreateNewBatchAfterExport,false);
            SetBackgroundExport(appSetting.IsBackgroundExport,false);
        }


        private void SetPatchCode(PatchCodeType patchcode, bool autoSave)
        {
            switch (patchcode)
            {
                case PatchCodeType.PatchII:
                    SetChecked(barCheckItemPatchII, true);
                    barButtonItemDocumentSeperation.LargeGlyph = barCheckItemPatchII.LargeGlyph;
                    barCheckItemUsingPatchCodes.Glyph = barCheckItemPatchII.Glyph;
                    break;
                case PatchCodeType.PatchIII:
                    SetChecked(barCheckItemPatchIII, true);
                    barButtonItemDocumentSeperation.LargeGlyph = barCheckItemPatchIII.LargeGlyph;
                    barCheckItemUsingPatchCodes.Glyph = barCheckItemPatchIII.Glyph;
                    break;
                case PatchCodeType.PatchT:
                    SetChecked(barCheckItemPatchT, true);
                    barButtonItemDocumentSeperation.LargeGlyph = barCheckItemPatchT.LargeGlyph;
                    barCheckItemUsingPatchCodes.Glyph = barCheckItemPatchT.Glyph;
                    break;
            }
            if (autoSave)
            {
                SetChecked(barCheckItemUsingPatchCodes, true);
                SetChecked(barButtonItemDocumentSeperation, true);
                appSetting.PatchCode = patchcode;
            }
            
        }

        private void SetBarCode(BarCodeType barcode, bool autoSave)
        {
            switch (barcode)
            {
                case BarCodeType.Aztec:
                    SetChecked(barCheckItemBarAztec, true);
                    barButtonItemDocumentSeperation.LargeGlyph = barCheckItemBarAztec.LargeGlyph;
                    barButtonItemType.LargeGlyph = barCheckItemBarAztec.LargeGlyph;
                    barCheckItemUsingBarCodes.Glyph = barCheckItemBarAztec.GlyphDisabled;
                    break;
                case BarCodeType.Codabar:
                    SetChecked(barCheckItemCodabar, true);
                    barButtonItemDocumentSeperation.LargeGlyph = barCheckItemCodabar.LargeGlyph;
                    barButtonItemType.LargeGlyph = barCheckItemCodabar.LargeGlyph;
                    barCheckItemUsingBarCodes.Glyph = barCheckItemCodabar.GlyphDisabled;
                    break;
                case BarCodeType.Code39:
                    SetChecked(barCheckItemCode39, true);
                    barButtonItemDocumentSeperation.LargeGlyph = barCheckItemCode39.LargeGlyph;
                    barButtonItemType.LargeGlyph = barCheckItemCode39.LargeGlyph;
                    barCheckItemUsingBarCodes.Glyph = barCheckItemCode39.GlyphDisabled;
                    break;
                case BarCodeType.Code93:
                    SetChecked(barCheckItemCode93, true);
                    barButtonItemDocumentSeperation.LargeGlyph = barCheckItemCode93.LargeGlyph;
                    barButtonItemType.LargeGlyph = barCheckItemCode93.LargeGlyph;
                    barCheckItemUsingBarCodes.Glyph = barCheckItemCode93.GlyphDisabled;
                    break;
                case BarCodeType.Code128:
                    SetChecked(barCheckItemCode128, true);
                    barButtonItemDocumentSeperation.LargeGlyph = barCheckItemCode128.LargeGlyph;
                    barButtonItemType.LargeGlyph = barCheckItemCode128.LargeGlyph;
                    barCheckItemUsingBarCodes.Glyph = barCheckItemCode128.GlyphDisabled;
                    break;
                case BarCodeType.DataMatrix:
                    SetChecked(barCheckItemDataMatrix, true);
                    barButtonItemDocumentSeperation.LargeGlyph = barCheckItemDataMatrix.LargeGlyph;
                    barButtonItemType.LargeGlyph = barCheckItemDataMatrix.LargeGlyph;
                    barCheckItemUsingBarCodes.Glyph = barCheckItemDataMatrix.GlyphDisabled;
                    break;
                case BarCodeType.EAN:
                    SetChecked(barCheckItemEAN, true);
                    barButtonItemDocumentSeperation.LargeGlyph = barCheckItemEAN.LargeGlyph;
                    barButtonItemType.LargeGlyph = barCheckItemEAN.LargeGlyph;
                    barCheckItemUsingBarCodes.Glyph = barCheckItemEAN.GlyphDisabled;
                    break;
                case BarCodeType.InterLeaved2of5:
                    SetChecked(barCheckItemInterLeaved2of5, true);
                    barButtonItemDocumentSeperation.LargeGlyph = barCheckItemInterLeaved2of5.LargeGlyph;
                    barButtonItemType.LargeGlyph = barCheckItemInterLeaved2of5.LargeGlyph;
                    barCheckItemUsingBarCodes.Glyph = barCheckItemInterLeaved2of5.GlyphDisabled;
                    break;
                case BarCodeType.PDF417:
                    SetChecked(barCheckItemPdf417, true);
                    barButtonItemDocumentSeperation.LargeGlyph = barCheckItemPdf417.LargeGlyph;
                    barButtonItemType.LargeGlyph = barCheckItemPdf417.LargeGlyph;
                    barCheckItemUsingBarCodes.Glyph = barCheckItemPdf417.GlyphDisabled;
                    break;
                case BarCodeType.PostNet:
                    SetChecked(barCheckItemPostNet, true);
                    barButtonItemDocumentSeperation.LargeGlyph = barCheckItemPostNet.LargeGlyph;
                    barButtonItemType.LargeGlyph = barCheckItemPostNet.LargeGlyph;
                    barCheckItemUsingBarCodes.Glyph = barCheckItemPostNet.GlyphDisabled;
                    break;
                case BarCodeType.QR:
                    SetChecked(barCheckItemQR, true);
                    barButtonItemDocumentSeperation.LargeGlyph = barCheckItemQR.LargeGlyph;
                    barButtonItemType.LargeGlyph = barCheckItemQR.LargeGlyph;
                    barCheckItemUsingBarCodes.Glyph = barCheckItemQR.GlyphDisabled;
                    break;
                case BarCodeType.UPC_A:
                    SetChecked(barCheckItemUPC_A, true);
                    barButtonItemDocumentSeperation.LargeGlyph = barCheckItemUPC_A.LargeGlyph;
                    barButtonItemType.LargeGlyph = barCheckItemUPC_A.LargeGlyph;
                    barCheckItemUsingBarCodes.Glyph = barCheckItemUPC_A.GlyphDisabled;
                    break;
                case BarCodeType.UPC_E:
                    SetChecked(barCheckItemUPC_E, true);
                    barButtonItemDocumentSeperation.LargeGlyph = barCheckItemUPC_E.LargeGlyph;
                    barButtonItemType.LargeGlyph = barCheckItemUPC_E.LargeGlyph;
                    barCheckItemUsingBarCodes.Glyph = barCheckItemUPC_E.GlyphDisabled;
                    break;
            }
            if (autoSave)
            {
                SetChecked(barCheckItemUsingBarCodes, true);
                SetChecked(barButtonItemType, true);
                SetChecked(barButtonItemDocumentSeperation, true);
                appSetting.BarCode = barcode;
            }
        }
        
        private void SetBarCodeIndex(BarCodeType barcode, bool autoSave)
        {
            switch (barcode)
            {
                case BarCodeType.Aztec:
                    SetChecked(barCheckItemBarAztec, true);
                    barButtonItemDocumentSeperation.LargeGlyph = barCheckItemBarAztec.LargeGlyph;
                    barButtonItemType.LargeGlyph = barCheckItemBarAztec.LargeGlyph;
                    barCheckItemUsingBarCodes.Glyph = barCheckItemBarAztec.GlyphDisabled;
                    break;
                case BarCodeType.Codabar:
                    SetChecked(barCheckItemCodabar, true);
                    barButtonItemDocumentSeperation.LargeGlyph = barCheckItemCodabar.LargeGlyph;
                    barButtonItemType.LargeGlyph = barCheckItemCodabar.LargeGlyph;
                    barCheckItemUsingBarCodes.Glyph = barCheckItemCodabar.GlyphDisabled;
                    break;
                case BarCodeType.Code39:
                    SetChecked(barCheckItemCode39, true);
                    barButtonItemDocumentSeperation.LargeGlyph = barCheckItemCode39.LargeGlyph;
                    barButtonItemType.LargeGlyph = barCheckItemCode39.LargeGlyph;
                    barCheckItemUsingBarCodes.Glyph = barCheckItemCode39.GlyphDisabled;
                    break;
                case BarCodeType.Code93:
                    SetChecked(barCheckItemCode93, true);
                    barButtonItemDocumentSeperation.LargeGlyph = barCheckItemCode93.LargeGlyph;
                    barButtonItemType.LargeGlyph = barCheckItemCode93.LargeGlyph;
                    barCheckItemUsingBarCodes.Glyph = barCheckItemCode93.GlyphDisabled;
                    break;
                case BarCodeType.Code128:
                    SetChecked(barCheckItemCode128, true);
                    barButtonItemDocumentSeperation.LargeGlyph = barCheckItemCode128.LargeGlyph;
                    barButtonItemType.LargeGlyph = barCheckItemCode128.LargeGlyph;
                    barCheckItemUsingBarCodes.Glyph = barCheckItemCode128.GlyphDisabled;
                    break;
                case BarCodeType.DataMatrix:
                    SetChecked(barCheckItemDataMatrix, true);
                    barButtonItemDocumentSeperation.LargeGlyph = barCheckItemDataMatrix.LargeGlyph;
                    barButtonItemType.LargeGlyph = barCheckItemDataMatrix.LargeGlyph;
                    barCheckItemUsingBarCodes.Glyph = barCheckItemDataMatrix.GlyphDisabled;
                    break;
                case BarCodeType.EAN:
                    SetChecked(barCheckItemEAN, true);
                    barButtonItemDocumentSeperation.LargeGlyph = barCheckItemEAN.LargeGlyph;
                    barButtonItemType.LargeGlyph = barCheckItemEAN.LargeGlyph;
                    barCheckItemUsingBarCodes.Glyph = barCheckItemEAN.GlyphDisabled;
                    break;
                case BarCodeType.InterLeaved2of5:
                    SetChecked(barCheckItemInterLeaved2of5, true);
                    barButtonItemDocumentSeperation.LargeGlyph = barCheckItemInterLeaved2of5.LargeGlyph;
                    barButtonItemType.LargeGlyph = barCheckItemInterLeaved2of5.LargeGlyph;
                    barCheckItemUsingBarCodes.Glyph = barCheckItemInterLeaved2of5.GlyphDisabled;
                    break;
                case BarCodeType.PDF417:
                    SetChecked(barCheckItemPdf417, true);
                    barButtonItemDocumentSeperation.LargeGlyph = barCheckItemPdf417.LargeGlyph;
                    barButtonItemType.LargeGlyph = barCheckItemPdf417.LargeGlyph;
                    barCheckItemUsingBarCodes.Glyph = barCheckItemPdf417.GlyphDisabled;
                    break;
                case BarCodeType.PostNet:
                    SetChecked(barCheckItemPostNet, true);
                    barButtonItemDocumentSeperation.LargeGlyph = barCheckItemPostNet.LargeGlyph;
                    barButtonItemType.LargeGlyph = barCheckItemPostNet.LargeGlyph;
                    barCheckItemUsingBarCodes.Glyph = barCheckItemPostNet.GlyphDisabled;
                    break;
                case BarCodeType.QR:
                    SetChecked(barCheckItemQR, true);
                    barButtonItemDocumentSeperation.LargeGlyph = barCheckItemQR.LargeGlyph;
                    barButtonItemType.LargeGlyph = barCheckItemQR.LargeGlyph;
                    barCheckItemUsingBarCodes.Glyph = barCheckItemQR.GlyphDisabled;
                    break;
                case BarCodeType.UPC_A:
                    SetChecked(barCheckItemUPC_A, true);
                    barButtonItemDocumentSeperation.LargeGlyph = barCheckItemUPC_A.LargeGlyph;
                    barButtonItemType.LargeGlyph = barCheckItemUPC_A.LargeGlyph;
                    barCheckItemUsingBarCodes.Glyph = barCheckItemUPC_A.GlyphDisabled;
                    break;
                case BarCodeType.UPC_E:
                    SetChecked(barCheckItemUPC_E, true);
                    barButtonItemDocumentSeperation.LargeGlyph = barCheckItemUPC_E.LargeGlyph;
                    barButtonItemType.LargeGlyph = barCheckItemUPC_E.LargeGlyph;
                    barCheckItemUsingBarCodes.Glyph = barCheckItemUPC_E.GlyphDisabled;
                    break;
            }
            if (autoSave)
            {
                SetChecked(barCheckItemUsingBarCodes, true);
                SetChecked(barButtonItemType, true);
                SetChecked(barButtonItemDocumentSeperation, true);
                appSetting.BarCode = barcode;
            }
        }

        private void EnableDocumentSeperation(bool isChecked, bool autoSave)
        {
            SetChecked(barButtonItemDocumentSeperation, isChecked);
            SetChecked(barButtonItemType, isChecked);
            if (autoSave)
                appSetting.UseDocumentSeperation = isChecked;
        }

        private void SetWhenValueChanges(bool isChecked, bool autoSave)
        {
            SetChecked(barEditItemWhenValueChanges, isChecked);
            if (autoSave)
            {
                SetDocumentSeperation(DocumentSeparationMode.BarCode, autoSave);
                appSetting.WhenBarCodeChange = isChecked;
            }
        }

        private void SetDocumentSeperation(DocumentSeparationMode mode, bool autoSave)
        {
            switch (mode)
            {
                case DocumentSeparationMode.BarCode:
                    SetChecked(barCheckItemUsingBarCodes, true);
                    barButtonItemDocumentSeperation.LargeGlyph = barCheckItemUsingBarCodes.LargeGlyph;
                    break;
                case DocumentSeparationMode.PatchCode:
                    SetChecked(barCheckItemUsingPatchCodes, true);
                    barButtonItemDocumentSeperation.LargeGlyph = barCheckItemUsingPatchCodes.LargeGlyph;
                    break;
                case DocumentSeparationMode.BlankSheet:
                    SetChecked(barCheckItemUsingBlankSheets, true);
                    barButtonItemDocumentSeperation.LargeGlyph = barCheckItemUsingBlankSheets.LargeGlyph;
                    break;
                case DocumentSeparationMode.EveryNSheets:
                    SetChecked(barCheckItemEveryNSheets, true);
                    barButtonItemDocumentSeperation.LargeGlyph = barCheckItemEveryNSheets.LargeGlyph;
                    break;
            }
            if (autoSave)
            {
                EnableDocumentSeperation(true, true);
                appSetting.DocumentSeparation = mode;
            }
        }

        private void LoadPerfomance(bool isAdvance)
        {
            gridControl2.DataSource = _listPerformances.Where(p => !p.IsAdvance || isAdvance).ToList();
        }

        private void LoadBatch()
        {
            gridControl1.DataSource = listBatch;
        }


        private void SetScanSettingMode(ScanSettingMode mode, bool autoSave)
        {
            bool modeScanner = mode == ScanSettingMode.Scanner;
            bool modeVRSColor = mode == ScanSettingMode.VRSColor;
            bool modeVRSGeneral = mode == ScanSettingMode.VRSGeneral;

            SetChecked(barButtonItemScanner, modeScanner);
            SetChecked(barButtonItemVRSColor, modeVRSColor);
            SetChecked(barButtonItemVRSGeneral, modeVRSGeneral);

            ScannerGroups.ForEach(p => p.Visible = modeScanner);
            VRSGeneralGroups.ForEach(p => p.Visible = modeVRSGeneral);
            VRSColorGroups.ForEach(p => p.Visible = modeVRSColor);
            if (autoSave)
                scanProfile.CurrentScanSettingMode = mode;
        }

        private void SetColorSettingMode(ColorMode mode, bool autoSave)
        {
            bool modeBlackAndWhite = mode == ColorMode.BlackAndWhite;
            bool modeGrayscale = mode == ColorMode.Grayscale;
            bool modeColor = mode == ColorMode.Color;

            SetChecked(barButtonItemBlackAndWhite, modeBlackAndWhite);
            SetChecked(barButtonItemGrayscale, modeGrayscale);
            SetChecked(barButtonItemColor, modeColor);
            if (modeColor)
                EnableModeColor();
            else if (modeGrayscale)
                EnableModeGrayscale();
            else if (modeBlackAndWhite)
                EnableModeBlackAndWhiteColor();
            if (autoSave)
                scanProfile.CurrentColorMode = mode;

            BrightnessValueChanged(scanProfile.Brightness, false);
            ContrastValueChanged(scanProfile.Contrast, false);
            GammaValueChanged(scanProfile.Gamma, false);
            SetEnable(barButtonItemSmoothing, scanProfile.CurrentColorMode != ColorMode.BlackAndWhite);
            SetEnable(barEditItemSmoothingTrackBar, scanProfile.CurrentColorMode != ColorMode.BlackAndWhite);
            SetEnable(barStaticItemSmoothing, scanProfile.CurrentColorMode != ColorMode.BlackAndWhite);
            SetEnable(barEditItemSmoothingValue, scanProfile.CurrentColorMode != ColorMode.BlackAndWhite);
        }

        private void SetAutoBrightness(bool isChecked, bool autoSave)
        {
            SetChecked(barEditItemAutoBrightness, isChecked);
            if (!scanProfile.AdvanceClarity || scanProfile.CurrentColorMode == ColorMode.Grayscale)
            {
                SetEnable(barEditItemBrightness, !isChecked);
                SetEnable(barEditItemBrightnessValue, !isChecked);
            }
            if (scanProfile.CurrentColorMode == ColorMode.Grayscale)
            {
                SetEnable(barEditItemContrast, !isChecked);
                SetEnable(barEditItemContrastValue, !isChecked);
                SetEnable(barEditItemGamma, !isChecked);
                SetEnable(barEditItemGammaValue, !isChecked);
            }
            if (autoSave)
                scanProfile.AutoBrightness = isChecked;
        }

        private void SetAdvancedClarity(bool isChecked, bool autoSave)
        {
            SetChecked(barEditItemAdvancedClarity, isChecked);
            SetEnable(barButtonItemAdvancedClaritySetup,
                      isChecked && scanProfile.CurrentColorMode == ColorMode.BlackAndWhite);
            SetEnable(barEditItemClarityValue, isChecked && scanProfile.CurrentColorMode == ColorMode.BlackAndWhite);
            SetEnable(barStaticItemHight, isChecked && scanProfile.CurrentColorMode == ColorMode.BlackAndWhite);

            SetEnable(barEditItemBrightness, !isChecked && !scanProfile.AutoBrightness);
            SetEnable(barEditItemBrightnessValue, !isChecked && !scanProfile.AutoBrightness);
            SetEnable(barEditItemContrast, !isChecked);
            SetEnable(barEditItemContrastValue, !isChecked);
            if (autoSave)
                scanProfile.AdvanceClarity = isChecked;
        }

        private void SetAdvancedClarityValue(int value, bool autoSave)
        {
            barEditItemClarityValue.EditValue = value;
            if (autoSave)
                scanProfile.AdvanceClarityValue = value;
        }

        private void SetThicknessValue(int value, bool autoSave)
        {
            barEditItemThickness.EditValue = value;
            if (autoSave)
                scanProfile.Thickness = value;
        }

        private void SetSpeckleValue(int value, bool autoSave)
        {
            barEditItemSpeckle.EditValue = value;
            if (autoSave)
                scanProfile.Speckle = value;
        }

        private void SetBlankContentSensitivityValue(int value, bool autoSave)
        {
            barEditItemTrackBarBlankContentSensitivityValue.EditValue = value;
            barEditItemBlankContentSensitivityValue.EditValue = value;
            if (autoSave)
            {
                scanProfile.BlankContentSensitivity = value;
                SetDeleteBlank(true, true);
            }
        }

        private void SetIgnoreHole(bool isChecked, bool autoSave)
        {
            SetChecked(barCheckItemIgnoreHole, isChecked);
            if (autoSave)
            {
                scanProfile.IgnoreHolePunches = isChecked;
                SetDeleteBlank(true, true);
            }
        }

        private void EnableModeBlackAndWhiteColor()
        {
            SetEnable(barEditItemBrightness, !scanProfile.AutoBrightness && !scanProfile.AdvanceClarity);
            SetEnable(barEditItemBrightnessValue, !scanProfile.AutoBrightness && !scanProfile.AdvanceClarity);
            SetEnable(barEditItemContrast, !scanProfile.AdvanceClarity);
            SetEnable(barEditItemContrastValue, !scanProfile.AdvanceClarity);
            SetEnable(barEditItemGamma, true);
            SetEnable(barEditItemGammaValue, true);
            SetEnable(barEditItemAutoBrightness, true);
            SetEnable(barEditItemAdvancedClarity, true);

            SetEnable(barEditItemClarityValue, scanProfile.AdvanceClarity);
            SetEnable(barStaticItemHight, scanProfile.AdvanceClarity);
            SetEnable(barButtonItemAdvancedClaritySetup, scanProfile.AdvanceClarity);

            SetEnable(barEditItemThickness, true);
            SetEnable(barStaticItemThickness, true);
            SetEnable(barEditItemSpeckle, true);
            SetEnable(barStaticItemSpeckle, true);
        }

        private void EnableModeGrayscale()
        {
            SetEnable(barEditItemBrightness, !scanProfile.AutoBrightness);
            SetEnable(barEditItemBrightnessValue, !scanProfile.AutoBrightness);
            SetEnable(barEditItemContrast, !scanProfile.AutoBrightness);
            SetEnable(barEditItemContrastValue, !scanProfile.AutoBrightness);
            SetEnable(barEditItemGamma, !scanProfile.AutoBrightness);
            SetEnable(barEditItemGammaValue, !scanProfile.AutoBrightness);

            SetEnable(barEditItemAutoBrightness, true);
            SetEnable(barEditItemAdvancedClarity, false);
            SetEnable(barEditItemClarityValue, false);
            SetEnable(barStaticItemHight, false);
            SetEnable(barButtonItemAdvancedClaritySetup, false);

            SetEnable(barEditItemThickness, false);
            SetEnable(barStaticItemThickness, false);
            SetEnable(barEditItemSpeckle, false);
            SetEnable(barStaticItemSpeckle, false);
        }

        private void EnableModeColor()
        {
            //SetChecked(barButtonItemColor, true);

            SetEnable(barEditItemBrightness, true);
            SetEnable(barEditItemBrightnessValue, true);
            SetEnable(barEditItemContrast, true);
            SetEnable(barEditItemContrastValue, true);
            SetEnable(barEditItemGamma, true);
            SetEnable(barEditItemGammaValue, true);

            SetEnable(barEditItemAutoBrightness, false);
            SetEnable(barEditItemAdvancedClarity, false);
            SetEnable(barEditItemClarityValue, false);
            SetEnable(barStaticItemHight, false);
            SetEnable(barButtonItemAdvancedClaritySetup, false);
            SetEnable(barEditItemAdvancedClarity, false);
            SetEnable(barEditItemThickness, false);
            SetEnable(barStaticItemThickness, false);
            SetEnable(barEditItemSpeckle, false);
            SetEnable(barStaticItemSpeckle, false);
        }

        private void SetResolution(int value, bool autoSave)
        {
            barEditItem2.EditValue = value;
            if (autoSave)
                scanProfile.ResolutionValue = value;
        }

        private void SetFeederMode(FeederMode mode, bool autoSave)
        {
            bool flatbedMode = mode == FeederMode.Flatbed;
            bool feederMode = mode == FeederMode.Feerder;

            SetChecked(barButtonItemFeeder, feederMode);
            SetChecked(barButtonItemFlatbed, flatbedMode);
            SetEnable(barButtonItemBothSides, feederMode);
            if (autoSave)
                scanProfile.CurrentFeeder = mode;

            if (flatbedMode)
                SetSides(Sides.OneSide, autoSave);
            else if (feederMode && tempSides != null)
                SetSides(Sides.BothSides, autoSave);
        }

        private void SetSides(Sides mode, bool autoSave)
        {
            if (mode == Sides.OneSide && scanProfile.CurrentFeeder == FeederMode.Flatbed &&
                scanProfile.CurrentSides == Sides.BothSides)
                tempSides = Sides.BothSides;
            else
                tempSides = null;
            SetChecked(barButtonItemOneSide, mode == Sides.OneSide);
            SetChecked(barButtonItemBothSides, mode == Sides.BothSides);
            SetVisible(barButtonItemBack, mode == Sides.BothSides);
            if (autoSave)
                scanProfile.CurrentSides = mode;
        }

        private void SetPaperSize(string size, bool autoSave)
        {
            barEditItemSize.EditValue = size;
            if (autoSave)
                scanProfile.CurrentPaperSizeValue = size;
        }

        private void SetOrientation(Orientation mode, bool autoSave)
        {
            bool modeLandscape = mode == Orientation.Landscape;
            bool modePortrait = mode == Orientation.Portrait;
            SetChecked(barButtonItemLandscape, modeLandscape);
            SetChecked(barButtonItemPortrait, modePortrait);
            if (autoSave)
                scanProfile.CurrentOrientation = mode;
        }

        private void BrightnessValueChanged(int value, bool autoSave)
        {
            barEditItemBrightness.EditValue = value;
            barEditItemBrightnessValue.EditValue = value;
            if (autoSave)
                scanProfile.Brightness = value;
        }

        private void ContrastValueChanged(int value, bool autoSave)
        {
            barEditItemContrast.EditValue = value;
            barEditItemContrastValue.EditValue = value;
            if (autoSave)
                scanProfile.Contrast = value;
        }

        private void GammaValueChanged(int value, bool autoSave)
        {
            barEditItemGamma.EditValue = value;
            barEditItemGammaValue.EditValue = value;
            if (autoSave)
                scanProfile.Gamma = value;
        }

        private void SetRotationFront(Rotation rotation, bool autoSave)
        {
            if (rotation == Rotation.Rotate0)
            {
                SetChecked(barCheckItemFront0, true);
                barButtonItemFront.Glyph = barCheckItemFront0.Glyph;
                barButtonItemFront.LargeGlyph = barCheckItemFront0.Glyph;
            }
            else if (rotation == Rotation.Rotate90Left)
            {
                SetChecked(barCheckItemFront90Left, true);
                barButtonItemFront.Glyph = barCheckItemFront90Left.Glyph;
                barButtonItemFront.LargeGlyph = barCheckItemFront90Left.Glyph;
            }
            else if (rotation == Rotation.Rotate90Right)
            {
                SetChecked(barCheckItemFront90Right, true);
                barButtonItemFront.Glyph = barCheckItemFront90Right.Glyph;
                barButtonItemFront.LargeGlyph = barCheckItemFront90Right.Glyph;
            }
            else if (rotation == Rotation.Rotate180)
            {
                SetChecked(barCheckItemFront180, true);
                barButtonItemFront.Glyph = barCheckItemFront180.Glyph;
                barButtonItemFront.LargeGlyph = barCheckItemFront180.Glyph;
            }
            scanProfile.FontRotation = rotation;

            SetRotationBack(rotation, autoSave);
        }

        private void SetRotationBack(Rotation rotation, bool autoSave)
        {
            if (rotation == Rotation.Rotate0)
            {
                SetChecked(barCheckItemBack0, true);
                barButtonItemBack.Glyph = barCheckItemBack0.Glyph;
                barButtonItemBack.LargeGlyph = barCheckItemBack0.Glyph;
            }
            else if (rotation == Rotation.Rotate90Left)
            {
                SetChecked(barCheckItemBack90Left, true);
                barButtonItemBack.Glyph = barCheckItemBack90Left.Glyph;
                barButtonItemBack.LargeGlyph = barCheckItemBack90Left.Glyph;
            }
            else if (rotation == Rotation.Rotate90Right)
            {
                SetChecked(barCheckItemBack90Right, true);
                barButtonItemBack.Glyph = barCheckItemBack90Right.Glyph;
                barButtonItemBack.LargeGlyph = barCheckItemBack90Right.Glyph;
            }
            else if (rotation == Rotation.Rotate180)
            {
                SetChecked(barCheckItemBack180, true);
                barButtonItemBack.Glyph = barCheckItemBack180.Glyph;
                barButtonItemBack.LargeGlyph = barCheckItemBack180.Glyph;
            }
            if (autoSave)
                scanProfile.BackRotation = rotation;
        }

        private void SetOutOfPaperResolve(bool isChecked, bool autoSave)
        {
            SetChecked(barCheckItemOutOfPaper, isChecked);
            if (autoSave)
                scanProfile.OutOfPaperAutoResolve = isChecked;
        }

        private void SetPaperJamResolve(bool isChecked, bool autoSave)
        {
            SetChecked(barCheckItemPaperJam, isChecked);
            if (autoSave)
                scanProfile.PaperJamAutoResolve = isChecked;
        }

        private void SetCoverOpenResolve(bool isChecked, bool autoSave)
        {
            SetChecked(barCheckItemCoverOpen, isChecked);
            if (autoSave)
                scanProfile.CoverOpenAutoResolve = isChecked;
        }

        private void SetMultilFeedResolve(bool isChecked, bool autoSave)
        {
            SetChecked(barCheckItemMultifeed, isChecked);
            if (autoSave)
                scanProfile.MultiFeedAutoResolve = isChecked;
        }

        private void DeskewChangedState(bool isChecked, bool autoSave)
        {
            barButtonItemDeskew.Down
                = barButtonItemAutoCrop.Enabled
                  = barButtonItemEdgeCleanup.Enabled
                    = barButtonItemAutoRotate.Enabled
                      = isChecked;
            if (autoSave)
                scanProfile.Desknew = isChecked;
        }

        private void AutoCropChangedState(bool isChecked, bool autoSave)
        {
            SetChecked(barButtonItemAutoCrop, isChecked);
            if (autoSave)
                scanProfile.AutoCrop = isChecked;
        }

        private void SetEdgeCleanup(bool isChecked, bool autoSave)
        {
            SetChecked(barButtonItemEdgeCleanup, isChecked);
            if (autoSave)
                scanProfile.EdgeCleanup = isChecked;
        }

        private void SetHolePunchRemoval(bool isChecked, bool autoSave)
        {
            SetChecked(barButtonItemHolePunchRemoval, isChecked);
            if (autoSave)
                scanProfile.RemoveHole = isChecked;
        }

        private void SetDeleteBlank(bool isChecked, bool autoSave)
        {
            SetChecked(barButtonItemDeleteBlank, isChecked);
            if (autoSave)
                scanProfile.DeleteBlank = isChecked;
        }

        private void SetAutoRotate(bool isChecked, bool autoSave)
        {
            SetChecked(barButtonItemAutoRotate, isChecked);
            if (autoSave)
                scanProfile.AutoRotate = isChecked;
        }

        private void SetDetectColor(bool isCheck, bool autoSave)
        {
            SetChecked(barButtonItemDetectColor, isCheck);
            if (isCheck)
            {
                tempColorMode = scanProfile.CurrentColorMode;
                SetColorSettingMode(ColorMode.Color, true);
            }
            else if (autoSave)
            {
                SetColorSettingMode(tempColorMode, true);
            }
            SetEnable(barButtonItemDetectSmallColorObjects, isCheck);
            SetEnable(barEditItemOverall, isCheck);
            SetEnable(barEditItemSensitivity, isCheck);
            SetEnable(barEditItemOverallValue, isCheck);
            SetEnable(barEditItemSensitivityValue, isCheck);
            SetEnable(barStaticItemOverall, isCheck);
            SetEnable(barStaticItemSensitivity, isCheck);

            SetEnable(barButtonItemBlackAndWhite, !isCheck);
            SetEnable(barButtonItemGrayscale, !isCheck);
            SetEnable(barButtonItemColor, !isCheck);

            SetEnable(barButtonItemSmoothing, !isCheck && scanProfile.CurrentColorMode != ColorMode.BlackAndWhite);
            SetEnable(barEditItemSmoothingTrackBar, !isCheck && scanProfile.CurrentColorMode != ColorMode.BlackAndWhite);
            SetEnable(barStaticItemSmoothing, !isCheck && scanProfile.CurrentColorMode != ColorMode.BlackAndWhite);
            SetEnable(barEditItemSmoothingValue, !isCheck && scanProfile.CurrentColorMode != ColorMode.BlackAndWhite);

            if (autoSave)
                scanProfile.DetectColor = isCheck;
        }

        private void SetSmoothing(bool isCheck, bool autoSave)
        {
            SetChecked(barButtonItemSmoothing, isCheck);

            SetEnable(barEditItemSmoothingTrackBar, isCheck);
            SetEnable(barStaticItemSmoothing, isCheck);
            SetEnable(barEditItemSmoothingValue, isCheck);

            if (autoSave)
                scanProfile.Smoothing = isCheck;
        }


        private void SetIndexingMode(bool isChecked)
        {
            ribbonPageGroupZonalOCR.Visible = isChecked;
            SetEnable(barButtonItemNewBatch, !isChecked);
            SetEnable(barButtonItemScanOne, !isChecked);
            SetEnable(barButtonItemScanAll, !isChecked);
            SetEnable(barButtonItemNewDocument, !isChecked);
            SetEnable(barButtonItemSplitDocument, !isChecked);


            SetVisible(barEditItemScanProfile, !isChecked);
            SetVisible(barButtonItemNewScanProfile, !isChecked);
            SetVisible(barButtonItemSaveScanProfile, !isChecked);
            SetVisible(barButtonItemSaveScanProfileAs, !isChecked);
            SetVisible(barButtonItemRenameScanProfile, !isChecked);
            SetVisible(barButtonItemDeleteScanProfile, !isChecked);
            SetVisible(barButtonItemIndexFristDocument, isChecked);
            SetVisible(barButtonItemPreviousDocument, isChecked);
            SetVisible(barButtonItemNextDocument, isChecked);
            SetVisible(barButtonItemLastDocument, isChecked);
            SetVisible(barButtonItemNextIncomplete, isChecked);

            SetViewerType(isChecked ? ViewerType.Single : appSetting.CurrentViewType, false);
        }

        private void SetViewerType(ViewerType type, bool autoSave)
        {
            bool isCompact = type == ViewerType.CompactThumbnail;
            bool isThumbnail = type == ViewerType.Thumbnail;
            bool isSingle = type == ViewerType.Single;
            SetChecked(barButtonItemCompactThumbnailView, isCompact);
            SetChecked(barButtonItemThumbnailView, isThumbnail);
            SetChecked(barButtonItemSingleView, isSingle);
            SetVisible(barButtonItemZoom, isSingle);
            SetVisible(barButtonItemPan, isSingle);
            SetVisible(barButtonItemDrawZone, isSingle && barButtonItemIndexing.Down);
            SetVisible(barButtonItemPageFit, isSingle);
            SetVisible(barButtonItemHorizontalFit, isSingle);
            SetVisible(barButtonItemVerticalFit, isSingle);
            SetVisible(barButtonItem100View, isSingle);
            ribbonStatusBar.Refresh();
            if (autoSave)
                appSetting.CurrentViewType = type;
        }

        private void SetCursorType(CursorType type)
        {
            bool isZoom = type == CursorType.Zoom;
            bool isPan = type == CursorType.Pan;
            bool isDraw = type == CursorType.Draw;
            SetChecked(barButtonItemZoom, isZoom);
            SetChecked(barButtonItemPan, isPan);
            SetChecked(barButtonItemDrawZone, isDraw);
        }


        private void SetFitType(FitType type, bool autoSave)
        {
            bool isPageFit = type == FitType.Page;
            bool isHorizonal = type == FitType.Horizonal;
            bool isVertical = type == FitType.Vertical;
            bool isView100 = type == FitType.View100;
            SetChecked(barButtonItemPageFit, isPageFit);
            SetChecked(barButtonItemHorizontalFit, isHorizonal);
            SetChecked(barButtonItemVerticalFit, isVertical);
            SetChecked(barButtonItem100View, isView100);
            if (autoSave)
                appSetting.CurrentFitType = type;
        }

        private void SetZoomValue(int value, bool autoSave)
        {
            barEditItemZoomTrackBar.Caption = value.ToString().PadLeft(5) + " %";
            barEditItemZoomTrackBar.EditValue = value;
            if (autoSave)
                appSetting.CurrentZoomValue = value;
        }

        private void SetAnalyzeColor(bool isChecked, bool autoSave)
        {
            SetChecked(barCheckItemAnalyzeColor, isChecked);
            if (autoSave)
                scanProfile.AnalyzeColor = isChecked;
        }

        private void SetIgnorePicture(bool isChecked, bool autoSave)
        {
            SetChecked(barCheckItemIgnorePicture, isChecked);
            if (autoSave)
                scanProfile.IgnorePicture = isChecked;
        }

        private void SetRawImageType(RawImageType type, bool autoSave)
        {
            if (type == RawImageType.Color)
            {
                SetChecked(barButtonItemRawColorColor, true);
                barButtonItemRawColor.LargeGlyph = barButtonItemRawColorColor.Glyph;
                barButtonItemRawColor.Caption = barButtonItemRawColorColor.Caption;
            }
            else if (type == RawImageType.Grayscale)
            {
                SetChecked(barCheckItemRawColorGrayscale, true);
                barButtonItemRawColor.LargeGlyph = barCheckItemRawColorGrayscale.Glyph;
                barButtonItemRawColor.Caption = barCheckItemRawColorGrayscale.Caption;
            }
            else if (type == RawImageType.Off)
            {
                SetChecked(barCheckItemRawColorOff, true);
                barButtonItemRawColor.LargeGlyph = barCheckItemRawColorOff.Glyph;
                barButtonItemRawColor.Caption = barCheckItemRawColorOff.Caption;
            }
            if (autoSave)
                appSetting.RawImageType = type;
        }
        private void SetDeleteFirstPage(bool isChecked, bool autoSave)
        {
            SetChecked(barEditItemDeleteFirstPage,isChecked);
            if (autoSave)
                appSetting.IsDeleteFirstPage = isChecked;
        }
        private void SetDeleteBatchAfterExport(bool isChecked, bool autoSave)
        {
            SetChecked(barEditItemDeleteAfterExport, isChecked);
            if (autoSave)
                appSetting.IsDeleteBatchAfterExport = isChecked;
        }  
        private void SetCreateNewBatchAfterExport(bool isChecked, bool autoSave)
        {
            SetChecked(barEditItemCreateNewBatchAfterExport, isChecked);
            if (autoSave)
                appSetting.IsCreateNewBatchAfterExport = isChecked;
        }   
        private void SetBackgroundExport(bool isChecked, bool autoSave)
        {
            SetChecked(barEditItemBackgroundExport, isChecked);
            if (autoSave)
                appSetting.IsBackgroundExport = isChecked;
        }
    }

}
