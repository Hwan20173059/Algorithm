using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] fees, string[] records) {
        //차량 요금 저장 딕셔너리
            Dictionary<string, float> car_fee = new Dictionary<string, float>();
            //차량 입차시간 저장 딕셔너리
            Dictionary<string, string> car_time = new Dictionary<string, string>();
            //입력배열의 길이만큼 반복
            for (int i = 0; i < records.Length; i++)
            {
                if (records[i].Substring(11) == "OUT")
                {
                    int min = determineTime(car_time[records[i].Substring(6, 4)], records[i].Substring(0, 5));
                    Console.WriteLine(min);
                    //경과시간을 자동차 요금에 저장하자
                    car_fee[records[i].Substring(6, 4)] += min;
                    //임시저장했던 정보를 지우자
                    car_time.Remove(records[i].Substring(6, 4));
                }
                // 만약 배열의 인덱스가 IN이면 해당 배열의 인덱스값을 임시 저장 
                else if (records[i].Substring(11) == "IN")
                {
                    car_time.Add(records[i].Substring(6, 4), records[i].Substring(0, 5));
                    if (!car_fee.ContainsKey(records[i].Substring(6, 4)))
                    {
                        car_fee.Add(records[i].Substring(6, 4), 0);
                    }
                    
                }
            }
            // 여기서 아직까지 딕셔너리에 값이 남아 있다면
            //car_time 의 길이만큼 반복하면서
            //23:59 시간과 저장시간을 뺀다.
            if (car_time.Count > 0)
            {
                foreach (string key in car_time.Keys)
                {
                    int min = determineTime(car_time[key], "23:59");
                    Console.WriteLine(min);
                    car_fee[key] += min;
                }
            }
            //여기서 딕셔너리 key값 정렬
            List<string> keys = new List<string>();
            foreach (string key in car_fee.Keys)
            {
                keys.Add(key);
            }
            keys.Sort();
            //여기서 결과 도출
            int[] answer = new int[keys.Count];
            for (int i = 0; i < keys.Count; i++)
            {
                answer[i] = calculator(fees[0], fees[1], fees[2], fees[3],car_fee[keys[i]]);
            }
            return answer;

        }
        //요금 계산기 함수
        int calculator(int b_min, int b_fee, int u_min, int u_fee, float min)
        {
            int fee = 0;
            //만약 정산 시간이 기본시간보다 크면
            if (min > b_min)
            {
                //요금 정책에 따라 계산
                fee = b_fee + (int)((Math.Ceiling((min - b_min) / u_min)) * u_fee);
            }
            // 기본시간보다 작으면 그냥 기본가격으로 적용
            else
                fee = b_fee;
            return fee;
        }
				// 시간string=> int 로 변환시켜주는 함수
        int determineTime(string pastTime, string curTime)
        {
            int[] hours = new int[2];
            int[] mins = new int[2];
            hours[0] = int.Parse(pastTime.Substring(0, 2));
            hours[1] = int.Parse(curTime.Substring(0, 2));
            mins[0] = int.Parse(pastTime.Substring(3, 2));
            mins[1] = int.Parse(curTime.Substring(3, 2));
            int min = (hours[1] - hours[0]) * 60 + (mins[1] - mins[0]);
            return min;
        }
    
    
}