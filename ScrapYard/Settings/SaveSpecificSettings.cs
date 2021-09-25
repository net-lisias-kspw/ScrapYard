using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KSP.Localization;

namespace ScrapYard
{
    public class SaveSpecificSettings : GameParameters.CustomParameterNode
    {
        public override GameParameters.GameMode GameMode
        {
            get
            {
                return GameParameters.GameMode.ANY;
            }
        }

        public override bool HasPresets
        {
            get
            {
                return false; //for now lets not have presets
            }
        }

        public override string Section
        {
            get
            {
                return "#SYD-settings-SectionName"; // "ScrapYard";
            }
        }

        public override int SectionOrder
        {
            get
            {
                return 1; //I think? I'm not 100% sure what this is for
            }
        }

        public override string Title
        {
            get
            {
                return "#SYD-settings-Title"; //"ScrapYard";
            }
        }

        public override string DisplaySection
        {
            get
            {
                return "#SYD-settings-DisplaySection"; // Title;
            }
        }

        [GameParameters.CustomParameterUI("#SYD-settings-ModEnabled", toolTip = "#SYD-settings-ModEnabled-Tip")]
        public bool ModEnabled = true;

        [GameParameters.CustomParameterUI("#SYD-settings-UseInventory", toolTip = "#SYD-settings-UseInventory#SYD-settings-UseInventory-Tip")]
        public bool UseInventory = true;

        [GameParameters.CustomParameterUI("#SYD-settings-UseTracker", toolTip = "#SYD-settings-UseTracker-Tip")]
        public bool UseTracker = true;

        [GameParameters.CustomParameterUI("#SYD-settings-OverrideFunds", toolTip = "#SYD-settings-OverrideFunds-Tip")]
        public bool OverrideFunds = false;

        [GameParameters.CustomIntParameterUI("#SYD-settings-FundsSalePercent", toolTip = "#SYD-settings-FundsSalePercent-Tip", minValue = 0, maxValue = 100, stepSize = 1)]
        public int FundsSalePercent = 100;

        [GameParameters.CustomParameterUI("#SYD-settings-DebugLogging", toolTip = "#SYD-settings-DebugLogging-Tip")]
        public bool DebugLogging = false;

        [GameParameters.CustomIntParameterUI("#SYD-settings-RefreshTime", toolTip = "#SYD-settings-RefreshTime-Tip", minValue = 2, maxValue = 100, stepSize = 2)]
        public int RefreshTime = 10;

        [GameParameters.CustomParameterUI("#SYD-settings-CPAW", toolTip = "#SYD-settings-CPAW-Tip")]
        public bool coloredPAW = true;
    }
}
