
using UnityEngine;
/// <summary>
/// �ǲ� �R�A API
/// �R�A static
/// </summary>
public class LearnAPIstate : MonoBehaviour
{
    private void Start()
    {
        print("�H����:" + Random.value);
        print("�ù��e��:" + Screen.width);
        print("��P�v:" + Mathf.PI);

        Screen.brightness = 0.5f;
        Cursor.visible = false;
    }
}
