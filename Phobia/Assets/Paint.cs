using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paint : MonoBehaviour
{
    // Start is called before the first frame update

    Vector3 newPos;
    public Texture3D paperText;
    //public GameObject paper;
    int newX, newY, newZ;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        newPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        newPos.z = this.transform.position.z;
        newX = (int)newPos.x;
        newY = (int)newPos.y;
        newZ = (int)newPos.z;
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("a");
            //Debug.Log(paperText.GetPixel(newX, newY, newZ));
            //if (paperText.GetPixel)
        }
        //Debug.Log(newPos);
    }
}
