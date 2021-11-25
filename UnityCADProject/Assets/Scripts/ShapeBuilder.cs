using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeBuilder : MonoBehaviour
{
    public GameObject friendlyOnClick;
    public GameObject mainScript;
    public void buildShape(GameObject shape, List<int> coords=null)
    {
        GameObject newObj = Instantiate(shape, new Vector3(0, 0, 0), Quaternion.Euler(0, 0, 0));
        if (coords != null)
        {
            newObj.GetComponent<Transform>().position = new Vector3((float)coords[0], (float)coords[1], (float)coords[2]);
            newObj.GetComponent<Transform>().rotation = Quaternion.Euler((float)coords[3], (float)coords[4], (float)coords[5]);
            newObj.GetComponent<Transform>().localScale = new Vector3((float)coords[6], (float)coords[7], (float)coords[8]);
        }
        mainScript.GetComponent<StoringTheSelectedShape>().Shapes.Add(newObj);
        newObj.SetActive(true);
        friendlyOnClick.GetComponent<SelectMe>().choiseSelectionShape(newObj);
    }
}
