# TestUnityNestPrefab
测试Unity的预制件嵌套会导致资源冗余的问题.  
  
## 操作流程
测试环境2018.4  
点击菜单Tools/Build AssetBundles, 然后assetBundles目录可以找到编译的ab包  
一共编译2个预制件, `canvas`和`parent`, 其中`parent`包含`canvas`  
查看parent.manifest, 会发现依赖里面有`canvas`  
`canvas`包含一张图片, `parent`也包含同样这张图片(本不应该包含)  
  
## 补充资料
发现预制件(.prefab)嵌套预制件和预制件嵌套后缀.asset的文件都无法正确处理依赖关系  
https://issuetracker.unity3d.com/issues/nestedprefabs-when-building-assetbundles-with-nested-prefab-assets-are-duplicated-in-parent-prefab-assetbundle
