using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.Playables;

using System;
using UnityEngine.Events;
using Depthkit;

[Serializable]
public class TriggerThroughDistance : UnityEvent { }

public class DistanceTo : MonoBehaviour
{

    public TriggerThroughDistance triggerThroughDistance;

    public Transform other;

    public Depthkit_Clip myVolumetricClip;
    public Animator elvisAnimator;
    public PlayableDirector timeline;

    float VolumetricSpikeAmount = 0.6f;
    float DistanceAmountForTrigger = 5;
    float MaxSpikeFilter = 1.0f;

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

                print("Distance to Volumetric Clip: " + (5 - dist));

                //check if elvis animator is actually connected

                if ( (MaxSpikeFilter - (DistanceAmountForTrigger - dist)) > VolumetricSpikeAmount)
                {
                    myVolumetricClip._internalEdgeCutoffAngle = MaxSpikeFilter - (DistanceAmountForTrigger - dist);
                }

                triggerThroughDistance.Invoke();


                if (elvisAnimator != null)
                {
                   // print("start blending");
                    elvisAnimator.SetFloat("ElvisBlend", 5 - dist);
                   // timeline.Play();
                }
            }
			
		}
	}


}
