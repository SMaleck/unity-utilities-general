using UnityEngine;
using UnityEngine.UI;

namespace UtilitiesGeneral.UnityExtensions
{
    public static class ScrollRectExtensions
    {
        public static Vector2 GetAnchoredPosition(
            this ScrollRect scrollRect,
            Vector3 targetPosition)
        {
            return (Vector2)scrollRect.transform.InverseTransformPoint(scrollRect.content.position)
                   - (Vector2)scrollRect.transform.InverseTransformPoint(targetPosition);
        }
    }
}
