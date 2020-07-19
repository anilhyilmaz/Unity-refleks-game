using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kare_script : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject kare;
    private float x = -5f;
    private float y = 1f;
    public float speed = 50f;
    public float zamanSayaci = 3f;
    public float respawn_time = 3f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        zamanSayaci = zamanSayaci - Time.deltaTime;
        
    }
    public void OnMouseDown()
    {
        if (zamanSayaci < 0)
        {
            Debug.Log("Mouse Down Kare");
            GameObject go = Instantiate(kare, new Vector3(x, y, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            go.GetComponent<Rigidbody2D>().AddForce(new Vector2(+speed + (Time.deltaTime * speed), 0));
            zamanSayaci = respawn_time;
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "kare")
        {
            Debug.Log("kare triggered!");
        }
        else if(other.tag == "ucgen")
        {
            Debug.Log("Game Over!");
        }
        else if (other.tag == "daire")
        {
            Debug.Log("Game Over!");
        }
    }
    

}
