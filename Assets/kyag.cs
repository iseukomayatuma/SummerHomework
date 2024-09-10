using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kyag : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject kk;
    float span = 5.0f, time = 5.0f;
    float pramdom;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (span < time)
        {
            GameObject paper = Instantiate(kk);
            kk.transform.position = new Vector2(-9, -3);
            time = 0;
        }
        if (transform.position.x > 15)
            Destroy(gameObject);
    }
}
