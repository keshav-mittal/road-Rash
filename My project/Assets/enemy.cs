using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public float enemySpeed;
    public float maxspeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     transform.Translate(Vector3.up*enemySpeed*Time.deltaTime);
        if (maxspeed > enemySpeed)
        {
            enemySpeed += 0.1f * Time.deltaTime;
        }
        if (transform.position.y < -12.4)
        {
            Destroy(gameObject);
        }
      
    }
}
