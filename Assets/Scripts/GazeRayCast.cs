using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeRayCast : MonoBehaviour
{
    public Camera camera;

    public GazeTrigger gazeTrigger;

    void Update()
    {
        //create a vector in forward direction from the camera 
        Vector3 fwd = camera.transform.TransformDirection(Vector3.forward);
        //Debug draw line for your raycast
        Debug.DrawRay(camera.transform.position, fwd * 40, Color.green);

        RaycastHit hit;
        if (Physics.Raycast(camera.transform.position, fwd, out hit, 50))
        {
            Transform objectHit = hit.transform;

            Debug.Log(hit.transform.name);
            if (objectHit.name == "greek_column_1")
            {
                Debug.Log("fill the gaze ui notification");
                gazeTrigger.Fill();
            }

        }

        gazeTrigger.Clear();


    }
}
