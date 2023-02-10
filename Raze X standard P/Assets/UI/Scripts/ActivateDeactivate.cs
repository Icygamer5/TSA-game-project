using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateDeactivate : MonoBehaviour
{
    [SerializeField] private GameObject ToActivate;
    [SerializeField] private GameObject ToDeactivate;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            ToActivate.SetActive(true); ToDeactivate.SetActive(false); 
        }
    }
}

