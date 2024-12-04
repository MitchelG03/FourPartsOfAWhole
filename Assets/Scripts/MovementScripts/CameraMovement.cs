using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public int cameraMoveDistance = 4;

    public GameObject target;
    public float smoothSpeed = 1f;
    //public float smoothSpeedElse = 0.5f;
    public Vector3 offset;
    
    private void FixedUpdate()
    {
        /*float distance = target.transform.position.x - transform.position.x;
        if (distance > cameraMoveDistance || distance < -cameraMoveDistance)
        {
            Vector3 desiredPosition = target.transform.position + offset;
            Vector3 smoothendPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
            transform.position = smoothendPosition;
        }
        else
        {
            Vector3 desiredPosition = target.transform.position + offset;
            Vector3 smoothendPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeedElse * Time.deltaTime);
            transform.position = smoothendPosition;
        }*/

        Vector3 desiredPosition = target.transform.position + offset;
        Vector3 smoothendPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothendPosition;
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
