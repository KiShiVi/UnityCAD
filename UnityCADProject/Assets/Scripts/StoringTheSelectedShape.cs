using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoringTheSelectedShape : MonoBehaviour
{
    public List<GameObject> Shapes;

    public Button deleteButton;

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
        //Shapes = new List<GameObject>();
    }

    private void Update()
    {
        properties.SetActive(selectionShape == null ? false : true);
        deleteButton.interactable = selectionShape == null ? false : true;
    }

    public void fillContent(GameObject obj)
    {
        List<string> info = getInfo(obj);
        positionX.text = info[0];
        positionY.text = info[1];
        positionZ.text = info[2];

        rotationX.text = info[3];
        rotationY.text = info[4];
        rotationZ.text = info[5];

        scaleX.text = info[6];
        scaleY.text = info[7];
        scaleZ.text = info[8];
    }

    public List<string> getInfo(GameObject obj)
    {
        return new List<string> {
            Math.Round(obj.GetComponent<Transform>().position.x, 2).ToString(),
            Math.Round(obj.GetComponent<Transform>().position.y, 2).ToString(),
            Math.Round(obj.GetComponent<Transform>().position.z, 2).ToString(),
            Math.Round(obj.GetComponent<Transform>().localEulerAngles.x, 2).ToString(),
            Math.Round(obj.GetComponent<Transform>().localEulerAngles.y, 2).ToString(),
            Math.Round(obj.GetComponent<Transform>().localEulerAngles.z, 2).ToString(),
            Math.Round(obj.GetComponent<Transform>().localScale.x, 2).ToString(),
            Math.Round(obj.GetComponent<Transform>().localScale.y, 2).ToString(),
            Math.Round(obj.GetComponent<Transform>().localScale.z, 2).ToString() };
    }
}
