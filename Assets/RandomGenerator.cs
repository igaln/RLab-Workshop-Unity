using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGenerator : MonoBehaviour
{

    public GameObject prefab;

    // Update is called once per frame
    void Update()
    {
        Vector3 position = new Vector3(Random.Range(-50.0f, 50.0f), Random.Range(10.0f, 50.0f), Random.Range(-50.0f,50.0f));
        Instantiate(prefab, position, Quaternion.identity);
    }
}
