using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public int difficulty = 1;



    public GameObject Enemy;

    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemy(difficulty);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnEnemy(int dificulty)
    {
        switch (Random.Range(0,15)+dificulty)
        {
            case 13:
                Instantiate(Enemy, transform.position, transform.rotation);
                break;
        }
                
    }

}
