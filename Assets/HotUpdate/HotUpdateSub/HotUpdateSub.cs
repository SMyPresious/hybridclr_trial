using UnityEngine;


/// <summary>
/// 增加HotUpdateSub 子Assembly，并添加到HotUpdateAssemblyDefinition中，在Entry中分别测试
/// 是否需要显式加载， 是否需要添加到HotUpdate中 对应是否能正常运行的结果
/// </summary>
public static class HotUpdateSub
{
    public static void CallByRefection()
    {
        Debug.Log("[HotUpdateSub::CallByRefection] 333成功运行热更新代码");
    }
    
    public static void DirectlyCall()
    {
        Debug.Log("[HotUpdateSub::DirectlyCall] 333成功运行热更新代码");
    }
}
