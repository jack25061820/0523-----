
using UnityEngine;

public class LearnMethod : MonoBehaviour
{
   private void Start()
    {
        Test();

        PrintColorText();

        print("�Ǧ^10��k���G:" + ReturnTen());
        print("�ӫ~�`��:" + CalculatePrice());
        Shoot("���y");
        Shoot("�q�y");
        Shoot("�B�y","������");
        Shoot("���y","�զ⳷��");
        Shoot("���y", effect: "�զ⳷��");
        //��Z������
        Attack(50);
        //���Z����
        Attack(20, "���y");
    }   


    void Test()
    {
        print("���o�A�U�w:D");
   
     
    }
    #region ��k�m��
    private void PrintColorText()
    {
        print("<color=yellow>����T��</color>");
        print("<color=blue>�Ŧ�T��</color>");
        print("<size=10><color=red>����T��</color></size>");
    }
    private int ReturnTen()
    {
        return 10;
    }
    public int countProduct = 10;
    public int countPrice = 99;

    private int CalculatePrice()
    {
        return countProduct * countPrice;
    }
    #endregion
    private void ShootFire()
    {
        print("�o�g���y");
        print("���񭵮�");
    }
    private void ShootLighting()
    {
        print("�o�g�q�y");
        print("���񭵮�");
    }
    private void Shoot(string type, string sound="������",string effect ="����")
    {
        print("�o�g:" + type);
        print("����" + sound);
        print("�S��" + effect);
    }
    
    private void TestMethod()
    {

    }
    private void TestMethod(int number)
    {

    }

    private void Attack(float atk)
    {
        print("��Z�������A�����O:" + atk);
    }
    private void Attack(float atk,string ball)
    {
        print("���Z�������A�����O:" + atk);
        print("�o�g����:" + ball);
    }
}
