using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class CubeSliderAdjust : MonoBehaviour
{

    public Text lbrotationY;
    public Slider rotationY;
    Mesh mesh;

    // Initialization
    void Start()
    {
        mesh = GetComponent<MeshFilter>().mesh;
        mesh.MarkDynamic();
        gameObject.transform.localEulerAngles = new Vector3(gameObject.transform.rotation.x, (float)-45, gameObject.transform.rotation.z);
    }

    void Update()
    {
        mesh.RecalculateBounds();
        mesh.RecalculateNormals();
    }


    public void rotateY()
    {

        gameObject.transform.localEulerAngles = new Vector3(gameObject.transform.rotation.x, (float)rotationY.value, gameObject.transform.rotation.z);
        lbrotationY.text = "Rotation: " + Truncate(rotationY.value, 2).ToString() + " degrees";

    }
   

    public static float Truncate(float value, int digits)
    {
        double mult = Math.Pow(10.0, digits);
        double result = Math.Truncate(mult * value) / mult;
        return (float)result;
    }
}