using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BioHazardScorer : MonoBehaviour
{
    public PointsManager manager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BioHazard"))
        {
            manager.AddPoints(1);
            manager.ObjectDestroyer(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Sharps"))
        {
            manager.WarningMessage("That Should've gone in the Sharps Container!");
            manager.ObjectDestroyer(other.gameObject);
        }

        else if (other.gameObject.CompareTag("Trash"))
        {
            manager.WarningMessage("That should've gone in the Trash!");
            manager.ObjectDestroyer(other.gameObject);
        }
    }
}
