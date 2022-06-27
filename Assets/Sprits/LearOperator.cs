using UnityEngine;

public class LearOperator : MonoBehaviour
{
    private float a = 10;
    private float b = 3;

    private int c = 99;
    private int d = 1;

    private void Start()
    {
        #region 數學運算子
        print("加法:" + (a + b));
        print("減法:" + (a - b));
        print("乘法:" + (a * b));
        print("除法:" + (a / b));
        print("餘法:" + (a % b));
        #endregion

        #region 比較運算子
        print("大於:" + (c > d));
        print("小於:" + (c < d));
        print("等於:" + (c == d));
        print("不等於:" + (c != d));
        print("大於等於:" + (c >= d));
        print("小於等於:" + (c <= d));
        #endregion

        #region 邏輯運算子
        //  &&=並且
        print("true && true:" + (true && true));
        print("true && false:" + (true && false));
        print("false && true:" + (false && true));
        print("false && false:" + (false && false)); 
        // ||=或者
        print("true || true:" + (true || true));
        print("true || false:" + (true || false));
        print("false || true:" + (false || true));
        print("false || false:" + (false || false));
        #endregion

    }

}
