using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClick : MonoBehaviour {

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform.gameObject.tag == "Finish")
                {
                    PrintInfo(hit.transform.gameObject.GetComponent<ObjectInfoScipt>());
                }
            }
        }

    }
    private void PrintInfo(ObjectInfoScipt go)
    {
        print(go.objName);
        print(go.size);
    }
}
