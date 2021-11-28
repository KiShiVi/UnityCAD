using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;

public class SaveButton : MonoBehaviour
{
    public InputField projectName;
    public GameObject mainScript;
    public Toggle toggle;

    public void saveFile()
    {
        if (toggle.isOn)
            foreach (GameObject gameObject in mainScript.GetComponent<StoringTheSelectedShape>().Shapes)
            {
                if (gameObject.GetComponent<SelectMe>().crossingShapes.Count > 0)
                {
                    mainScript.GetComponent<StoringTheSelectedShape>().toLogText("File NOT saved");
                    return;
                }
            }

        DateTime thisDay = DateTime.UtcNow;
        //Debug.Log(Directory.GetCurrentDirectory() + "\\Saves\\" + projectName.text + "_" + thisDay.ToString().Replace(':', '_') + ".txt");

        System.IO.Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Saves\\");
        StreamWriter writer;

        if (projectName.text == "")
            writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Saves\\" + projectName.text + "_" + thisDay.ToString().Replace(':', '_') + ".txt");
        else
            writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Saves\\" + projectName.text + ".txt");
        foreach (GameObject obj in mainScript.GetComponent<StoringTheSelectedShape>().Shapes)
        {
            Transform temp = obj.GetComponent<Transform>();
            writer.WriteLine(obj.name.Replace("(Clone)", "") + " " + temp.position.x + " " + temp.position.y + " " + temp.position.z + " "
                               + temp.localEulerAngles.x + " " + temp.localEulerAngles.y + " " + temp.localEulerAngles.z + " "
                                + temp.localScale.x + " " + temp.localScale.y + " " + temp.localScale.z);
        }
        mainScript.GetComponent<StoringTheSelectedShape>().toLogText("File saved");
        writer.Close();
    }
}
