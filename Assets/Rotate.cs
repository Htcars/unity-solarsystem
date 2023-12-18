using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Vector3 vector3;
    // Start is called before the first frame update
    void Start()
    {
        vector3 = new Vector3(0, 0.07f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(vector3);
    }
}
