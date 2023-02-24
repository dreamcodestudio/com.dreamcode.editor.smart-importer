using UnityEditor;
using DreamCode.SmartImporter.Editor.Reflection;

namespace DreamCode.SmartImporter.Editor.UI
{
    internal static class PackageImporterMenu
    {
        private static string SelectedFolder
        {
            get
            {
                var isAssetSelected = Selection.assetGUIDs != null && Selection.assetGUIDs.Length != 0;
                if (!isAssetSelected)
                    return string.Empty;
                var assetPath = AssetDatabase.GUIDToAssetPath(Selection.assetGUIDs[0]);
                if (string.IsNullOrEmpty(assetPath))
                    return string.Empty;
                return AssetDatabase.IsValidFolder(assetPath) ? assetPath : string.Empty;
            }
        }

        [MenuItem("Assets/Import Package/Extract Here", true)]
        private static bool IsImportAvailable()
        {
            return !string.IsNullOrEmpty(SelectedFolder);
        }

        [MenuItem("Assets/Import Package/Extract Here", false)]
        private static void ImportPackage()
        {
            var selectedFolder = SelectedFolder;
            var packagePath = EditorUtility.OpenFilePanel("Import package", string.Empty, "unitypackage");
            if (string.IsNullOrEmpty(packagePath) || string.IsNullOrEmpty(selectedFolder))
                return;
            var assets = PackageUtility.ExtractAndPrepareAssetList(selectedFolder, packagePath);
            PackageImport.ShowImportPackage(packagePath, assets, string.Empty);
        }
    }
}