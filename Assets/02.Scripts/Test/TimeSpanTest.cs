using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSpanTest : MonoBehaviour
{
    private void Start()
    {
        // TimeSpan은 시간 혹은 시간 간격을 나타내는 클래스
        // 시간을 조작하거나 두 날짜 사이의 차이를 계산할 수 있다.
        TimeSpan twoHour = new TimeSpan(2, 0, 0);
        Debug.Log(twoHour);
        Debug.Log(twoHour.TotalMinutes); // 2시간이 몇분이지?
        Debug.Log(twoHour.TotalSeconds); // 2시간이 몇초지?
        
        // 크리스마스까지 얼마나 남았찌?
        DateTime xMasDate = new DateTime(DateTime.Today.Year, 12, 25);
        DateTime today    = DateTime.Today;
        // DateTime에 대한 사칙연산은 '빼기'만 된다.
        TimeSpan diff = xMasDate - today;
        Debug.Log($"크리스마스까지 남은 일은 {diff.TotalDays}입니다.");
        
        // 2024.2.26을 기준으로
        // 100일이 언제고, 몇 일 남았는지 계산해서 출력











    }
}
