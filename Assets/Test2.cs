using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    public class Boss
    {
        private int mp = 53;   // 魔法力

        // 魔法攻撃をするMagic関数
        public void Magic()
        {
            if (mp < 5)
            {
                Debug.Log("MPが足りないため魔法が使えない。");
            }
            else
            {
                this.mp -= 5;
                Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
            }
        }

    }
    // Use this for initialization
    void Start()
    {
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss MagicMan = new Boss();

        MagicMan.Magic();
        MagicMan.Magic();
        MagicMan.Magic();
        MagicMan.Magic();
        MagicMan.Magic();
        MagicMan.Magic();
        MagicMan.Magic();
        MagicMan.Magic();
        MagicMan.Magic();
        MagicMan.Magic();
        //ここから魔法が使えない
        MagicMan.Magic();
        MagicMan.Magic();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
