using UnityEngine;

namespace UtilitiesGeneral.UnityExtensions
{
    public static class MonoBehaviourExtensions
    {
        public static void SetParent(this MonoBehaviour target, Transform parent)
        {
            target.transform.SetParent(parent, false);
        }

        public static T SetParent<T>(this T target, Transform parent) where T : MonoBehaviour
        {
            target.transform.SetParent(parent, false);
            return target;
        }
    }
}
