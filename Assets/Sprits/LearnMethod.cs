
using UnityEngine;

public class LearnMethod : MonoBehaviour
{
   private void Start()
    {
        Test();

        PrintColorText();
    }   


    void Test()
    {
        print("哈囉，沃德:D");
   
     
    }
    private void PrintColorText()
    {
        print("<color=yellow>黃色訊息</color>");
        print("<color=blue>藍色訊息</color>");
        print("<size=10><color=red>紅色訊息</color></size>");
    }
 
}
