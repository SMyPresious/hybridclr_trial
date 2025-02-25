using System;
using System.Linq;
using UnityEngine;

public static class TestAotAssemblyClass
{
    public static void StartFromHotFix()
    {
        
        Debug.Log("[TestAotAssemblyClass::Start] 看到这个日志表示你成功运行了AOT热更新代码");
    }

    public static void StartFromAot()
    {
        Debug.Log("[TestAotAssemblyClass::StartFromAot] 看到这个日志表示你成功运行了 StartFromAot 热更新代码");
    }
}
