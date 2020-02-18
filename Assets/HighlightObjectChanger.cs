using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightObjectChanger : MonoBehaviour
{
    public MeshFilter aliasObject;
    public GameObjectChanger gameObjectPassThrough;
    public MeshFilter thisMeshFilter;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        aliasObject = gameObjectPassThrough.HighlightObjectAlias;
        thisMeshFilter.mesh = aliasObject.mesh;
    }
}
