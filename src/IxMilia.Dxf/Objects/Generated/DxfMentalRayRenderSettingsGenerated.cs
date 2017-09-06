// Copyright (c) IxMilia.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

// The contents of this file are automatically generated by a tool, and should not be directly modified.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using IxMilia.Dxf.Collections;
using IxMilia.Dxf.Entities;

namespace IxMilia.Dxf.Objects
{
    /// <summary>
    /// DxfMentalRayRenderSettings class
    /// </summary>
    public partial class DxfMentalRayRenderSettings : DxfObject
    {
        public override DxfObjectType ObjectType { get { return DxfObjectType.MentalRayRenderSettings; } }
        protected override DxfAcadVersion MinVersion { get { return DxfAcadVersion.R2007; } }
        public int ClassVersion_1 { get; set; }
        public string PresetName { get; set; }
        public bool RenderMaterials { get; set; }
        public int TextureSamplingQuality { get; set; }
        public bool RenderBackFaces { get; set; }
        public bool RenderShadows { get; set; }
        public string PreviewFileName { get; set; }
        public int ClassVersion_2 { get; set; }
        public int MinimumSamplingRate { get; set; }
        public int MaximumSamplingRate { get; set; }
        public DxfSamplingFilterType SamplingFilterType { get; set; }
        public double FilterWidth { get; set; }
        public double FilterHeight { get; set; }
        public double SamplingContrastColor_Red { get; set; }
        public double SamplingContrastColor_Green { get; set; }
        public double SamplingContrastColor_Blue { get; set; }
        public double SamplingContrastColor_Alpha { get; set; }
        public DxfRenderShadowMode ShadowMode { get; set; }
        public bool MapShadows { get; set; }
        public bool RayTracing { get; set; }
        public int RayTracingDepth_Reflections { get; set; }
        public int RayTracingDepth_Refractions { get; set; }
        public int RayTracingDepth_Maximum { get; set; }
        public bool UseGlobalIllumination { get; set; }
        public int SampleCount { get; set; }
        public bool UseGlobalIlluminationRadius { get; set; }
        public double GlobalIlluminationRadius { get; set; }
        public int PhotonsPerLight { get; set; }
        public int GlobalIlluminationDepth_Reflections { get; set; }
        public int GlobalIlluminationDepth_Refractions { get; set; }
        public int GlobalIlluminationDepth_Maximum { get; set; }
        public bool UseFinalGather { get; set; }
        public int FinalGatherRayCount { get; set; }
        public bool UseFinalGatherMinimumRadius { get; set; }
        public bool UseFinalGatherMaximumRadius { get; set; }
        public bool UseFinalGatherPixels { get; set; }
        public double FinalGatherSampleRadius_Minimum { get; set; }
        public double FinalGatherSampleRadius_Maximum { get; set; }
        public double LuminanceScale { get; set; }
        public DxfRenderDiagnosticMode DiagnosticMode { get; set; }
        public DxfRenderDiagnosticGridMode DiagnosticGridMode { get; set; }
        public double GridSize { get; set; }
        public DxfDiagnosticPhotonMode DiagnosticPhotonMode { get; set; }
        public DxfDiagnosticBSPMode DiagnosticBSPMode { get; set; }
        public bool ExportMIStatistics { get; set; }
        public string MIStatisticsFileName { get; set; }
        public int TileSize { get; set; }
        public DxfTileOrder TileOrder { get; set; }
        public int MemoryLimit { get; set; }

        public DxfMentalRayRenderSettings()
            : base()
        {
        }

        protected override void Initialize()
        {
            base.Initialize();
            this.ClassVersion_1 = 1;
            this.PresetName = null;
            this.RenderMaterials = false;
            this.TextureSamplingQuality = 0;
            this.RenderBackFaces = false;
            this.RenderShadows = false;
            this.PreviewFileName = null;
            this.ClassVersion_2 = 1;
            this.MinimumSamplingRate = 0;
            this.MaximumSamplingRate = 0;
            this.SamplingFilterType = DxfSamplingFilterType.Box;
            this.FilterWidth = 0.0;
            this.FilterHeight = 0.0;
            this.SamplingContrastColor_Red = 0.0;
            this.SamplingContrastColor_Green = 0.0;
            this.SamplingContrastColor_Blue = 0.0;
            this.SamplingContrastColor_Alpha = 0.0;
            this.ShadowMode = DxfRenderShadowMode.Simple;
            this.MapShadows = false;
            this.RayTracing = false;
            this.RayTracingDepth_Reflections = 0;
            this.RayTracingDepth_Refractions = 0;
            this.RayTracingDepth_Maximum = 0;
            this.UseGlobalIllumination = false;
            this.SampleCount = 0;
            this.UseGlobalIlluminationRadius = false;
            this.GlobalIlluminationRadius = 0.0;
            this.PhotonsPerLight = 0;
            this.GlobalIlluminationDepth_Reflections = 0;
            this.GlobalIlluminationDepth_Refractions = 0;
            this.GlobalIlluminationDepth_Maximum = 0;
            this.UseFinalGather = false;
            this.FinalGatherRayCount = 0;
            this.UseFinalGatherMinimumRadius = false;
            this.UseFinalGatherMaximumRadius = false;
            this.UseFinalGatherPixels = false;
            this.FinalGatherSampleRadius_Minimum = 0.0;
            this.FinalGatherSampleRadius_Maximum = 0.0;
            this.LuminanceScale = 1.0;
            this.DiagnosticMode = DxfRenderDiagnosticMode.Off;
            this.DiagnosticGridMode = DxfRenderDiagnosticGridMode.Object;
            this.GridSize = 1.0;
            this.DiagnosticPhotonMode = DxfDiagnosticPhotonMode.Density;
            this.DiagnosticBSPMode = DxfDiagnosticBSPMode.Depth;
            this.ExportMIStatistics = false;
            this.MIStatisticsFileName = null;
            this.TileSize = 0;
            this.TileOrder = DxfTileOrder.Hilbert;
            this.MemoryLimit = 0;
        }

        protected override void AddValuePairs(List<DxfCodePair> pairs, DxfAcadVersion version, bool outputHandles)
        {
            base.AddValuePairs(pairs, version, outputHandles);
            pairs.Add(new DxfCodePair(100, "AcDbRenderSettings"));
            pairs.Add(new DxfCodePair(90, (this.ClassVersion_1)));
            pairs.Add(new DxfCodePair(1, (this.PresetName)));
            pairs.Add(new DxfCodePair(290, (this.RenderMaterials)));
            pairs.Add(new DxfCodePair(90, (this.TextureSamplingQuality)));
            pairs.Add(new DxfCodePair(290, (this.RenderBackFaces)));
            pairs.Add(new DxfCodePair(290, (this.RenderShadows)));
            pairs.Add(new DxfCodePair(1, (this.PreviewFileName)));
            pairs.Add(new DxfCodePair(100, "AcDbMentalRayRenderSettings"));
            pairs.Add(new DxfCodePair(90, (this.ClassVersion_2)));
            pairs.Add(new DxfCodePair(90, (this.MinimumSamplingRate)));
            pairs.Add(new DxfCodePair(90, (this.MaximumSamplingRate)));
            pairs.Add(new DxfCodePair(70, (short)(this.SamplingFilterType)));
            pairs.Add(new DxfCodePair(40, (this.FilterWidth)));
            pairs.Add(new DxfCodePair(40, (this.FilterHeight)));
            pairs.Add(new DxfCodePair(40, (this.SamplingContrastColor_Red)));
            pairs.Add(new DxfCodePair(40, (this.SamplingContrastColor_Green)));
            pairs.Add(new DxfCodePair(40, (this.SamplingContrastColor_Blue)));
            pairs.Add(new DxfCodePair(40, (this.SamplingContrastColor_Alpha)));
            pairs.Add(new DxfCodePair(70, (short)(this.ShadowMode)));
            pairs.Add(new DxfCodePair(290, (this.MapShadows)));
            pairs.Add(new DxfCodePair(290, (this.RayTracing)));
            pairs.Add(new DxfCodePair(90, (this.RayTracingDepth_Reflections)));
            pairs.Add(new DxfCodePair(90, (this.RayTracingDepth_Refractions)));
            pairs.Add(new DxfCodePair(90, (this.RayTracingDepth_Maximum)));
            pairs.Add(new DxfCodePair(290, (this.UseGlobalIllumination)));
            pairs.Add(new DxfCodePair(90, (this.SampleCount)));
            pairs.Add(new DxfCodePair(290, (this.UseGlobalIlluminationRadius)));
            pairs.Add(new DxfCodePair(40, (this.GlobalIlluminationRadius)));
            pairs.Add(new DxfCodePair(90, (this.PhotonsPerLight)));
            pairs.Add(new DxfCodePair(90, (this.GlobalIlluminationDepth_Reflections)));
            pairs.Add(new DxfCodePair(90, (this.GlobalIlluminationDepth_Refractions)));
            pairs.Add(new DxfCodePair(90, (this.GlobalIlluminationDepth_Maximum)));
            pairs.Add(new DxfCodePair(290, (this.UseFinalGather)));
            pairs.Add(new DxfCodePair(90, (this.FinalGatherRayCount)));
            pairs.Add(new DxfCodePair(290, (this.UseFinalGatherMinimumRadius)));
            pairs.Add(new DxfCodePair(290, (this.UseFinalGatherMaximumRadius)));
            pairs.Add(new DxfCodePair(290, (this.UseFinalGatherPixels)));
            pairs.Add(new DxfCodePair(40, (this.FinalGatherSampleRadius_Minimum)));
            pairs.Add(new DxfCodePair(40, (this.FinalGatherSampleRadius_Maximum)));
            pairs.Add(new DxfCodePair(40, (this.LuminanceScale)));
            pairs.Add(new DxfCodePair(70, (short)(this.DiagnosticMode)));
            pairs.Add(new DxfCodePair(70, (short)(this.DiagnosticGridMode)));
            pairs.Add(new DxfCodePair(40, (this.GridSize)));
            pairs.Add(new DxfCodePair(70, (short)(this.DiagnosticPhotonMode)));
            pairs.Add(new DxfCodePair(70, (short)(this.DiagnosticBSPMode)));
            pairs.Add(new DxfCodePair(290, (this.ExportMIStatistics)));
            pairs.Add(new DxfCodePair(1, (this.MIStatisticsFileName)));
            pairs.Add(new DxfCodePair(90, (this.TileSize)));
            pairs.Add(new DxfCodePair(70, (short)(this.TileOrder)));
            pairs.Add(new DxfCodePair(90, (this.MemoryLimit)));
        }

        // This object has vales that share codes between properties and these counters are used to know which property to
        // assign to in TrySetPair() below.
        private int _code_1_index = 0; // shared by properties PresetName, PreviewFileName, MIStatisticsFileName
        private int _code_40_index = 0; // shared by properties FilterWidth, FilterHeight, SamplingContrastColor_Red, SamplingContrastColor_Green, SamplingContrastColor_Blue, SamplingContrastColor_Alpha, GlobalIlluminationRadius, FinalGatherSampleRadius_Minimum, FinalGatherSampleRadius_Maximum, LuminanceScale, GridSize
        private int _code_70_index = 0; // shared by properties SamplingFilterType, ShadowMode, DiagnosticMode, DiagnosticGridMode, DiagnosticPhotonMode, DiagnosticBSPMode, TileOrder
        private int _code_90_index = 0; // shared by properties ClassVersion_1, TextureSamplingQuality, ClassVersion_2, MinimumSamplingRate, MaximumSamplingRate, RayTracingDepth_Reflections, RayTracingDepth_Refractions, RayTracingDepth_Maximum, SampleCount, PhotonsPerLight, GlobalIlluminationDepth_Reflections, GlobalIlluminationDepth_Refractions, GlobalIlluminationDepth_Maximum, FinalGatherRayCount, TileSize, MemoryLimit
        private int _code_290_index = 0; // shared by properties RenderMaterials, RenderBackFaces, RenderShadows, MapShadows, RayTracing, UseGlobalIllumination, UseGlobalIlluminationRadius, UseFinalGather, UseFinalGatherMinimumRadius, UseFinalGatherMaximumRadius, UseFinalGatherPixels, ExportMIStatistics

        internal override bool TrySetPair(DxfCodePair pair)
        {
            switch (pair.Code)
            {
                case 1:
                    switch (_code_1_index)
                    {
                        case 0:
                            this.PresetName = (pair.StringValue);
                            _code_1_index++;
                            break;
                        case 1:
                            this.PreviewFileName = (pair.StringValue);
                            _code_1_index++;
                            break;
                        case 2:
                            this.MIStatisticsFileName = (pair.StringValue);
                            _code_1_index++;
                            break;
                        default:
                            Debug.Assert(false, "Unexpected extra values for code 1");
                            break;
                    }
                    break;
                case 40:
                    switch (_code_40_index)
                    {
                        case 0:
                            this.FilterWidth = (pair.DoubleValue);
                            _code_40_index++;
                            break;
                        case 1:
                            this.FilterHeight = (pair.DoubleValue);
                            _code_40_index++;
                            break;
                        case 2:
                            this.SamplingContrastColor_Red = (pair.DoubleValue);
                            _code_40_index++;
                            break;
                        case 3:
                            this.SamplingContrastColor_Green = (pair.DoubleValue);
                            _code_40_index++;
                            break;
                        case 4:
                            this.SamplingContrastColor_Blue = (pair.DoubleValue);
                            _code_40_index++;
                            break;
                        case 5:
                            this.SamplingContrastColor_Alpha = (pair.DoubleValue);
                            _code_40_index++;
                            break;
                        case 6:
                            this.GlobalIlluminationRadius = (pair.DoubleValue);
                            _code_40_index++;
                            break;
                        case 7:
                            this.FinalGatherSampleRadius_Minimum = (pair.DoubleValue);
                            _code_40_index++;
                            break;
                        case 8:
                            this.FinalGatherSampleRadius_Maximum = (pair.DoubleValue);
                            _code_40_index++;
                            break;
                        case 9:
                            this.LuminanceScale = (pair.DoubleValue);
                            _code_40_index++;
                            break;
                        case 10:
                            this.GridSize = (pair.DoubleValue);
                            _code_40_index++;
                            break;
                        default:
                            Debug.Assert(false, "Unexpected extra values for code 40");
                            break;
                    }
                    break;
                case 70:
                    switch (_code_70_index)
                    {
                        case 0:
                            this.SamplingFilterType = (DxfSamplingFilterType)(pair.ShortValue);
                            _code_70_index++;
                            break;
                        case 1:
                            this.ShadowMode = (DxfRenderShadowMode)(pair.ShortValue);
                            _code_70_index++;
                            break;
                        case 2:
                            this.DiagnosticMode = (DxfRenderDiagnosticMode)(pair.ShortValue);
                            _code_70_index++;
                            break;
                        case 3:
                            this.DiagnosticGridMode = (DxfRenderDiagnosticGridMode)(pair.ShortValue);
                            _code_70_index++;
                            break;
                        case 4:
                            this.DiagnosticPhotonMode = (DxfDiagnosticPhotonMode)(pair.ShortValue);
                            _code_70_index++;
                            break;
                        case 5:
                            this.DiagnosticBSPMode = (DxfDiagnosticBSPMode)(pair.ShortValue);
                            _code_70_index++;
                            break;
                        case 6:
                            this.TileOrder = (DxfTileOrder)(pair.ShortValue);
                            _code_70_index++;
                            break;
                        default:
                            Debug.Assert(false, "Unexpected extra values for code 70");
                            break;
                    }
                    break;
                case 90:
                    switch (_code_90_index)
                    {
                        case 0:
                            this.ClassVersion_1 = (pair.IntegerValue);
                            _code_90_index++;
                            break;
                        case 1:
                            this.TextureSamplingQuality = (pair.IntegerValue);
                            _code_90_index++;
                            break;
                        case 2:
                            this.ClassVersion_2 = (pair.IntegerValue);
                            _code_90_index++;
                            break;
                        case 3:
                            this.MinimumSamplingRate = (pair.IntegerValue);
                            _code_90_index++;
                            break;
                        case 4:
                            this.MaximumSamplingRate = (pair.IntegerValue);
                            _code_90_index++;
                            break;
                        case 5:
                            this.RayTracingDepth_Reflections = (pair.IntegerValue);
                            _code_90_index++;
                            break;
                        case 6:
                            this.RayTracingDepth_Refractions = (pair.IntegerValue);
                            _code_90_index++;
                            break;
                        case 7:
                            this.RayTracingDepth_Maximum = (pair.IntegerValue);
                            _code_90_index++;
                            break;
                        case 8:
                            this.SampleCount = (pair.IntegerValue);
                            _code_90_index++;
                            break;
                        case 9:
                            this.PhotonsPerLight = (pair.IntegerValue);
                            _code_90_index++;
                            break;
                        case 10:
                            this.GlobalIlluminationDepth_Reflections = (pair.IntegerValue);
                            _code_90_index++;
                            break;
                        case 11:
                            this.GlobalIlluminationDepth_Refractions = (pair.IntegerValue);
                            _code_90_index++;
                            break;
                        case 12:
                            this.GlobalIlluminationDepth_Maximum = (pair.IntegerValue);
                            _code_90_index++;
                            break;
                        case 13:
                            this.FinalGatherRayCount = (pair.IntegerValue);
                            _code_90_index++;
                            break;
                        case 14:
                            this.TileSize = (pair.IntegerValue);
                            _code_90_index++;
                            break;
                        case 15:
                            this.MemoryLimit = (pair.IntegerValue);
                            _code_90_index++;
                            break;
                        default:
                            Debug.Assert(false, "Unexpected extra values for code 90");
                            break;
                    }
                    break;
                case 290:
                    switch (_code_290_index)
                    {
                        case 0:
                            this.RenderMaterials = (pair.BoolValue);
                            _code_290_index++;
                            break;
                        case 1:
                            this.RenderBackFaces = (pair.BoolValue);
                            _code_290_index++;
                            break;
                        case 2:
                            this.RenderShadows = (pair.BoolValue);
                            _code_290_index++;
                            break;
                        case 3:
                            this.MapShadows = (pair.BoolValue);
                            _code_290_index++;
                            break;
                        case 4:
                            this.RayTracing = (pair.BoolValue);
                            _code_290_index++;
                            break;
                        case 5:
                            this.UseGlobalIllumination = (pair.BoolValue);
                            _code_290_index++;
                            break;
                        case 6:
                            this.UseGlobalIlluminationRadius = (pair.BoolValue);
                            _code_290_index++;
                            break;
                        case 7:
                            this.UseFinalGather = (pair.BoolValue);
                            _code_290_index++;
                            break;
                        case 8:
                            this.UseFinalGatherMinimumRadius = (pair.BoolValue);
                            _code_290_index++;
                            break;
                        case 9:
                            this.UseFinalGatherMaximumRadius = (pair.BoolValue);
                            _code_290_index++;
                            break;
                        case 10:
                            this.UseFinalGatherPixels = (pair.BoolValue);
                            _code_290_index++;
                            break;
                        case 11:
                            this.ExportMIStatistics = (pair.BoolValue);
                            _code_290_index++;
                            break;
                        default:
                            Debug.Assert(false, "Unexpected extra values for code 290");
                            break;
                    }
                    break;
                default:
                    return base.TrySetPair(pair);
            }

            return true;
        }
    }
}
