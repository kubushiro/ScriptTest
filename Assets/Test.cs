using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;
    private int power = 25;
    //���W�ۑ�
    private int mp = 53;


    public void Attack()
    {
        Debug.Log(this.power + "�̃_���[�W��^����");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "�̃_���[�W���󂯂�");

        this.hp -= damage;
    }

    public void Magic()
    {
        if(this.mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("���@�U���������B�c��MP��" + this.mp + "�B");
        }
        else
        {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
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
        // Hello�֐����Ăяo��
        //Hello();
        //Goodbye();
        //HelloName("Unity");

        //int num = Add(3, 6);
        //Debug.Log(num);

        //�ۑ�
        //�v�f�̌���5�́Aint�^�̔z��array��錾���čD���Ȓl�ŏ��������Ă�������
        int[] array = { 25, 3, 165, 47, 46};

        //for�����g���A�z��̊e�v�f�̒l�����Ԃɕ\�����Ă�������
        for(int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        //for�����g���A�z��̊e�v�f�̒l���t���ɕ\�����Ă�������
        for(int i = array.Length; i > 0;i--)
        {
            Debug.Log(array[i - 1]);
        }



        Boss lastboss = new Boss();

        lastboss.Attack();

        lastboss.Defence(5);

        //���W�ۑ�FBoss�N���X�ɁA�ϐ�mp��Magic�֐����쐬����Start�֐�����Ăяo����

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
