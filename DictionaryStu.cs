using System.Collections.Generic;
using UnityEngine;

public class DictionaryStu : MonoBehaviour
{
    public Dictionary<int, string> chaekjang;
    void Start()
    {
        chaekjang = new Dictionary<int, string>(); // 인스턴스화 ( 생성 단계)
        chaekjang.Add(24601, "똥"); // (데이터 삽입 단계)
        string book;
        if (chaekjang.TryGetValue(24601, out book)) // (데이터 사용)  TryGetValue = 책장에 24601 이 있나? 
        {
            Debug.Log(book);
        }
        chaekjang[24601] = "dd";
        Debug.Log(chaekjang[24601]);  // 데이터 수정

        chaekjang.Remove(24601);   // 데이터 삭제
    }


    // 딕셔너리 공부
    // 1. 생성
    // 2. 데이터 삽입
    // 3. 데이터 수정
    // 4. 데이터 삭제
}
