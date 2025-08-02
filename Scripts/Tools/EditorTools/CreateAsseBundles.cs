using System.IO;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.Build.Player;
public class CreateAsseBundles
{
	[MenuItem("Assets/Build AssetBundles")]
	static void BuildAllAssetBundles()
	{
		string AssetBundleDirectory = "D:/Projects/GameHackProj/BepInPvz/BepInRH-AB/";
		BuildPipeline.BuildAssetBundles(AssetBundleDirectory,BuildAssetBundleOptions.None,EditorUserBuildSettings.activeBuildTarget);

	}

    [MenuItem("Assets/Remove Bundle Name")]
    static void RemoveAssetBundleNameExample()
    {
        AssetDatabase.RemoveAssetBundleName("test", true);
    }

    [MenuItem("HTools/CompileDlls")]
    public static void CompileDll()
    {
        var tempOutputPath = "D:/Projects/GameHackProj/BepInPvz/BepInRH-AB/";
        Directory.CreateDirectory(tempOutputPath);

        ScriptCompilationSettings scriptCompilationSettings = new ScriptCompilationSettings();
        scriptCompilationSettings.group = BuildPipeline.GetBuildTargetGroup(BuildTarget.StandaloneWindows64);
        scriptCompilationSettings.target = BuildTarget.StandaloneWindows64;

        PlayerBuildInterface.CompilePlayerScripts(scriptCompilationSettings, tempOutputPath);
    }
}


/*
public class ExportAssetBundles {
    [MenuItem("Export/Build AssetBundle From Selection - Track dependencies")]
    static void ExportResource () {
        // Bring up save panel
        string path = EditorUtility.SaveFilePanel ("Save Resource", "", "New Resource", "unity3d");
        if (path.Length != 0) {
            // Build the resource file from the active selection.
        Object[] selection = Selection.GetFiltered(typeof(Object), SelectionMode.DeepAssets);
            BuildPipeline.BuildAssetBundle(Selection.activeObject, selection, path, BuildAssetBundleOptions.CollectDependencies | BuildAssetBundleOptions.CompleteAssets);
            Selection.objects = selection;
        }
    }
    [MenuItem("Export/Build AssetBundle From Selection - No dependency tracking")]
    static void ExportResourceNoTrack () {
        // Bring up save panel
        string path = EditorUtility.SaveFilePanel ("Save Resource", "", "New Resource", "unity3d");
        if (path.Length != 0) {
            // Build the resource file from the active selection.
            BuildPipeline.BuildAssetBundle(Selection.activeObject, Selection.objects, path);
        }
    }
}
*/
#endif