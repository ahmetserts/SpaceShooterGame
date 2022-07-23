using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Vector3 back = Vector3.up * 180f;

    private float lookBack = 0;
    void Update()
    {
        LookBack();
    }
    void LookBack()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            lookBack = 1;
            transform.localRotation = Quaternion.Euler(back * lookBack);
        }
        else
        {
            lookBack = 0;
            transform.localRotation = Quaternion.Euler(back * lookBack);
        }
    }
}
