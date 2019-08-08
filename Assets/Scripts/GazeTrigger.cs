using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

using System;

[Serializable]
public class GazeTriggerComplete : UnityEvent { }


public class GazeTrigger : MonoBehaviour
{
    [SerializeField]
    public GazeTriggerComplete triggerComplete;

    public Image reticle;

    bool isFilling = false;

    public void Clear()
    {
        isFilling = false;
    }

    public void Fill()
    {
        isFilling = true;
        if(reticle.fillAmount < 1)
        {
            reticle.fillAmount += 0.005f;
        }
       
        if(reticle.fillAmount >= 1)
        {
            Debug.Log("GO");

            //trigger my custom event
            triggerComplete.Invoke();
        }
    }

    public void Update()
    {
        //if (!isFilling && reticle.fillAmount > 0)
        //{
        //    reticle.fillAmount -= 0.01f;
        //}
      
    }


}
