using UnityEditor;

namespace DreamCode.SmartImporter.Editor.Reflection
{
    internal static class PackageImport
    {
        internal static void ShowImportPackage(string packagePath, object[] assets, string packageIconPath)
        {
            var packageImport = typeof(MenuItem).Assembly.GetType("UnityEditor.PackageImport");
            var showImportPackageMethodInfo = packageImport.GetMethod("ShowImportPackage");
#if UNITY_6000_0_OR_NEWER
            showImportPackageMethodInfo?.Invoke(
                null,
                new object[]
                {
                    packagePath, assets, packageIconPath, 0, string.Empty, string.Empty, 0
                });
#else
            showImportPackageMethodInfo?.Invoke(
                null,
                new object[]
            {
                packagePath, assets, packageIconPath
            });
#endif
        }
    }
}