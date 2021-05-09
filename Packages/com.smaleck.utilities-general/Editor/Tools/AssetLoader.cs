using System.Linq;
using UnityEditor;

namespace UtilitiesGeneral.Editor.Tools
{
    public class AssetLoader
    {
        public static T Load<T>() where T : UnityEngine.Object
        {
            var path = GetAssetPath<T>();
            return AssetDatabase.LoadAssetAtPath<T>(path);
        }

        public static string GetAssetPath<T>()
        {
            return AssetDatabase.FindAssets($"t:{typeof(T).Name}")
                .Select(AssetDatabase.GUIDToAssetPath)
                .FirstOrDefault();
        }
    }
}
