using UnityEditor;

namespace DreamCode.SmartImporter.Editor.Reflection
{
    internal static class PackageImport
    {
        internal static void ShowImportPackage(string packagePath, object[] assets, string packageIconPath)
        {
            var packageImport = typeof(MenuItem).Assembly.GetType("UnityEditor.PackageImport");
            var showImportPackageMethodInfo = packageImport.GetMethod("ShowImportPackage");
            showImportPackageMethodInfo?.Invoke(null, new object[]
            {
                packagePath, assets, packageIconPath
            });
        }
    }
}