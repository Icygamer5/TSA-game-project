using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackCheckpoints1 : MonoBehaviour
{
    [SerializeField] private List<Transform> carTransformList;
    private List<CheckPointJob> CheckPointSinglesList;
    private List<int> nextCheckpointIndexList;

    public event EventHandler OnPlayerCorrectCheckpoint;
    public event EventHandler OnPlayerWrongCheckpoint;
    private void Awake()
    {
        Transform checkpointsTransform = transform.Find("Checkpoints");
        CheckPointSinglesList = new List<CheckPointJob>();
        foreach (Transform CheckPointTransform in checkpointsTransform)
        {
            CheckPointJob checkPoint = CheckPointTransform.GetComponent<CheckPointJob>();
            checkPoint.setTrackCheckpoints(this);
            CheckPointSinglesList.Add(checkPoint);
        }
        nextCheckpointIndexList = new List<int>();
        foreach (Transform carTransform in carTransformList)
        {
            nextCheckpointIndexList.Add(0);
        }
    }
    public void CarThroughCheckpoint(CheckPointJob CheckPoint, Transform carTransform)
    {
        int nextCheckpointIndex = nextCheckpointIndexList[carTransformList.IndexOf(carTransform)];
        if (CheckPointSinglesList.IndexOf(CheckPoint) == nextCheckpointIndex)
        {
            nextCheckpointIndexList[carTransformList.IndexOf(carTransform)] = (nextCheckpointIndex + 1) % CheckPointSinglesList.Count;
            OnPlayerCorrectCheckpoint?.Invoke(this, EventArgs.Empty);
        }
        else
        {
            OnPlayerWrongCheckpoint?.Invoke(this, EventArgs.Empty);
        }
    }
}
