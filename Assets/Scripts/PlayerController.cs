using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    public int speed = 10;
    public float barrierX = 18;
    public float barrierZ = 3;
    public GameObject kick;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
 
        if (transform.position.x > barrierX) 
        {
            transform.position = new Vector3(barrierX, transform.position.y, transform.position.z);
        }

        if (transform.position.x < -barrierX) 
        {
            transform.position = new Vector3(-barrierX, transform.position.y, transform.position.z);
        }

        if (transform.position.z > barrierZ) 
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, barrierZ);
        }

        if (transform.position.z < -barrierZ) 
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -barrierZ);
        }

        if (Input.GetKeyDown(KeyCode.Q)) 
        {
            Instantiate(kick, transform.position + new Vector3(0, 1, 1), kick.transform.rotation);
        }
    }

    void OnTriggerEnter(Collider other) 
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }

}
