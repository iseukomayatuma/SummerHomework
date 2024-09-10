using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperController : MonoBehaviour
{
    int pgoramdom;
    float pgo = 0.035f;
    
    // Update is called once per frame
    void Update()
    {
        pgoramdom = Random.Range(0, 9);
        //pgo = pgoramdom * pgo;
        transform.Translate(pgo,0,0);
        if (transform.position.x > 15)
            Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        Destroy(gameObject);
    }

}
