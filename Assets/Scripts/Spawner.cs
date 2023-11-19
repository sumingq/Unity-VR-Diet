using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] cubes;// cubes 라는 이름의 public 배열을 선언, 게임 오브젝트를 저장하는데 사용
    public Transform[] points; // points 라는 이름의 public 배열을 선언, 위치를 저장하는데 사용
    public float beat = 1;// beat 라는 이름의 public 변수를 선언, 비트가 나오는 속도 나타냄
    float timer; // timer 라는 이름의 private 변수를 선언, 생성까지의 시간을 계산하는데 사용

    // 매 프레임마다 한 번씩 호출
    void Update()
    {
        // 타이머가 1초(beat)를 넘어갔다면
        if(timer > beat)
        {
            // 타이머에서 비트(1초)를 빼 줌 = 비트 간격만큼 시간을 차감하여 다음 생성 시간을 설정함
            timer -= beat;

            // cubes 배열(0,1)에서 랜덤하게 게임 오브젝트를 선택하고,
            // points 배열(0,1,2,3)에서 랜덤한 위치를 선택하여 해당 게임 오브젝트를 생성
            // 새로운 게임 오브젝트는 'c' 변수에 저장됨
            GameObject c = Instantiate(cubes[Random.Range(0, 2)], points[Random.Range(0, 4)]);

            // 새로 생성된 게임 오브젝트(c)의 로컬 위치를 zero(0,0,0)로 설정
            // => 이렇게 하면 생성된 큐브는 스폰 위치에 정확히 배치됨
            c.transform.localPosition = Vector3.zero;
            // 게임 오브젝트 c를 transform.forward 축을 기준으로 랜덤한 각도(0, 90, 180, 270도)로 회전 시킴
            //c.transform.Rotate(transform.forward, 90 * Random.Range(0, 4));
        }

        // timer에 경과한 시간(Time.deltaTime)을 더함, 시간이 흐름에 따라 timer의 값이 증가
        timer += Time.deltaTime;
    }
}
