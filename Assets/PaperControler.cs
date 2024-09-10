using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperControler : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Paper;
    float span = 4.0f,time = 0f;
    float pramdom;
    void Start()
    {
        pramdom = Random.Range(-3.0f, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (span < time)
        {
            GameObject paper = Instantiate(Paper);
            Paper.transform.position = new Vector2(-11, pramdom);
            time = 0;
        }
         
    }
}
