using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Саммарии
/// </summary>
public class CameraFacer : MonoBehaviour
{
    private Transform target;

    private void Start()
    {
        target = Camera.main.transform;
    }
    private void Update()
    {
        transform.LookAt(target);
    }
}
