
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

