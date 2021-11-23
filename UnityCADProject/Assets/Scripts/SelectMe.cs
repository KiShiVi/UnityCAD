using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectMe : MonoBehaviour
{
    public GameObject mainScript;
    public Material selectionMaterial;
    public Material standartMaterial;

    public void OnMouseUp()
    {
        if (mainScript.GetComponent<StoringTheSelectedShape>().selectionShape == this.gameObject)
            return;

        this.GetComponent<MeshRenderer>().material = selectionMaterial;
        if (mainScript.GetComponent<StoringTheSelectedShape>().selectionShape != null)
        {
            mainScript.GetComponent<StoringTheSelectedShape>().selectionShape.GetComponent<MeshRenderer>().material = standartMaterial;
        }
        mainScript.GetComponent<StoringTheSelectedShape>().selectionShape = this.gameObject;

        mainScript.GetComponent<StoringTheSelectedShape>().fillContent(this.gameObject);
    }
}
