using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ApplyPropertiesButton : MonoBehaviour
{
    public GameObject mainScript;

    public InputField positionX;
    public InputField positionY;
    public InputField positionZ;
    public InputField rotationX;
    public InputField rotationY;
    public InputField rotationZ;
    public InputField scaleX;
    public InputField scaleY;
    public InputField scaleZ;

    public void onClick()
    {
        List<string> info = mainScript.GetComponent<StoringTheSelectedShape>().getInfo(mainScript.GetComponent<StoringTheSelectedShape>().selectionShape);
        mainScript.GetComponent<StoringTheSelectedShape>().selectionShape.GetComponent<Transform>().position =
            new Vector3(float.Parse(positionX.text == "" ? info[0] : positionX.text), 
            float.Parse(positionY.text == "" ? info[1] : positionY.text), 
            float.Parse(positionZ.text == "" ? info[2] : positionZ.text));

        mainScript.GetComponent<StoringTheSelectedShape>().selectionShape.GetComponent<Transform>().localEulerAngles =
            new Vector3(float.Parse(rotationX.text == "" ? info[3] : rotationX.text), 
            float.Parse(rotationY.text == "" ? info[4] : rotationY.text), 
            float.Parse(rotationZ.text == "" ? info[5] : rotationZ.text));

        mainScript.GetComponent<StoringTheSelectedShape>().selectionShape.GetComponent<Transform>().localScale =
            new Vector3(float.Parse(scaleX.text == "" ? info[6] : scaleX.text), 
            float.Parse(scaleY.text == "" ? info[7] : scaleY.text), 
            float.Parse(scaleZ.text == "" ? info[8] : scaleZ.text));

            positionX.text = "";
            positionY.text = "";
            positionZ.text = "";
            rotationX.text = "";
            rotationY.text = "";
            rotationZ.text = "";
            scaleX.text = "";
            scaleY.text = "";
            scaleZ.text = "";

    mainScript.GetComponent<StoringTheSelectedShape>().fillContent(mainScript.GetComponent<StoringTheSelectedShape>().selectionShape);

    }
}
