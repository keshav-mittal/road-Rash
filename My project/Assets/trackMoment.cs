using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trackMoment : MonoBehaviour
{
    public float scrollspeed;
    public float maxspeed;
    Vector3 initpos;
    // Start is called before the first frame update
    void Start()
    {
        initpos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > (initpos + new Vector3(0, -92f, 0)).y)
        {
            if (maxspeed > scrollspeed)
            {
                scrollspeed += 0.1f * Time.deltaTime;
            }
            transform.position += Vector3.down * scrollspeed * Time.deltaTime;
        }
        else
            transform.position = initpos;
    }
}
