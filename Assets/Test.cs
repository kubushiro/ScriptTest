using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;
    private int power = 25;
    //発展課題
    private int mp = 53;


    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");

        this.hp -= damage;
    }

    public void Magic()
    {
        if(this.mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
    }
}


public class Test : MonoBehaviour
{

    //void Hello()
    //{
    //    Debug.Log("Hello, UnityChan");
    //}

    //void Goodbye()
    //{
    //    Debug.Log("Goodbye, UnityChan");
    //}

    //void HelloName(string name)
    //{
    //    Debug.Log("Hello, " + name);
    //}

    //int Add(int a, int b)
    //{
    //    int c = a + b;

    //    return c;
    //}

    // Start is called before the first frame update
    void Start()
    {
        // Hello関数を呼び出す
        //Hello();
        //Goodbye();
        //HelloName("Unity");

        //int num = Add(3, 6);
        //Debug.Log(num);

        //課題
        //要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化してください
        int[] array = { 25, 3, 165, 47, 46};

        //for文を使い、配列の各要素の値を順番に表示してください
        for(int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        //for文を使い、配列の各要素の値を逆順に表示してください
        for(int i = array.Length; i > 0;i--)
        {
            Debug.Log(array[i - 1]);
        }



        Boss lastboss = new Boss();

        lastboss.Attack();

        lastboss.Defence(5);

        //発展課題：Bossクラスに、変数mpとMagic関数を作成してStart関数から呼び出そう

        for(int i = 1; i <= 11; i++)
        {
                lastboss.Magic();

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
