using UnityEngine;

public class LearOperator : MonoBehaviour
{
    private float a = 10;
    private float b = 3;

    private int c = 99;
    private int d = 1;

    private void Start()
    {
        #region �ƾǹB��l
        print("�[�k:" + (a + b));
        print("��k:" + (a - b));
        print("���k:" + (a * b));
        print("���k:" + (a / b));
        print("�l�k:" + (a % b));
        #endregion

        #region ����B��l
        print("�j��:" + (c > d));
        print("�p��:" + (c < d));
        print("����:" + (c == d));
        print("������:" + (c != d));
        print("�j�󵥩�:" + (c >= d));
        print("�p�󵥩�:" + (c <= d));
        #endregion

        #region �޿�B��l
        //  &&=�åB
        print("true && true:" + (true && true));
        print("true && false:" + (true && false));
        print("false && true:" + (false && true));
        print("false && false:" + (false && false)); 
        // ||=�Ϊ�
        print("true || true:" + (true || true));
        print("true || false:" + (true || false));
        print("false || true:" + (false || true));
        print("false || false:" + (false || false));
        #endregion

    }

}
