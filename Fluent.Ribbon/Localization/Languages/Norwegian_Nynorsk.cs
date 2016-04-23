#pragma warning disable 1591

namespace Fluent.Localization.Languages
{
    [RibbonLocalization("Norwegian (Nynorsk)", "nn")]
    public class Norwegian_Nynorsk : RibbonLocalizationBase
    {
        public override string BackstageButtonText { get; } = "Fil";
        public override string BackstageButtonKeyTip { get; } = "F";
        public override string MinimizeButtonScreenTipTitle { get; } = "Minimer båndet (Ctrl + F1)";
        public override string MinimizeButtonScreenTipText { get; } = "Viser bare kategorinavnene på båndet";
        public override string ExpandButtonScreenTipTitle { get; } = "Utvider båndet (Ctrl + F1)";
        public override string ExpandButtonScreenTipText { get; } = "Vis båndet slik at det alltid er utvidet selv etter at du har valgt en kommando";
        public override string QuickAccessToolBarDropDownButtonTooltip { get; } = "Tilpass verktøylinje for hurtigtilgang";
        public override string QuickAccessToolBarMoreControlsButtonTooltip { get; } = "Flere kontroller";
        public override string QuickAccessToolBarMenuHeader { get; } = "Tilpass verktøylinje for hurtigtilgang";
        public override string QuickAccessToolBarMenuShowAbove { get; } = "Vis over båndet";
        public override string QuickAccessToolBarMenuShowBelow { get; } = "Vis under båndet";
        public override string RibbonContextMenuAddItem { get; } = "Legg til på verktøylinje for hurtigtilgang";
        public override string RibbonContextMenuAddGroup { get; } = "Legg til gruppe på verktøylinje for hurtigtilgang";
        public override string RibbonContextMenuAddGallery { get; } = "Legg til galleri på verktøylinje for hurtigtilgang";
        public override string RibbonContextMenuAddMenu { get; } = "Legg til meny på verktøylinje for hurtigtilgang";
        public override string RibbonContextMenuRemoveItem { get; } = "Fjern verktøylinjen for hurtigtilgang";
        public override string RibbonContextMenuCustomizeQuickAccessToolBar { get; } = "Tilpass verktøylinje for hurtigtilgang...";
        public override string RibbonContextMenuCustomizeRibbon { get; } = "Tilpass båndet...";
        public override string RibbonContextMenuMinimizeRibbon { get; } = "Minimer båndet";
        public override string RibbonContextMenuShowAbove { get; } = "Vis verktøylinjen for hurtigtilgang over båndet";
        public override string RibbonContextMenuShowBelow { get; } = "Vis verktøylinjen for hurtigtilgang under båndet";
        public override string ScreenTipDisableReasonHeader { get; } = "Denne kommandoen er for øyeblikket deaktivert.";
        public override string ScreenTipF1LabelHeader { get; } = "Press F1 for help";
        public override string CustomizeStatusBar { get; } = "Customize Status Bar";
    }
}