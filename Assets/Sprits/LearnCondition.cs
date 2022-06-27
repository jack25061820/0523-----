
using UnityEngine;
/// <summary>
/// 條件式(判斷式)
/// 1.if
/// 2.switch
/// </summary>
public class LearnCondition : MonoBehaviour
{
    public bool openDoor;
    public int combo;
    private void Start()
    {
        #region if 判斷式
        // if語法:
        // if (布林直) {布林直等於 true 會執行}
        if (true)
        {
            print("我在判斷式 if 內");
        }
        #endregion
    }

    private void Update()
    {
        //if語法
        //if (布林直) {布林直等於ture,就開門 否則就關門}
        //否則
        //else {布林直等於false會執行}
        // else if 語法 
        if (openDoor)
        {
            print("開門");
        }
        else
        {
            print("關門");
        }
        if (combo < 100)
        {
            print("攻擊力+0%");
        }
        else if (combo >= 200)
        {
            print("攻擊力+20%");
        }
        else if (combo >= 100)
        {
            print("攻擊力+10%");
        }
    }
}

