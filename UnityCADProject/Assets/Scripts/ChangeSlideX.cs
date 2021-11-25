using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSlideX : MonoBehaviour
{
    public GameObject mainScript;
    public Dropdown choice;
    public float sensitivity;

    public void change()
    {
        Transform curTrans = mainScript.GetComponent<StoringTheSelectedShape>().selectionShape.GetComponent<Transform>();
        switch (choice.value)
        {
            case 0:
                while (!Input.GetKeyUp(KeyCode.Mouse1))
                    curTrans.position += new Vector3(sensitivity * this.GetComponent<Slider>().value, 0f, 0f);
                break;
            case 1:
                break;
            case 2:
                break;
        }
    }
}
