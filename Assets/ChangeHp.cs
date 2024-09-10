using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UIを使うときに書きます。
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    //最大HPと現在のHP。
    int maxHp = 100;
    int Hp;
    float tim = 0;
    //Slider
    public Slider slider;

    void Start()
    {
        //Sliderを最大にする。
        slider.value = 10;
        //HPを最大HPと同じ値に。
        Hp = maxHp;
    }

     void Update()
     {
        tim += Time.deltaTime;
        slider.value = (float)Hp;
        if (tim > 29.0)
            SceneManager.LoadScene("kuriasc");
        else if (Hp <= 0)
            SceneManager.LoadScene("murisc");
     }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("paper"))

            Hp -= 5;
        if (collision.gameObject.CompareTag("kya"))
            Hp -= 10;
        if (collision.gameObject.CompareTag("dog"))
            Hp -= 20;
    }
}