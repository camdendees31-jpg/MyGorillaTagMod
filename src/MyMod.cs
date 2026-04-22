using UnityEngine;

namespace MyGorillaTagMod
{
    public class MyMod : MonoBehaviour
    {
        void Update()
        {
            // Your mod logic here
            // Example: speed boost
        }

        void OnGUI()
        {
            GUI.Label(new Rect(10, 10, 300, 30), "MyGorillaTagMod is running!");
        }
    }
}
