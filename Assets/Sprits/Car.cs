using UnityEngine;

public class Car : MonoBehaviour
{
    //程式排版格式化
    //重量
    [Range(1,50)]
    [Tooltip("汽車的重量，單位是重量")]
    public int wight = 3;
    //高度
    [Header("汽車的高度"),Range(1,10)]
    public float height = 3.5f;
    //品牌
    [Header("汽車的品牌名稱")]
    public string brand = "賓士";
    //是否有天窗
    [Header("是否有天窗")]
    [Tooltip("設定汽車是否有天窗")]
    public bool hasSkyWindow = true;
}
