using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointJob : MonoBehaviour
{
    private TrackCheckpoints1 trackCheckpoints;
    private void OnTriggerEnter(Collider other)
    {
      trackCheckpoints.CarThroughCheckpoint(this, other.transform);
    }
    public void setTrackCheckpoints(TrackCheckpoints1 trackCheckpoints)
    {
        this.trackCheckpoints = trackCheckpoints;
    }
}
