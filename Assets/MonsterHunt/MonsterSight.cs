using UnityEngine;

public class MonsterSight : MonoBehaviour
{
    public Transform player;
    public float sightAngle = 60f; // 시야각 (좌우 합쳐 120도)

    void Update()
    {
        // position은 Transform의 월드 좌표 위치 프로퍼티입니다.
        Vector3 dirToPlayer = (player.position - transform.position).normalized;

        // 1. 내적을 이용한 시야 판별
        // transform.forward는 현재 오브젝트가 바라보는 앞 방향 벡터입니다.
        // Vector3.Dot은 두 방향이 얼마나 같은 방향을 보는지 계산하는 메서드입니다.
        float dot = Vector3.Dot(transform.forward, dirToPlayer);
        // Mathf.Acos는 코사인값을 각도로 되돌리기 위한 라디안 값을 구하고, Rad2Deg는 라디안을 도(degree)로 바꿉니다.
        float angle = Mathf.Acos(dot) * Mathf.Rad2Deg; // 아크코사인으로 각도 추출

        if (angle < sightAngle)
        {
            // Debug.Log는 콘솔 창에 확인용 메시지를 출력하는 메서드입니다.
            Debug.Log("플레이어 발견!");

            // 2. 외적을 이용한 좌우 판별
            // Vector3.Cross는 두 벡터에 수직인 벡터를 구해 좌우 방향 판별에 사용할 수 있습니다.
            Vector3 cross = Vector3.Cross(transform.forward, dirToPlayer);

            if (cross.y > 0)
            {
                Debug.Log("플레이어는 오른쪽에 있음");
            }
            else if (cross.y < 0)
            {
                Debug.Log("플레이어는 왼쪽에 있음");
            }
        }
    }
}