using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class ucgen_script : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ucgen;
    private float x = -5f;
    private float y = 1f;
    public float speed = 50f;
    public float zamanSayaci;
    public float respawn_time;
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
            Debug.Log("Mouse Down Ucgen");
            GameObject go = Instantiate(ucgen, new Vector3(x, y, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            go.GetComponent<Rigidbody2D>().AddForce(new Vector2(+speed + (Time.deltaTime * speed), 0));
            zamanSayaci = respawn_time;
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "ucgen")
        {
            Debug.Log("ucgen triggered!");
        }
        else if (other.tag == "kare")
        {
            Debug.Log("Game Over!");
        }
        else if (other.tag == "daire")
        {
            Debug.Log("Game Over!");
        }
    }
}
