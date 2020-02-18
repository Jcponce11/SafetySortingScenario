using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class GameObjectChanger : MonoBehaviour
{
    public MeshFilter HighlightObjectAlias;
    public GameObject orbitObject;
    private MeshFilter orbitObjectMesh;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        HighlightObjectAlias = orbitObjectMesh;
        
    }

    void OnTriggerEnter(Collider orbitObjectCollision)
    {
        if (orbitObjectCollision.GetComponent<VRTK_InteractableObject>().IsGrabbed())
        {
            orbitObjectMesh = orbitObjectCollision.GetComponentInChildren<MeshFilter>();
            Debug.Log(orbitObjectCollision.name);
        }
    }
}
