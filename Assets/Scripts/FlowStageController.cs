using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowStageController : MonoBehaviour
{
    float speed = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += speed * Time.deltaTime * Vector3.left;
    }
}
