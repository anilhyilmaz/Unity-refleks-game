using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kare_carpisma_kontrol : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject kare;
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
        if (other.gameObject.tag == "kare")
        {
            Destroy(kare);
        }
        if(other.gameObject.tag == "ucgen")
        {
            Destroy(ggg.gameObject.GetComponent<deneme_script>());

        }
        if(other.gameObject.tag == "daire")
        {
            Destroy(ggg.gameObject.GetComponent<deneme_script>());
        }
    }
}
