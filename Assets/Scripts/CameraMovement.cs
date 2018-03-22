using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
    public float speed = 10.0f;
    public Vector2 panLimit;
    void Update()
    {
        Vector3 pos = transform.position;
        if (Input.GetMouseButton(1))
        {
            if (Input.GetAxis("Mouse X") > 0)
            {
                pos -= new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed,
                                           0.0f, Input.GetAxisRaw("Mouse Y") * Time.deltaTime * speed);
            }

            else if (Input.GetAxis("Mouse X") < 0)
            {
                pos -= new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed,
                                           0.0f, Input.GetAxisRaw("Mouse Y") * Time.deltaTime * speed);
            }
        }

        if(Input.GetAxis("Mouse ScrollWheel") > 0 && GetComponent<Camera>().orthographicSize < 18)
        {
            GetComponent<Camera>().orthographicSize += 1f;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0 && GetComponent<Camera>().orthographicSize > 5)
        {
            GetComponent<Camera>().orthographicSize -= 1f;
        }

        pos.x = Mathf.Clamp(pos.x, -70, -42);
        pos.z = Mathf.Clamp(pos.z, -70, -42);

        transform.position = pos;
    }

}
