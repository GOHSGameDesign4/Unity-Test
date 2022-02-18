using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("I'm a talking circle!");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, Time.deltaTime, 0);
    }
}
