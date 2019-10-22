using UnityEngine;
using System.Collections;

public class Boss
{
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

}

public class Test : MonoBehaviour
{
    void Start()
    {
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();
        Boss midboss = new Boss();
        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);

        midboss.Attack();
        lastboss.Defence(18);
    }
    // Update is called once per frame
    void Update()
    {

    }
}