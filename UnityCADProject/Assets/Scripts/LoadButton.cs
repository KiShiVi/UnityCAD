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
                    mainScript.GetComponent<ShapeBuilder>().buildShape(sphere, new List<int>(){
                        int.Parse(shapeParameters[1]), int.Parse(shapeParameters[2]), int.Parse(shapeParameters[3]),
                        int.Parse(shapeParameters[4]), int.Parse(shapeParameters[5]), int.Parse(shapeParameters[6]),
                        int.Parse(shapeParameters[7]), int.Parse(shapeParameters[8]), int.Parse(shapeParameters[9]) });
                    break;
                case "Cube":
                    mainScript.GetComponent<ShapeBuilder>().buildShape(cube, new List<int>(){
                        int.Parse(shapeParameters[1]), int.Parse(shapeParameters[2]), int.Parse(shapeParameters[3]),
                        int.Parse(shapeParameters[4]), int.Parse(shapeParameters[5]), int.Parse(shapeParameters[6]),
                        int.Parse(shapeParameters[7]), int.Parse(shapeParameters[8]), int.Parse(shapeParameters[9]) });
                    break;
                case "Cylinder":
                    mainScript.GetComponent<ShapeBuilder>().buildShape(cylinder, new List<int>(){
                        int.Parse(shapeParameters[1]), int.Parse(shapeParameters[2]), int.Parse(shapeParameters[3]),
                        int.Parse(shapeParameters[4]), int.Parse(shapeParameters[5]), int.Parse(shapeParameters[6]),
                        int.Parse(shapeParameters[7]), int.Parse(shapeParameters[8]), int.Parse(shapeParameters[9]) });
                    break;
            }
        }

        reader.Close();
    }
}
