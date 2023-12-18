using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sunRotate : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 vectorsun;
    // Start is called before the first frame update
    void Start()
    {
        vectorsun = new Vector3(0, 0.07f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(vectorsun);
    }
}
