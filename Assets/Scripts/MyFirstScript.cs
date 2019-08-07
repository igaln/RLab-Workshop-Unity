using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    public string UserName = "Todd";

    void Awake()
    {
      
    }
    // Start is called before the first //?//////////////////////////frame update
    public void Start()
    {
      //  Debug.Log("start");
    }

    // Update is called once per frame
    private void Update()
    {
       // Debug.Log("Update");
    }

    void FixedUpdate()
    {
        //Debug.Log("fixed Update");
    }

    void LateUpdate()
    {
        //Debug.Log("Late Update");
    }

    void Destroy()
    {
      //  Debug.Log("Destory");
    }
}
