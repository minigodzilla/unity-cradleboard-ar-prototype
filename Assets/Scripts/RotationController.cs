using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour
{
    public GameObject CradleboardObject;
    public Vector3 RotationVector;

    private void Update()
    {
        CradleboardObject.transform.Rotate(RotationVector * Time.deltaTime);
    }
}
