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
    public Material lightMaterial;
    public Material selectionLightMaterial;

    [NonSerialized]
    public List<GameObject> crossingShapes;

    [NonSerialized]
    public List<GameObject> crossingLights;

    void Start()
    {
        crossingShapes = new List<GameObject>();
        crossingLights = new List<GameObject>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Replace("(Clone)", "") != "Light")
            crossingShapes.Add(other.gameObject);
        else
            crossingLights.Add(other.gameObject);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name.Replace("(Clone)", "") != "Light")
            crossingShapes.Remove(other.gameObject);
        else
            crossingLights.Remove(other.gameObject);
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

        if (obj.name.Replace("(Clone)", "") == "Light")
            obj.transform.Find("Sphere").GetComponent<MeshRenderer>().material = selectionLightMaterial;
        else
            obj.GetComponent<MeshRenderer>().material = selectionMaterial;

        if (mainScript.GetComponent<StoringTheSelectedShape>().selectionShape != null)
        {
            if (mainScript.GetComponent<StoringTheSelectedShape>().selectionShape.name.Replace("(Clone)", "") == "Light")
                mainScript.GetComponent<StoringTheSelectedShape>().selectionShape.transform.Find("Sphere").GetComponent<MeshRenderer>().material = lightMaterial;
            else
                mainScript.GetComponent<StoringTheSelectedShape>().selectionShape.GetComponent<MeshRenderer>().material = standartMaterial;
        }
        mainScript.GetComponent<StoringTheSelectedShape>().selectionShape = obj.gameObject;

        mainScript.GetComponent<StoringTheSelectedShape>().fillContent(obj.gameObject);
    }
}
