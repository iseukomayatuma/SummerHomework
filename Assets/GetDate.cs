using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetDate : MonoBehaviour
{

    void Start()
    {
    
    }

}



[System.Serializable] // このアトリビュートの追加必要
    public class MonsterDataEntity //  : MonoBehaviourは付けない
{
    // publicでExcelデータの1行目と同じパラメータ
    public int ID;
    public int HpMax;
    public int HpMin;
    public int DistanceX;
    public int DistanceY;
    public int JumpTime;
}

// Update is called once per frame
