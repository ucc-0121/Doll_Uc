using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RotateMode : MonoBehaviour
{
    public Transform modelTransform;
    private bool isRotate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            transform.rotation *= Quaternion.Euler(new Vector3(0, 1.0f, 0));
        }
        if (Input.GetMouseButton(1) )
        {
            transform.rotation *= Quaternion.Euler(new Vector3(0, 0, 1.0f));
        }
        if (isRotate)
        {
            var currentPoint = Input.mousePosition;
            //var x = startPoint.x - currentPoint.x;
        }
        
    }
}
