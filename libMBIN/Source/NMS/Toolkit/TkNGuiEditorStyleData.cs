using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x660549C9ACC69D01, NameHash = 0x6F26BF19981BB60C)]
    public class TkNGuiEditorStyleData : NMSTemplate
    {
        // size: 0x30
        public enum SizesEnum {
            WindowResize,
            WindowButton,
            Indent,
            SeparatorHeight,
            SeparatorWidth,
            TreeNodeExpander,
            CheckBox,
            Adjuster,
            Cursor,
            TextEditSeparator,
            DefaultLineHeight,
            ColourEditHeight,
            ColourEditWidth,
            FileBrowser,
            EditorResize,
            EditorMove,
            IconButton,
            SliderKnob,
            SliderBarWidth,
            SliderBarHeight,
            CategoryHeight,
            WindowTitle,
            ScrollSpeed,
            ComboBox,
            Taskbar,
            IconListItem,
            Toolbar,
            ToolbarOptions,
            StartBarWidth,
            StartBarHeight,
            StartBarSearchWidth,
            TreeNodeSpacing,
            VectorSpacing,
            SliderMinSpacing,
            VectorMinSpacing,
            ColourAlphaMinsize,
            SpacingGap,
            Scroll,
            TextLabelSeparator,
            AlignmentAnchor,
            MinimiseHighlightHeight,
            TableButtonSpacing,
            TableHeaderHeight,
            TreeNodeHeight,
            ScrollMargin,
            ScrollIncrement,
            EditorPin,
            DynamicPanelTitle
        }
        [NMS(Size = 0x30, EnumType = typeof(SizesEnum))]
        /* 0x0000 */ public float[] Sizes;
        [NMS(Size = 0x8)]
        /* 0x00C0 */ public TkNGuiEditorStyleColour[] SkinColours;
        /* 0x0540 */ public float SkinFontHeight;
        /* 0x0544 */ public NMSString0x80 Font;
        // size: 0x48
        public enum GraphicStylesEnum {
            Panel,
            Button,
            Text,
            Graphic,
            WindowTitleBar,
            WindowTitleBarInactive,
            WindowTab,
            WindowTabInactive,
            Window,
            WindowPane,
            WindowResize,
            WindowClose,
            WindowMinimize,
            WindowMaximize,
            ScrollBarBackground,
            ScrollBarForeground,
            TreeNodeCollapsed,
            TreeNodeExpanded,
            CheckBoxTrue,
            CheckBoxFalse,
            TextInput,
            Increment,
            Decrement,
            Cursor,
            TextSelection,
            Separator,
            EditorResize,
            EditorMove,
            EditorOverlay,
            FileBrowser,
            ColourEdit,
            IconButton,
            SliderKnob,
            SliderBar,
            IconButtonText,
            TextInputLabel,
            Category,
            Taskbar,
            TaskbarItem,
            StartBarWindow,
            ComboBox,
            ComboBoxWindow,
            IconListItem,
            IconListItemSelected,
            ImageButton,
            Toolbar,
            ToolbarGraphic,
            ToolbarOptions,
            Rectangle,
            TreeNodeBorder,
            Background,
            GroupTitle,
            TextLabelSeparator,
            AlignmentAnchor,
            MinimiseHighlight,
            Table,
            TableBorder,
            TableFolderButton,
            TableAddEntryButton,
            TreeNode,
            CategoryCollapsed,
            CategoryExpanded,
            WindowTitleBarDragTarget,
            IconButtonSelected,
            Line,
            TreeNodeBackground,
            TreeNodeCategoryBackground,
            SceneNodeBackground,
            PinChildren,
            UnpinChildren,
            DynamicPanel,
            DynamicPanelTitle
        }
        [NMS(Size = 0x48, EnumType = typeof(GraphicStylesEnum))]
        /* 0x05D0 */ public TkNGuiGraphicStyle[] GraphicStyles;
        // size: 0xE
        public enum TextStylesEnum {
            Text,
            Button,
            WindowTab,
            WindowTabInactive,
            TreeNode,
            CheckBox,
            TextInput,
            TextInputLabel,
            TextInputLabelHeader,
            Category,
            TaskBar,
            GroupTitle,
            TreeNodeSelected,
            DynamicPanelTitle
        }
        [NMS(Size = 0xE, EnumType = typeof(TextStylesEnum))]
        /* 0x9ED0 */ public TkNGuiTextStyle[] TextStyles;
        /* 0xB130 */ public List<float> SnapSettings;
    }
}
