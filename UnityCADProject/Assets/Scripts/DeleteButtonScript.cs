using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteButtonScript : MonoBehaviour
{
    public GameObject mainScript;
    public void onClick()
    {
        if (mainScript.GetComponent<StoringTheSelectedShape>().selectionShape.name.Replace("(Clone)", "") == "Light")
            mainScript.GetComponent<StoringTheSelectedShape>().Lights.Remove(mainScript.GetComponent<StoringTheSelectedShape>().selectionShape);
        else
            mainScript.GetComponent<StoringTheSelectedShape>().Shapes.Remove(mainScript.GetComponent<StoringTheSelectedShape>().selectionShape);
        Destroy(mainScript.GetComponent<StoringTheSelectedShape>().selectionShape);
        mainScript.GetComponent<StoringTheSelectedShape>().selectionShape = null;
    }
}
