using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;


public static class Entry
{
    public static void Start()
    {
        Debug.Log("[Entry::Start] 看到这个日志表示你成功运行了热更新代码");
        Run_InstantiateByAddComponent();
        Run_AOTGeneric();
        Run_TestAOTAssembly();
        Run_TestLoadAssembly();
    }

    private static void Run_InstantiateByAddComponent()
    {
        // 代码中动态挂载脚本
        GameObject cube = new GameObject("");
        cube.AddComponent<InstantiateByAddComponent>();
    }


    struct MyVec3
    {
        public int x;
        public int y;
        public int z;
    }

    private static void Run_AOTGeneric()
    {
        // 泛型实例化
        var arr = new List<MyVec3>();
        arr.Add(new MyVec3 { x = 1 });
        Debug.Log("[Demos.Run_AOTGeneric] 成功运行泛型代码");
    }

    private static void Run_TestAOTAssembly()
    {
        TestAotAssemblyClass.StartFromHotFix();
        
    }

    private static void Run_TestLoadAssembly()
    {
        // Assembly.Load(ReadBytesFromStreamingAssets("HotUpdate.dll.bytes"));
        // var aotAss = System.AppDomain.CurrentDomain.GetAssemblies().First(a => a.GetName().Name == "AOT");
        // Type entryType = aotAss.GetType("TestAotAssemblyClass");
        // entryType.GetMethod("Start").Invoke(null, null);
        // Debug.Log("[Demos.Run_TestAOTAssembly By Reflection] 成功运行AotAssembly代码");
    }
}