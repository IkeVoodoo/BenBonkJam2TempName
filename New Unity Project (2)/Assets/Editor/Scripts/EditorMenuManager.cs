using UnityEditor;
using UnityEngine;

public class EditorMenuManager : EditorWindow
{

    private PlayerData data;
    private float X, Y;
    private Vector3 lastPos;

    // Add menu item named "My Window" to the Window menu
    [MenuItem("Window/Utils/Player Settings")]
    public static void ShowWindow()
    {
        //Show existing window instance. If one doesn't exist, make one.
        EditorWindow.GetWindow(typeof(EditorMenuManager));
    }

    void OnGUI()
    {
        GUILayout.Label("Player Settings", EditorStyles.boldLabel);
        data = EditorGUILayout.ObjectField("Select player data", data, typeof(PlayerData), true) as PlayerData;
        
        if(data != null)
        {
            X = EditorGUILayout.FloatField("Room X:", data.X);
            Y = EditorGUILayout.FloatField("Room Y:", data.Y);
            lastPos = EditorGUILayout.Vector3Field("Player last pos:", data.lastPos);

            if (GUILayout.Button("Reset"))
            {
                data.X = 0;
                data.Y = 0;
                data.lastPos = new Vector3(0, 1, 0);
            }
        }

        /*groupEnabled = EditorGUILayout.BeginToggleGroup("Optional Settings", groupEnabled);
        myBool = EditorGUILayout.Toggle("Toggle", myBool);
        myFloat = EditorGUILayout.Slider("Slider", myFloat, -3, 3);
        EditorGUILayout.EndToggleGroup();*/
    }
}
