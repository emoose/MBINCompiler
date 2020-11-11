using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x4, GUID = 0x0D7F9FADD498061D, NameHash = 0x4780AB6325CE84C6)]
    public class TKNGuiEditorTextType : NMSTemplate
    {
        // 0xC entries
        public enum NGuiEditorTextEnum {
            Text, Button, WindowTab, TreeNode, CheckBox, TextInput, TextInputLabel, TextInputLabelHeader, Category, TaskBar,
            GroupTitle, TreeNodeSelected
        };
        public NGuiEditorTextEnum NGuiEditorText;
    }
}
