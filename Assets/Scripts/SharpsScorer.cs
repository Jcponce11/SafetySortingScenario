using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class SharpsScorer : MonoBehaviour
{
    public PointsManager manager;
    public VRTK_SnapDropZone snapDropZone;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Sharps"))
        { 

            manager.AddPoints(1);
            snapDropZone.ForceUnsnap();
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Trash"))
        {
            manager.WarningMessage("That should've gone in the Trash!");
            snapDropZone.ForceUnsnap();
            Destroy(other.gameObject);
        }

        else if (other.gameObject.CompareTag("BioHazard"))
        {
            manager.WarningMessage("That should've gone in the Biohazard Bin!");
            snapDropZone.ForceUnsnap();
            Destroy(other.gameObject);
        }
    }
}
