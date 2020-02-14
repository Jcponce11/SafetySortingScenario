using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class CanvasClicker : MonoBehaviour
{
    private VRTK_InteractableObject thisInteractor;
    private ProximityActivate thisProximityActivator;

    // Start is called before the first frame update
    void Start()
    {
        thisInteractor = GetComponent<VRTK_InteractableObject>();
        thisProximityActivator = GetComponentInChildren<ProximityActivate>();
        thisProximityActivator.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (thisInteractor.IsGrabbed())
        {
            thisProximityActivator.gameObject.SetActive(true);
        }
        else if(thisInteractor.IsGrabbed() == false)
        {
            thisProximityActivator.gameObject.SetActive(false);
        }
    }
}
