using System;
using System.Collections.Generic;
using UnityEngine;

public class Sample : MonoBehaviour
{
    void Start()
    {
        //初始化bugly的appid，在bugly创建获取
#if UNITY_IOS
        BuglyAgent.InitWithAppId ("your ios app id");
#elif UNITY_ANDROID
        BuglyAgent.InitWithAppId ("812665466a");
#endif

        BuglyAgent.ConfigDebugMode(true);
        BuglyAgent.EnableExceptionHandler();
        Debug.LogError($"init bugly");

        exception += $"init bugly\n";
    }

    private GUIStyle style = new GUIStyle();
    private string exception;
    private List<int> numbers = new List<int>();

    void TestNullReference()
    {
        style.fontSize = 22;
        try
        {
            GameObject go = null;
            go.name = "";
        }
        catch (Exception e)
        {
            Debug.LogError($"{e}");
            exception += $"{e}\n";
        }
    }

    void TestOutOfRange()
    {
        try
        {
            numbers[1] = 1;
        }
        catch (Exception e)
        {
            Debug.LogError($"{e}");
            exception += $"{e}\n";
        }
    }


    void OnGUI()
    {
        GUILayout.Space(150);
        GUILayout.BeginHorizontal();
        if (GUILayout.Button("TestNullReference", GUILayout.Width(200), GUILayout.Height(60)))
        {
            TestNullReference();
        }
        GUILayout.Space(50);
        if (GUILayout.Button("OutOfRange", GUILayout.Width(200), GUILayout.Height(60)))
        {
            TestOutOfRange();
        }
        GUILayout.EndHorizontal();
        
        if (!string.IsNullOrEmpty(exception))
        {
            GUI.Label(new Rect(0, 100, Screen.width, Screen.height), $"{exception}", style);
        }


    }
}
