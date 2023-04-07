using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class controler : MonoBehaviour
{
    public Vector3 CarPosition;
    public float CarSpeed = 5f;
    public float maxleft, maxright;
    public UImanager ui;
    // Start is called before the first frame update
    void Start()
    {
        CarPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
            
            CarPosition.x += Input.GetAxis("Horizontal") * CarSpeed * Time.deltaTime;
            CarPosition.x = Mathf.Clamp(CarPosition.x, maxleft, maxright);
            transform.position = CarPosition;
        


    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
            ui.gameOverActivated();
            ui.pause();
        }
    }
};

