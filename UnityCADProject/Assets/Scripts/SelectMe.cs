using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SelectMe : MonoBehaviour
{
    public GameObject mainScript;
    public Material selectionMaterial;
    public Material standartMaterial;

    public Text positionX;
    public Text positionY;
    public Text positionZ;
    public Text rotationX;
    public Text rotationY;
    public Text rotationZ;
    public Text scaleX;
    public Text scaleY;
    public Text scaleZ;

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

        positionX.text = Mathf.RoundToInt(this.gameObject.GetComponent<Transform>().position.x).ToString();
        positionY.text = Mathf.RoundToInt(this.gameObject.GetComponent<Transform>().position.y).ToString();
        positionZ.text = Mathf.RoundToInt(this.gameObject.GetComponent<Transform>().position.z).ToString();

        rotationX.text = Mathf.RoundToInt(this.gameObject.GetComponent<Transform>().rotation.eulerAngles.x).ToString();
        rotationY.text = Mathf.RoundToInt(this.gameObject.GetComponent<Transform>().rotation.eulerAngles.y).ToString();
        rotationZ.text = Mathf.RoundToInt(this.gameObject.GetComponent<Transform>().rotation.eulerAngles.z).ToString();

        scaleX.text = Mathf.RoundToInt(this.gameObject.GetComponent<Transform>().localScale.x).ToString();
        scaleY.text = Mathf.RoundToInt(this.gameObject.GetComponent<Transform>().localScale.y).ToString();
        scaleZ.text = Mathf.RoundToInt(this.gameObject.GetComponent<Transform>().localScale.z).ToString();
    }
}
