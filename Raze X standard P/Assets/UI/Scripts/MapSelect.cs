using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Reporting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapSelect : MonoBehaviour
{
    public void SceneSwitcher (string NextScene) 
    {
        SceneManager.LoadScene(NextScene);
    }
}
