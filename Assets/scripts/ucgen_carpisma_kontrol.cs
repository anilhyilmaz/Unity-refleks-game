using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ucgen_carpisma_kontrol : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ucgen;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "ucgen")
        {
            Destroy(ucgen);
        }
    }
}
