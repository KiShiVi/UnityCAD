using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeBuilder : MonoBehaviour
{
    public GameObject friendlyOnClick;
    public GameObject mainScript;
    public void buildShape(GameObject shape, List<float> coords=null)
    {
        GameObject newObj = Instantiate(shape, new Vector3(0, 0, 0), Quaternion.Euler(0, 0, 0));
        if (coords != null)
        {
            newObj.GetComponent<Transform>().position = new Vector3(coords[0], coords[1], coords[2]);
            newObj.GetComponent<Transform>().rotation = Quaternion.Euler(coords[3], coords[4], coords[5]);
            newObj.GetComponent<Transform>().localScale = new Vector3(coords[6], coords[7], coords[8]);
        }
        mainScript.GetComponent<StoringTheSelectedShape>().Shapes.Add(newObj);
        newObj.SetActive(true);
        friendlyOnClick.GetComponent<SelectMe>().choiseSelectionShape(newObj);
    }
}
