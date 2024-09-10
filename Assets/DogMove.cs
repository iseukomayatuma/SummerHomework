using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogMove : MonoBehaviour
{
    // Start is called before the first frame update
    float jumptime = 0;
    int ramdom;
    float jump = 0.5f;
    float jumppower = 600.0f;
    void Start()
    {
        ramdom = Random.Range(1, 10);
        jump = jump * ramdom;
        Rigidbody2D rigidbody2ddog;

    }

    // Update is called once per frame
    void Update()
    {
        jumptime += Time.deltaTime;
        if(jumptime > jump)
        {
            if(GetComponent<Rigidbody2D>().velocity.y == 0)
            dogjump();
            jumptime = 0;
        }
        transform.Translate((float)0.007f, 0, 0);
        if (transform.position.x > 15)
            Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        Destroy(gameObject);
    }
    void dogjump()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumppower));
    }
}
