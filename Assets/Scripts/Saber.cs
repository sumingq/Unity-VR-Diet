using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saber : MonoBehaviour
{
    // layer라는 이름의 public 변수를 선언, 레이어 정보를 저장하는데 사용(충돌 체크할 레이어)
    public LayerMask layer;
    // prevPos라는 이름의 private 변수를 선언, 이전 프레임의 검의 위치를 저장하는데 사용
    Vector3 prevPos;

    void Update()
    {
        // RaycastHit 구조체 타입의 변수 hit을 선언, 레이캐스트에 의한 충돌 정보를 저장하는데 사용
        RaycastHit hit;

        // 조건 : Ray 원점, Ray 방향, 충돌 감지할 RaycastHit, Ray 거리(길이)
        // Physics.Raycast 메서드를 사용하여 현재 게임 오브젝트 위치에서 transform.forward 방향으로 1미터 내에서 충돌을 감지
        // layer 변수는 충돌을 체크할 레이어를 제한하는데 사용
        // 만약 충돌이 발생하면 hit 변수에 충돌 정보가 저장됨
        //if (Physics.Raycast(transform.position, transform.forward, out hit, 2, layer))
            if (Physics.Raycast(transform.position, transform.forward, out hit, 2))
            {
            // Vector3.Angle 메서드를 사용하여
            // 검의 이전 위치(prevPos)와 충돌한 오브젝트의 상단 방향(hit.transform.up) 벡터 간의 각도가 130 보다 큰지 확인
            // 충돌각도확인하는거 삭제if (Vector3.Angle(transform.position-prevPos, hit.transform.up) > 130)
            //{
                // 충돌한 오브젝트를 삭제함
                Destroy(hit.transform.gameObject);
            //}
        } 

        // 검의 현재 위치(transform.position)를 prevPos에 저장하여 다음 프레임에서 이전 위치로 사용됨
        prevPos = transform.position;
    }
}
