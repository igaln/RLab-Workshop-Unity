using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class GazeTrigger : MonoBehaviour
{


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
            reticle.fillAmount += 0.01f;
        }
       
        if(reticle.fillAmount > 1)
        {
            Debug.Log("GO");
        }
    }

    public void Update()
    {
        if (!isFilling && reticle.fillAmount > 0)
        {
            reticle.fillAmount -= 0.01f;
        }
      
    }


}
