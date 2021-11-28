using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectMe : MonoBehaviour, IPointerClickHandler
{
    public GameObject mainScript;
    public Material selectionMaterial;
    public Material standartMaterial;
    public Material redMaterial;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
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
