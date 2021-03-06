#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `ItemPair`. Inherits from `AtomDrawer&lt;ItemPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ItemPairEvent))]
    public class ItemPairEventDrawer : AtomDrawer<ItemPairEvent> { }
}
#endif
