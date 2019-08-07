using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionController : MonoBehaviour
{
	public Animator animator;
    public float blendAmount = 0;
    // Start is called before the first frame update
    void Start()
    {
      //  animator.SetInteger("Ready", 2);
        animator.SetFloat("Blend", blendAmount);
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Blend", blendAmount);
    }
}
