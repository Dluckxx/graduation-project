using UnityEngine;
using UnityEditor;

public class DeleteMissingScripts : EditorWindow
{
    [MenuItem("Custom/Remove Missing Scripts")]
    private static void RemoveInSelected()
    {
        GameObject[] go = Selection.gameObjects;
        foreach (GameObject g in go)
        {
            RemoveRecursively(g);
        }
    }

    private static void RemoveRecursively(GameObject g)
    {
        Debug.LogFormat("Removing Missing Script - {0}", g.name);
        GameObjectUtility.RemoveMonoBehavioursWithMissingScript(g);

        foreach (Transform childT in g.transform)
        {
            RemoveRecursively(childT.gameObject);
        }
    }
}