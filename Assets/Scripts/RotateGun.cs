using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateGun : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    private float sensivity = 2;
    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Mouse X") * sensivity;
        transform.Rotate(0, horizontal, 0);

        vertical = Input.GetAxis("Mouse Y") * sensivity;
        transform.Rotate(0, 0, vertical);
    }
}
