using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movekya : MonoBehaviour
{
    float jumppower = 650.0f;
    int ramdomjump;
    int ramdommove;
    // Start is called before the first frame update
    void Start()
    {
        ramdomjump = Random.Range(1,8);
        ramdommove = Random.Range(1, 8);
        ramdommove = ramdomjump * 5;
       // jumppower = ramdomjump * jumppower;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((float)0.01f, 0, 0);
        if (transform.position.x > 15)
            Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(111);

        if (collision.gameObject.CompareTag("kabe"))
            {
            kyajump();
            }
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }

    }
    void kyajump()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumppower));
        jumppower += 20f;
    }
}
