using UnityEngine;

namespace UtilitiesGeneral.UnityExtensions
{
    public static class MonoExtensions
    {
        public static bool IsActive(this MonoBehaviour monoBehaviour)
        {
            return monoBehaviour.gameObject.activeSelf;
        }

        public static void SetIsActive(this MonoBehaviour monoBehaviour, bool isActive)
        {
            monoBehaviour.gameObject.SetActive(isActive);
        }

        public static Vector3 GetPosition(this MonoBehaviour monoBehaviour)
        {
            return monoBehaviour.gameObject.transform.position;
        }

        public static void SetPosition(this MonoBehaviour monoBehaviour, Vector3 position)
        {
            monoBehaviour.gameObject.transform.position = position;
        }

        public static void SetParent(this GameObject target, Transform parent)
        {
            target.transform.SetParent(parent, false);
        }
    }
}