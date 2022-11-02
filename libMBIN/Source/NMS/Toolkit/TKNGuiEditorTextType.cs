namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xAD7C897DB7CB8DBF, NameHash = 0x4780AB6325CE84C6)]
    public class TKNGuiEditorTextType : NMSTemplate
    {
        // size: 0xE
        public enum NGuiEditorTextEnum {
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
        /* 0x0 */ public NGuiEditorTextEnum NGuiEditorText;
    }
}
