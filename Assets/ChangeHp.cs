using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI���g���Ƃ��ɏ����܂��B
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    //�ő�HP�ƌ��݂�HP�B
    int maxHp = 100;
    int Hp;
    float tim = 0;
    //Slider
    public Slider slider;

    void Start()
    {
        //Slider���ő�ɂ���B
        slider.value = 10;
        //HP���ő�HP�Ɠ����l�ɁB
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