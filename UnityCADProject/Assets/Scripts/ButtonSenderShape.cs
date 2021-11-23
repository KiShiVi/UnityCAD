using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSenderShape : MonoBehaviour
{
    public GameObject shapeBuilder;
    public GameObject shape;
    public void onClick()
    {
        shapeBuilder.GetComponent<ShapeBuilder>().buildShape(shape);
    }
}
