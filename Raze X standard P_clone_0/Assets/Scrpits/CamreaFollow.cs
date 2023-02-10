using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamreaFollow : MonoBehaviour
{
    [SerializeField] private Vector3 offset;
    [SerializeField] private Transform target;
    [SerializeField] private float TranslateSpeed;
    [SerializeField] private float RotationSpeed;
    private void FixedUpdate()
    {
        HandleTranslation();
        HandleRotation();
    }

    private void HandleRotation()
    {
        var direction = target.position - transform.position;
        var rotation = Quaternion.LookRotation(direction, Vector3.up);
        transform.rotation = Quaternion.Lerp( transform.rotation, rotation, RotationSpeed * Time.deltaTime);
    }

    private void HandleTranslation()
    {
        var targetPostion = target.TransformPoint(offset);
        transform.position = Vector3.Lerp(transform.position, targetPostion, TranslateSpeed * Time.deltaTime);
    }
}
