using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeRayCast : MonoBehaviour
{
    public Camera camera;
    public GazeTrigger gazeTrigger;

    void Update()
    {
        Vector3 fwd = camera.transform.TransformDirection(Vector3.forward);
        Debug.DrawRay(camera.transform.position, fwd * 40, Color.green);

        RaycastHit hit;
        if (Physics.Raycast(camera.transform.position, fwd, out hit, 50))
        {
            Transform objectHit = hit.transform;

            Debug.Log(hit.transform.name);
            if (objectHit.name == "Elvis")
            {
                Debug.Log("fill");
                gazeTrigger.Fill();
            }

        }

        gazeTrigger.Clear();


    }
}
