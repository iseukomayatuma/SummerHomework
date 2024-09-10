using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dogseisei : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Dog;
    float span = 7.0f, time = 0;
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
            GameObject paper = Instantiate(Dog);
            Dog.transform.position = new Vector2(-11, -4);
            time = 0;
        }
        if (transform.position.x > 15)
            Destroy(gameObject);
    }
}
