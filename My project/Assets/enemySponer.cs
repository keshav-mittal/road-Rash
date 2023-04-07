using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySponer : MonoBehaviour
{
    public GameObject [] enemyPrefab;
    public float delaytimer = 1f;
    float timer;
    public float maxenemyleft;
    public float maxenemyright;
    // Start is called before the first frame update
    void Start()
    {
        timer = delaytimer;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            Vector3 spawnpos = new Vector3(Random.Range(maxenemyleft, maxenemyright),transform.position.y,transform.position.z);
            int randomindex = Random.Range(0, 2);
            Instantiate(enemyPrefab[randomindex], spawnpos, transform.rotation);
            timer = delaytimer;
        }
    }
}
