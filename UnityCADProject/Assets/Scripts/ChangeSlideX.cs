using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSlideX : MonoBehaviour
{
    public GameObject mainScript;
    public Dropdown choice;
    public float sensitivity;
    public float rotationSensitivity;
    GameObject go;

    void Update()
    {
        go = mainScript.GetComponent<StoringTheSelectedShape>().selectionShape;

        if (this.GetComponent<Slider>().value != 0f)
        {
            switch (choice.value)
            {
                case 0:
                    go.GetComponent<Transform>().position += new Vector3(this.GetComponent<Slider>().value * sensitivity * Time.deltaTime, 0f, 0f);
                    mainScript.GetComponent<StoringTheSelectedShape>().fillContent(go);
                    break;
                case 1:
                    go.GetComponent<Transform>().Rotate(this.GetComponent<Slider>().value * rotationSensitivity * Time.deltaTime, 0f, 0f);
                    //go.GetComponent<Transform>().localEulerAngles += new Vector3(this.GetComponent<Slider>().value * rotationSensitivity, 0f, 0f);
                    mainScript.GetComponent<StoringTheSelectedShape>().fillContent(go);
                    break;
                case 2:
                    go.GetComponent<Transform>().localScale += new Vector3(this.GetComponent<Slider>().value * sensitivity * Time.deltaTime, 0f, 0f);
                    mainScript.GetComponent<StoringTheSelectedShape>().fillContent(go);
                    break;
            }
        }

        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            this.GetComponent<Slider>().value = 0;
        }
    }
}
