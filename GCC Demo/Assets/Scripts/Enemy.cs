using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public GameObject endPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position,
            new Vector3(endPoint.transform.position.x, transform.position.y, 0),
            step);
        if (transform.position.x <= endPoint.transform.position.x) Destroy(this.gameObject);
    }
}
