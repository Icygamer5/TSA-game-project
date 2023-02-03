using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject Player;
    private void Awake()
    {
        Player.SetActive(true);
    }
}
