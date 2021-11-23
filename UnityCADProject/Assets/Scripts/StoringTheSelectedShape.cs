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
            Mathf.RoundToInt(obj.GetComponent<Transform>().position.x).ToString(),
            Mathf.RoundToInt(obj.GetComponent<Transform>().position.y).ToString(),
            Mathf.RoundToInt(obj.GetComponent<Transform>().position.z).ToString(),
            Mathf.RoundToInt(obj.GetComponent<Transform>().rotation.eulerAngles.x).ToString(),
            Mathf.RoundToInt(obj.GetComponent<Transform>().rotation.eulerAngles.y).ToString(),
            Mathf.RoundToInt(obj.GetComponent<Transform>().rotation.eulerAngles.z).ToString(),
            Mathf.RoundToInt(obj.GetComponent<Transform>().localScale.x).ToString(),
            Mathf.RoundToInt(obj.GetComponent<Transform>().localScale.y).ToString(),
            Mathf.RoundToInt(obj.GetComponent<Transform>().localScale.z).ToString()
            };
    }
}
