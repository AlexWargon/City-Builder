using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapToGrid : MonoBehaviour
{

    public float grid = 1f;

    float x = 0f;
    float y = 0f;
    float z = 0f;

    void Update()
    {

        if(grid > 0f)
        { 
        float reciprocalGrid = 1f / grid;

        x = Mathf.Round(transform.position.x * reciprocalGrid) / reciprocalGrid;
        y = Mathf.Round(transform.position.y * reciprocalGrid) / reciprocalGrid;
        z = Mathf.Round(transform.position.z * reciprocalGrid) / reciprocalGrid;

        transform.position = new Vector3(x, y, z);
        }
    }
}
