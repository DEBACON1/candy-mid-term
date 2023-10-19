using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject candy0, candy1, candy2, candy3, candy4, candy5;
    public float spawnRate = 3;
    private float timer = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            Instantiate(candy0, transform.position, transform.rotation);
            timer = 0;
        }
    }
}
