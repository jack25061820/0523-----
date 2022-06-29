
using UnityEngine;
/// <summary>
/// ¾Ç²ß ÀRºA API
/// ÀRºA static
/// </summary>
public class LearnAPIstate : MonoBehaviour
{
    private void Start()
    {
        print("ÀH¾÷­È:" + Random.value);
        print("¿Ã¹õ¼e«×:" + Screen.width);
        print("¶ê©P²v:" + Mathf.PI);

        Screen.brightness = 0.5f;
        Cursor.visible = false;
    }
}
