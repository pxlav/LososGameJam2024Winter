using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    public Camera m_camera;

    private void FixedUpdate()
    {
        Vector3 desiredPosition = new Vector3(0, target.position.y + offset.y, offset.z);
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
        //transform.LookAt(target);
    }
}
