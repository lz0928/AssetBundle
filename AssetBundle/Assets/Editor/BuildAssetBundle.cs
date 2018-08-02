using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class BuildAssetBundle {

    [MenuItem("AssetBundleTools/BuildAssetBundles")]
	public static void BuildBundle()
    {
        //打包AB输出路径
        string strABOutPathDir = string.Empty;
        //获取“StreamingAsset”数值
        strABOutPathDir = Application.streamingAssetsPath;

        if (!Directory.Exists(strABOutPathDir))
        {
            Directory.CreateDirectory(strABOutPathDir);
        }
        BuildPipeline.BuildAssetBundles(strABOutPathDir, BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows64);
    }
}
