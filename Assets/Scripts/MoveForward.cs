using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [Range(0, 70)] public int speed;
    public int topRangeZ = 35;
    public int downRangeZ = -10;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (transform.position.z > topRangeZ)
        {
            Destroy(gameObject);
        }

        if (transform.position.z < downRangeZ)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other) 
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
