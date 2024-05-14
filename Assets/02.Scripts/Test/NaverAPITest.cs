using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class NaverAPITest : MonoBehaviour
{
    void Start() {
        StartCoroutine(GetText());
    }
    private string clientId = "zhcDbCqv11egWvhrIkTg"; 
    private string clientSecret = "Hr_R7jTdS6";
    
    IEnumerator GetText()
    {
        UnityWebRequest www = UnityWebRequest.Get("https://openapi.naver.com/v1/search/shop.json?query=기계식키보드");
        www.SetRequestHeader("X-Naver-Client-Id", clientId);
        www.SetRequestHeader("X-Naver-Client-Secret", clientSecret);
        
        
        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log(www.error);
        }
        else
        {
            Debug.Log(www.downloadHandler.text);
            string jsonText = www.downloadHandler.text;
            NaverShoppingResponse result = JsonUtility.FromJson<NaverShoppingResponse>(jsonText);
            foreach (var item in result.items)
            {
                Debug.Log(item.title);
            }
        }
    }
}


[Serializable]
public class NaverShoppingResponse
{
    public string lastBuildDate;
    public int total;
    public int start;
    public int display;
    public NaverShoppingItem[] items;
}

[Serializable]
public class NaverShoppingItem
{
    public string title;
    public string link;
    public string image;
    public string lprice;
    public string hprice;
    public string mallName;
    public string productId;
    public string productType;
    public string brand;
    public string maker;
    public string category1;
    public string category2;
    public string category3;
    public string category4;
}