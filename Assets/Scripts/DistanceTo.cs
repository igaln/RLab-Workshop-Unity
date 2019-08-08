using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.Playables;

public class DistanceTo : MonoBehaviour
{

	public Transform other;
    public Animator elvisAnimator;
    public PlayableDirector timeline;

    private void Start()
    {
        timeline.Pause();
    }

    // Update is called once per frame
    void Update()
    {
		if (other)
		{
            //other is the variable passing to the script
            //transform refers to the gameobject this is attached to
			float dist = Vector3.Distance(other.position, transform.position);

            if (dist < 5)
            {
                print("Distance to other: " + (5 - dist));
                //check if elvis animator is actually connected
                if (elvisAnimator != null)
                {
                   // print("start blending");
                    elvisAnimator.SetFloat("ElvisBlend", 5 - dist);
                    timeline.Play();
                }
            }
			
		}
	}


}
