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
        choiseSelectionShape(this.gameObject);
    }

    public void choiseSelectionShape(GameObject obj)
    {
        if (mainScript.GetComponent<StoringTheSelectedShape>().selectionShape == obj.gameObject)
            return;

        obj.GetComponent<MeshRenderer>().material = selectionMaterial;
        if (mainScript.GetComponent<StoringTheSelectedShape>().selectionShape != null)
        {
            mainScript.GetComponent<StoringTheSelectedShape>().selectionShape.GetComponent<MeshRenderer>().material = standartMaterial;
        }
        mainScript.GetComponent<StoringTheSelectedShape>().selectionShape = obj.gameObject;

        mainScript.GetComponent<StoringTheSelectedShape>().fillContent(obj.gameObject);
    }
}
