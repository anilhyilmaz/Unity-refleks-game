using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class deneme_script : MonoBehaviour
{
    // Start is called before the first frame update
    private float x = 7.5f;
    private float y = 1f;
    public GameObject kare, daire,ucgen;
    public GameObject[] list;
    public float speed = 5f;
    public float zamanSayaci = 2f;
    public float respawn_time = 6f;
    public int point;
    public Text _game_over_text;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        zamanSayaci -= Time.deltaTime;
        if (zamanSayaci < 0)
        {
            int i = Random.Range(0,3);
            GameObject go = Instantiate(list[i], new Vector3(x, y, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            go.GetComponent<Rigidbody2D>().AddForce(new Vector2(-speed+(Time.deltaTime*speed),0));
            zamanSayaci = respawn_time;
        }
    }
}
