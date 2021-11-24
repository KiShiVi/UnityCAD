using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeBuilder : MonoBehaviour
{
    public GameObject friendlyOnClick;
    public GameObject mainScript;
    public void buildShape(GameObject shape)
    {
        GameObject newObj = Instantiate(shape, new Vector3(0, 0, 0), new Quaternion(0, 0, 0, 0));
        mainScript.GetComponent<StoringTheSelectedShape>().Shapes.Add(newObj);
        newObj.SetActive(true);
        friendlyOnClick.GetComponent<SelectMe>().choiseSelectionShape(newObj);
    }
}
