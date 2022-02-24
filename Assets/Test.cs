using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力
    private int mp = 53; // 魔力

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

    public void Magic()
    {
        this.mp = mp - 5;
        if (mp > 0)
        {
            Debug.Log("魔法攻撃をした。残りMPは" + mp);
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }

    }

}



public class Test : MonoBehaviour
{
    void Start()
    {
        // 課題　要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化してください
        int[] array = { 10, 20, 30, 40, 50 };


        // 課題　for文を使い、配列の各要素の値を順番に表示してください
        for (int i = 0; i <= 4; i++)
        {
            Debug.Log(array[i]);
        }

        // 課題　for文を使い、配列の各要素の値を逆順に表示してください
        for (int n = 4; n >= 0; n--)
        {
            Debug.Log(array[n]);
        }

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);

        // 発展課題 
        for (int g = 0; g <= 10; g++)
        {
            lastboss.Magic();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
