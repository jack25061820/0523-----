using UnityEngine;

public class Car : MonoBehaviour
{
    //�{���ƪ��榡��
    //���q
    [Range(1,50)]
    [Tooltip("�T�������q�A���O���q")]
    public int wight = 3;
    //����
    [Header("�T��������"),Range(1,10)]
    public float height = 3.5f;
    //�~�P
    [Header("�T�����~�P�W��")]
    public string brand = "���h";
    //�O�_���ѵ�
    [Header("�O�_���ѵ�")]
    [Tooltip("�]�w�T���O�_���ѵ�")]
    public bool hasSkyWindow = true;
}
