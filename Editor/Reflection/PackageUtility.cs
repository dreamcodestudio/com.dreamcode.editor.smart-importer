using System;
using UnityEditor;

namespace DreamCode.SmartImporter.Editor.Reflection
{
    internal static class PackageUtility
    {
        private delegate object[] ExtractPackageItems(string packagePath, out string packageIconPath,
            out string packageManagerDependenciesPath);

        internal static object[] ExtractAndPrepareAssetList(string selectedFolder, string packagePath)
        {
            var importPackageItem = typeof(MenuItem).Assembly.GetType("UnityEditor.ImportPackageItem");
            var destinationAssetPathFieldInfo = importPackageItem.GetField("destinationAssetPath");
            var existingAssetPathFieldInfo = importPackageItem.GetField("existingAssetPath");
            var exportedAssetPathFieldInfo = importPackageItem.GetField("exportedAssetPath");
            var existsFieldInfo = importPackageItem.GetField("exists");

            var assets = ExtractAndPrepareAssetList(packagePath);
            foreach (var asset in assets)
            {
                var exportedAssetPath = (string)exportedAssetPathFieldInfo.GetValue(asset);
                var existingAssetPath = (string)existingAssetPathFieldInfo.GetValue(asset);
                var destinationPathWithoutRoot =
                    exportedAssetPath.Substring(exportedAssetPath.IndexOf("/", StringComparison.Ordinal));
                var resultPath = selectedFolder + destinationPathWithoutRoot;
                if (!string.IsNullOrEmpty(existingAssetPath) && !existingAssetPath.Equals(resultPath))
                {
                    AssetDatabase.DeleteAsset(existingAssetPath);
                    existsFieldInfo.SetValue(asset, false);
                    existingAssetPathFieldInfo.SetValue(asset, resultPath);
                }

                destinationAssetPathFieldInfo.SetValue(asset, resultPath);
            }

            return assets;
        }

        private static object[] ExtractAndPrepareAssetList(string packagePath)
        {
            var packageUtility = typeof(MenuItem).Assembly.GetType("UnityEditor.PackageUtility");
            var extractAndPrepareAssetList = packageUtility.GetMethod("ExtractAndPrepareAssetList");
            if (extractAndPrepareAssetList == null)
                return null;
            var extractPackageItems =
                (ExtractPackageItems)Delegate.CreateDelegate(typeof(ExtractPackageItems), null,
                    extractAndPrepareAssetList);
            var packageItems = extractPackageItems(packagePath, out var packageIconPath,
                out var packageManagerDependenciesPath);
            return packageItems;
        }
    }
}