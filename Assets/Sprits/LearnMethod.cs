
using UnityEngine;

public class LearnMethod : MonoBehaviour
{
   private void Start()
    {
        Test();

        PrintColorText();

        print("傳回10方法結果:" + ReturnTen());
        print("商品總價:" + CalculatePrice());
        Shoot("火球");
        Shoot("電球");
        Shoot("冰球","滋滋滋");
        Shoot("雪球","白色雪花");
        Shoot("雪球", effect: "白色雪花");
        //近距離攻擊
        Attack(50);
        //遠距攻擊
        Attack(20, "火球");
    }   


    void Test()
    {
        print("哈囉，沃德:D");
   
     
    }
    #region 方法練習
    private void PrintColorText()
    {
        print("<color=yellow>黃色訊息</color>");
        print("<color=blue>藍色訊息</color>");
        print("<size=10><color=red>紅色訊息</color></size>");
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
        print("發射火球");
        print("播放音效");
    }
    private void ShootLighting()
    {
        print("發射電球");
        print("播放音效");
    }
    private void Shoot(string type, string sound="咻咻咻",string effect ="煙霧")
    {
        print("發射:" + type);
        print("音效" + sound);
        print("特效" + effect);
    }
    
    private void TestMethod()
    {

    }
    private void TestMethod(int number)
    {

    }

    private void Attack(float atk)
    {
        print("近距離攻擊，攻擊力:" + atk);
    }
    private void Attack(float atk,string ball)
    {
        print("遠距離攻擊，攻擊力:" + atk);
        print("發射物件:" + ball);
    }
}
