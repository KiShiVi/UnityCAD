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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
