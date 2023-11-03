using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public int speed = 2;

    void Update()
    {
        // 현재 위치(transform.position)에 시간(Time.deltaTime)과 전진 방향(transform.forward)을
        // 곱한 값을 speed배로 늘려 더함
        // 이 스크립트가 적용된 게임 오브젝트를 프레임마다 일정한 속도로 전진시키는 역할
        transform.position += Time.deltaTime * transform.forward * speed;
        //transform.position += Time.deltaTime * transform.forward * 2;
    }
}
