using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MoveToMap : MonoBehaviour

{
    private string SceneToSwitch;
    void HandleInputData(int val)
    { 
        if (val == 0) 
        {
            SceneToSwitch = "Map1";
        }
        if (val == 1) 
        {
            SceneToSwitch = "Map2";
        }
        if (val == 2) 
        {
            SceneToSwitch = "Map3";
        }
    }
    
}