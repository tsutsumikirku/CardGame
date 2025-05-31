using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

public class UIAnimationTimeline : EditorWindow
{
    [MenuItem("Window/UI Animation Timeline")]
    public static void ShowWindow()
    {
        GetWindow<UIAnimationTimeline>("UI Animation Timeline");
    }

    private void OnGUI()
    {

    }
}