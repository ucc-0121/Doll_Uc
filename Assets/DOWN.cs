using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DOWN : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void downit()
    {
        transform.Translate(0, -0.3f, 0);
    }
}
