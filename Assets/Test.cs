using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;          // �̗�
    private int power = 25; // �U����
    private int mp = 53; // ����

    // �U���p�̊֐�
    public void Attack()
    {
        Debug.Log(this.power + "�̃_���[�W��^����");
    }

    // �h��p�̊֐�
    public void Defence(int damage)
    {
        Debug.Log(damage + "�̃_���[�W���󂯂�");
        // �c��hp�����炷
        this.hp -= damage;
    }

    public void Magic()
    {
        this.mp = mp - 5;
        if (mp > 0)
        {
            Debug.Log("���@�U���������B�c��MP��" + mp);
        }
        else
        {
            Debug.Log("MP������Ȃ����ߖ��@���g���Ȃ��B");
        }

    }

}



public class Test : MonoBehaviour
{
    void Start()
    {
        // �ۑ�@�v�f�̌���5�́Aint�^�̔z��array��錾���čD���Ȓl�ŏ��������Ă�������
        int[] array = { 10, 20, 30, 40, 50 };


        // �ۑ�@for�����g���A�z��̊e�v�f�̒l�����Ԃɕ\�����Ă�������
        for (int i = 0; i <= 4; i++)
        {
            Debug.Log(array[i]);
        }

        // �ۑ�@for�����g���A�z��̊e�v�f�̒l���t���ɕ\�����Ă�������
        for (int n = 4; n >= 0; n--)
        {
            Debug.Log(array[n]);
        }

        // Boss�N���X�̕ϐ���錾���ăC���X�^���X����
        Boss lastboss = new Boss();

        // �U���p�̊֐����Ăяo��
        lastboss.Attack();
        // �h��p�̊֐����Ăяo��
        lastboss.Defence(3);

        // ���W�ۑ� 
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
