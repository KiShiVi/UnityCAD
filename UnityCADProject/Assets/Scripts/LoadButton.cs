using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;
using UnityEngine.UI;

public class LoadButton : MonoBehaviour
{
    public GameObject sphere;
    public GameObject cube;
    public GameObject cylinder;
    public GameObject mainScript;
    public InputField projectName;

    public void loadFile()
    {
        if (!File.Exists(Directory.GetCurrentDirectory() + "\\Saves\\" + projectName.text + ".txt"))
            return;

        StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + "\\Saves\\" + projectName.text + ".txt");

        foreach (GameObject obj in mainScript.GetComponent<StoringTheSelectedShape>().Shapes)
        {
            Destroy(obj);
        }

        mainScript.GetComponent<StoringTheSelectedShape>().Shapes = new List<GameObject>();
        mainScript.GetComponent<StoringTheSelectedShape>().selectionShape = null;

        List<string> infoShape = reader.ReadToEnd().Split('\n').ToList();

        foreach (string oneInfoShape in infoShape)
        {
            List<string> shapeParameters = oneInfoShape.Split(' ').ToList();
            switch (shapeParameters[0])
            {
                case "Sphere":
                    mainScript.GetComponent<ShapeBuilder>().buildShape(sphere, new List<float>(){
                        float.Parse(shapeParameters[1]), float.Parse(shapeParameters[2]), float.Parse(shapeParameters[3]),
                        float.Parse(shapeParameters[4]), float.Parse(shapeParameters[5]), float.Parse(shapeParameters[6]),
                        float.Parse(shapeParameters[7]), float.Parse(shapeParameters[8]), float.Parse(shapeParameters[9]) });
                    break;
                case "Cube":
                    mainScript.GetComponent<ShapeBuilder>().buildShape(cube, new List<float>(){
                        float.Parse(shapeParameters[1]), float.Parse(shapeParameters[2]), float.Parse(shapeParameters[3]),
                        float.Parse(shapeParameters[4]), float.Parse(shapeParameters[5]), float.Parse(shapeParameters[6]),
                        float.Parse(shapeParameters[7]), float.Parse(shapeParameters[8]), float.Parse(shapeParameters[9]) });
                    break;
                case "Cylinder":
                    mainScript.GetComponent<ShapeBuilder>().buildShape(cylinder, new List<float>(){
                        float.Parse(shapeParameters[1]), float.Parse(shapeParameters[2]), float.Parse(shapeParameters[3]),
                        float.Parse(shapeParameters[4]), float.Parse(shapeParameters[5]), float.Parse(shapeParameters[6]),
                        float.Parse(shapeParameters[7]), float.Parse(shapeParameters[8]), float.Parse(shapeParameters[9]) });
                    break;
            }
        }

        reader.Close();
    }
}
