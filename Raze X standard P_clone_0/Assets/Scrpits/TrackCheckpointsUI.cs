using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackCheckpointsUI : MonoBehaviour
{
   [SerializeField] private TrackCheckpoints1 trackCheckpoints;

    private void Start()
    {
        trackCheckpoints.OnPlayerCorrectCheckpoint += TrackCheckPoints_OnPlayerCorrectCheckpoint;
        trackCheckpoints.OnPlayerWrongCheckpoint += TrackCheckPoints_OnPlayerWrongCheckpoint;

        Hide();
    }

    private void TrackCheckPoints_OnPlayerWrongCheckpoint(object sender, EventArgs e)
    {
        Show();
    }

    private void TrackCheckPoints_OnPlayerCorrectCheckpoint(object sender, EventArgs e)
    {
        Hide();
    }

    private void Show()
    {
        gameObject.SetActive(true);
    }

    private void Hide() 
    { 
        gameObject.SetActive(false); 
    }
}
