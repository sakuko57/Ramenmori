using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMoveController : MonoBehaviour
{
    public float speed = 3.0f;
    public float MovingDistance = 0.5f;
    private float StartPos;
    

    // Start is called before the first frame update
    void Start()
    {
        StartPos = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += speed * Time.deltaTime * Vector3.left;

        gameObject.transform.position = new Vector3(transform.position.x,StartPos + Mathf.PingPong(Time.time*1f,MovingDistance),transform.position.z);
       
    }
}

