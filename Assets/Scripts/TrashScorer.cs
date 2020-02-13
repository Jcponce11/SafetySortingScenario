using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashScorer : MonoBehaviour
{
    public PointsManager manager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Trash"))
        {
            manager.AddPoints(1);
            manager.ObjectDestroyer(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Sharps"))
        {
            manager.WarningMessage("That should've gone in the Sharps container!");
            manager.ObjectDestroyer(other.gameObject);
        }

        else if (other.gameObject.CompareTag("BioHazard"))
        {
            manager.WarningMessage("That should've gone in the Biohazard Bin!");
            manager.ObjectDestroyer(other.gameObject);
        }
    }
}
