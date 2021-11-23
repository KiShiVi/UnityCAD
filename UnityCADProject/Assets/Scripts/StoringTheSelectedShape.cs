using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoringTheSelectedShape : MonoBehaviour
{
    public GameObject selectionShape;
    public GameObject properties;

    public Text positionX;
    public Text positionY;
    public Text positionZ;
    public Text rotationX;
    public Text rotationY;
    public Text rotationZ;
    public Text scaleX;
    public Text scaleY;
    public Text scaleZ;

    void Start()
    {
        selectionShape = null;
        properties.SetActive(false);
    }

    private void Update()
    {
        properties.SetActive(selectionShape == null ? false : true);
    }

    public void fillContent(GameObject obj)
    {
        positionX.text = Mathf.RoundToInt(obj.GetComponent<Transform>().position.x).ToString();
        positionY.text = Mathf.RoundToInt(obj.GetComponent<Transform>().position.y).ToString();
        positionZ.text = Mathf.RoundToInt(obj.GetComponent<Transform>().position.z).ToString();

        rotationX.text = Mathf.RoundToInt(obj.GetComponent<Transform>().rotation.eulerAngles.x).ToString();
        rotationY.text = Mathf.RoundToInt(obj.GetComponent<Transform>().rotation.eulerAngles.y).ToString();
        rotationZ.text = Mathf.RoundToInt(obj.GetComponent<Transform>().rotation.eulerAngles.z).ToString();

        scaleX.text = Mathf.RoundToInt(obj.GetComponent<Transform>().localScale.x).ToString();
        scaleY.text = Mathf.RoundToInt(obj.GetComponent<Transform>().localScale.y).ToString();
        scaleZ.text = Mathf.RoundToInt(obj.GetComponent<Transform>().localScale.z).ToString();
    }

}
