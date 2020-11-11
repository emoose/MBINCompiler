using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x4, GUID = 0xB4A978315CF685FB, NameHash = 0xB649393FB6E397AE)]
    public class TKNGuiEditorComponentSize : NMSTemplate
    {
        // 0x2B entries
        public enum NGuiEditorComponentSizeEnum {
            WindowResize, WindowButton, Indent, SeparatorHeight, SeparatorWidth, TreeNodeExpander, CheckBox, Adjuster, Cursor, TextEditSeparator,
            ColourEditHeight, ColourEditWidth, FileBrowser, EditorResize, EditorMove, IconButton, SliderKnob, SliderBarWidth, SliderBarHeight, CategoryHeight,
            WindowTitle, ScrollSpeed, ComboBox, Taskbar, IconListItem, Toolbar, ToolbarOptions, StartBarWidth, StartBarHeight, TreeNodeSpacing,
            VectorSpacing, VectorMinSpacing, ColourAlphaMinsize, SpacingGap, Scroll, TextLabelSeparator, AlignmentAnchor, MinimiseHighlightHeight, TableButtonSpacing, TableHeaderHeight,
            TreeNodeHeight, ScrollMargin, ScrollIncrement
        };
        public NGuiEditorComponentSizeEnum NGuiEditorComponentSize;
    }
}
