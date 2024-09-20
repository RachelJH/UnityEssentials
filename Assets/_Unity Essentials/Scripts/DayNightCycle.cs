using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    public float secondsPerDay = 120f; // 하루가 지나가는 시간 (초)
    private float rotationSpeed;

    void Start()
    {
        // 하루에 대한 회전 속도 계산 (1일을 360도로 나누기)
        rotationSpeed = 360f / secondsPerDay;
    }

    void Update()
    {
        // 매 프레임마다 빛을 회전시킴
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
    }
}