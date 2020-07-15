using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Propeller : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * 40);
    }
}
