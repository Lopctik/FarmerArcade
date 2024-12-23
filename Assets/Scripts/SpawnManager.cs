using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animals;
    private int _animalIndex;
    private int _xCoord;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 5, 1);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void  SpawnEnemy()
    {
        _animalIndex = Random.Range(0, animals.Length);
        _xCoord = Random.Range(-18, 18);
        Instantiate(animals[_animalIndex], new Vector3(_xCoord, 0, 33) ,animals[_animalIndex].transform.rotation);
    }
    
}
