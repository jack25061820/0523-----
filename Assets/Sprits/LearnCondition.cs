
using UnityEngine;
/// <summary>
/// ����(�P�_��)
/// 1.if
/// 2.switch
/// </summary>
public class LearnCondition : MonoBehaviour
{
    public bool openDoor;
    public int combo;
    public string prop;
    //�w�q�C�|���e
    //�w�q���
    
    //�C�|�y�k:
    //�׹��� �C�| �C�|�W��{�C�|���e}
    public enum StatePlayer
    {
        Idle,Walk,Run,Hurt,Attack,Dead
    }
    //�w�q���
    //�׹��� �C�|�W�� ���W��:
    public StatePlayer statePlayer;



    private void Start()
    {
        #region if �P�_��
        // if�y�k:
        // if (���L��) {���L������ true �|����}
        if (true)
        {
            print("�ڦb�P�_�� if ��");
        }
        #endregion
    }

    private void Update()
    {
    #region switch �P�_��
    //�y�k
    // switch (������B�⦡)
    //{
    //      case��:
    //          �{�����e:
    //          break
    //}
    switch(prop)
        {
            case "�����Ĥ�":
                print("�ɦ�");
                break;

            case "�Ŧ��Ĥ�":
                print("���]");
                break;

            case "�����Ĥ�":
                print("����O");
                break;
                //�i�ٲ�
            default:
                print("�S�����D��");
                break;
        }

        //switch + Tab * 2
        //��J�C�|�W�� statePlayer
        //Enter

        switch(statePlayer)
        {
            case StatePlayer.Idle:
                print("����");
                break;
            case StatePlayer.Walk:
                print("����");
                break;
            case StatePlayer.Run:
                print("�]�B");
                break;
            case StatePlayer.Hurt:
                print("����");
                break;
            case StatePlayer.Attack:
                print("����");
                break;
            case StatePlayer.Dead:
                print("���`");
                break;
        }

        #endregion
        //if�y�k
        //if (���L��) {���L������ture,�N�}�� �_�h�N����}
        //�_�h
        //else {���L������false�|����}
        // else if �y�k 
        if (openDoor)
        {
            print("�}��");
        }
        else
        {
            print("����");
        }
        if (combo < 100)
        {
            print("�����O+0%");
        }
        else if (combo >= 200)
        {
            print("�����O+20%");
        }
        else if (combo >= 100)
        {
            print("�����O+10%");
        }
    }
}

