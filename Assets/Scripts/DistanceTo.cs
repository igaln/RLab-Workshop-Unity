using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceTo : MonoBehaviour
{

	public Transform other;

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (other)
		{
			float dist = Vector3.Distance(other.position, transform.position);
			print("Distance to other: " + dist);
		}
	}


}
