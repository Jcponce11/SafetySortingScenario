using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyAreaScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        print("destroyHit");
    }
}
