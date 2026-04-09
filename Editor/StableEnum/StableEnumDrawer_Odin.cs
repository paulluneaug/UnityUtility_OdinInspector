using Sirenix.OdinInspector.Editor;
using UnityEngine;

namespace UnityUtility.Editor.Odin
{
    public class StableEnumOdinDrawer<T> : OdinValueDrawer<StableEnum<T>>
        where T : struct
    {
        protected override void DrawPropertyLayout(GUIContent label)
        {
            StableEnum<T> value = ValueEntry.SmartValue;

            value.Value = EnumSelector<T>.DrawEnumField(label, value.Value);

            this.ValueEntry.SmartValue = value;
        }
    }
}