using System;
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

    [NonSerialized]
    public List<GameObject> crossingShapes;

    void Start()
    {
        crossingShapes = new List<GameObject>();
    }

    private void OnTriggerEnter(Collider other)
    {
        crossingShapes.Add(other.gameObject);
    }

    private void OnTriggerExit(Collider other)
    {
        crossingShapes.Remove(other.gameObject);
    }

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
