using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenderQueuenum : MonoBehaviour
{
    public int RenderQueueNum;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<MeshRenderer>().material.renderQueue = RenderQueueNum;
    }


}
