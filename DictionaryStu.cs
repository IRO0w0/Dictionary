using System.Collections.Generic;
using UnityEngine;

public class DictionaryStu : MonoBehaviour
{
    public Dictionary<int, string> chaekjang;
    void Start()
    {
        chaekjang = new Dictionary<int, string>(); // �ν��Ͻ�ȭ ( ���� �ܰ�)
        chaekjang.Add(24601, "��"); // (������ ���� �ܰ�)
        string book;
        if (chaekjang.TryGetValue(24601, out book)) // (������ ���)  TryGetValue = å�忡 24601 �� �ֳ�? 
        {
            Debug.Log(book);
        }
        chaekjang[24601] = "dd";
        Debug.Log(chaekjang[24601]);  // ������ ����

        chaekjang.Remove(24601);   // ������ ����
    }


    // ��ųʸ� ����
    // 1. ����
    // 2. ������ ����
    // 3. ������ ����
    // 4. ������ ����
}
