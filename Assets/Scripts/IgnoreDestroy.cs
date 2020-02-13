using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreDestroy : MonoBehaviour
{
    // Start is called before the first frame update

    public Collider scoreAreaIgnore;
    public Collider leftHandGrabberLarge;
    public Collider leftHandGrabberSmall;
    public Collider rightHandGrabberLarge;
    public Collider rightHandGrabberSmall;

    void Start()
    {
        Physics.IgnoreCollision(scoreAreaIgnore, leftHandGrabberLarge);
        Physics.IgnoreCollision(scoreAreaIgnore, leftHandGrabberSmall);
        Physics.IgnoreCollision(scoreAreaIgnore, rightHandGrabberSmall);
        Physics.IgnoreCollision(scoreAreaIgnore, rightHandGrabberLarge);

    }

}
