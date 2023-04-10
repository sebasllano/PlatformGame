using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] enemigo;
    public GameObject spawnObject;
    public float temporizador;
    public float tiempoEntreSpawns;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        temporizador += Time.deltaTime;
        if (temporizador > tiempoEntreSpawns)
        {
            temporizador = 0;
            int randNums = Random.Range(0, 2);
            Instantiate(spawnObject, enemigo[randNums].transform.position, Quaternion.identity);
           
        }

    }
}
