using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyspawning : MonoBehaviour
{
    public GameObject enemy;
    public Transform[] spawningPoint;
    int rand;
    void Start()
    {
        repeating();
    }
    void repeating()
    {
        rand = Random.Range(0, spawningPoint.Length);
        Instantiate(enemy, spawningPoint[rand].position, transform.rotation);
        Invoke("repeating", 3f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
