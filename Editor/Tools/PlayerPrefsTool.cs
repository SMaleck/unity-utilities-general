using UnityEditor;
using UnityEngine;
using UtilitiesGeneral.Editor.Constants;

namespace UtilitiesGeneral.Editor.Tools
{
    public class PlayerPrefsTool
    {
        [MenuItem(MenuConstants.MenuRoot + "/PlayerPrefs - Clear")]
        public static void ClearPlayerPrefs()
        {
            PlayerPrefs.DeleteAll();
        }
    }
}
