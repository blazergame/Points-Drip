using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;

    void LateUpdate()
    {
        Vector3 newPos = new Vector3();
        if (target.position.y > transform.position.y)
        {
             newPos = new Vector3(transform.position.x, target.position.y, transform.position.z);
            transform.position = newPos;
        }
        
        //Move camera upwards
        transform.Translate(Vector3.up * Time.deltaTime, Space.World);

    }
}
