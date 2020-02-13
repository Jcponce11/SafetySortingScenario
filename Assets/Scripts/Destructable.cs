using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructable : MonoBehaviour
{
    public void destroyDestructable(GameObject other)
    {
        print("is Destroyed");
        Destroy(gameObject);
    }
}
