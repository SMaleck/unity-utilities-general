using UnityEngine;

namespace UtilitiesGeneral.UnityExtensions
{
    public static class TransformExtensions
    {
        public static void ResetLocal(this Transform target)
        {
            target.position = Vector3.zero;
            target.localScale = Vector3.one;
        }
    }
}
