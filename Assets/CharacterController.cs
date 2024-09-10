using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charactercontoroller : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    float jumpforce = 750f,timelimit = 30.0f;
    Vector2 playerposition;
    Ray ray;
    RaycastHit2D hit2D;
    GameObject left_button, right_button, player;
    bool rightmoveflag = false, leftmoveflag = false,jumpflag = true;
    int playerhp = 100;
    int hp;
    void Start()
    {
        player = GameObject.Find("Player");
        rigidbody2d = player.GetComponent<Rigidbody2D>();
        left_button = GameObject.Find("LeftButton"); right_button = GameObject.Find("RightButton");
    }

    void Update()
    {
        if (rightmoveflag == true)
        {

            //jumpflag = false;
        }
        if (leftmoveflag == true)
        {

            //jumpflag = false;
        }
        if (UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject != null)
            return;
            if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            if (jumpflag == true && leftmoveflag == false && rightmoveflag == false)
            { jump(); jumpflag = true; }
        }
    }
    void jump()
    {
        {
            Debug.Log("");
            if (rigidbody2d.velocity.y == 0 && jumpflag != false)
                rigidbody2d.AddForce(transform.up * this.jumpforce);
        }
    }
    public void LeftMove()
    {
        Debug.Log("");
        playerposition = transform.position;
        if (playerposition.x - 3 > -8)
            transform.Translate(-3, 0, 0);
    }
    public void RightMove()
    {
        Debug.Log("");
        playerposition = transform.position;
        if (playerposition.x + 3 < 8)
            transform.Translate(3, 0, 0);
    }

}
