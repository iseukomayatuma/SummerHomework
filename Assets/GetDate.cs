using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetDate : MonoBehaviour
{

    void Start()
    {
    
    }

}



[System.Serializable] // ���̃A�g���r���[�g�̒ǉ��K�v
    public class MonsterDataEntity //  : MonoBehaviour�͕t���Ȃ�
{
    // public��Excel�f�[�^��1�s�ڂƓ����p�����[�^
    public int ID;
    public int HpMax;
    public int HpMin;
    public int DistanceX;
    public int DistanceY;
    public int JumpTime;
}

// Update is called once per frame
