using BepInEx;
using UnityEngine;

namespace MyGorillaTagMod
{
    [BepInPlugin("com.you.mygorillatagmod", "MyGorillaTagMod", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        void Awake()
        {
            Logger.LogInfo("MyGorillaTagMod loaded!");
            // Add your GameObject with mod component
            var go = new GameObject("MyModObject");
            go.AddComponent<MyMod>();
            DontDestroyOnLoad(go);
        }
    }
}
