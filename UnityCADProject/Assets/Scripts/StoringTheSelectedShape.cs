using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoringTheSelectedShape : MonoBehaviour
{
    public GameObject selectionShape;
    public GameObject properties;

    void Start()
    {
        selectionShape = null;
        properties.SetActive(false);
    }

    private void Update()
    {
        properties.SetActive(selectionShape == null ? false : true);
    }
}
