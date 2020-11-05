using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class Builder : MonoBehaviour
{
    // Start is called before the first frame update
    [MenuItem("Tools/Build AssetBundles")]
    static public void BuildAssetBundles()
    {
        string path = "assetbundles";
        new DirectoryInfo(path).Create();
        AssetBundleManifest manifest = BuildPipeline.BuildAssetBundles(path, BuildAssetBundleOptions.ChunkBasedCompression, EditorUserBuildSettings.activeBuildTarget);

        Debug.Log("Build Ok!");
    }


}
