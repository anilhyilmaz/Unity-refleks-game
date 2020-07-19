using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class daire_carpisma_script : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject daire;
    public GameObject ggg;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "daire")
        {
            Destroy(daire);
        }
        if (other.gameObject.tag == "ucgen")
        {
            Destroy(ggg.gameObject.GetComponent<deneme_script>());

        }
        if (other.gameObject.tag == "kare")
        {
            Destroy(ggg.gameObject.GetComponent<deneme_script>());
        }
    }
}
