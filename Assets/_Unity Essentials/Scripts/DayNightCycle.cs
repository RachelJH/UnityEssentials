using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    public float secondsPerDay = 120f; // �Ϸ簡 �������� �ð� (��)
    private float rotationSpeed;

    void Start()
    {
        // �Ϸ翡 ���� ȸ�� �ӵ� ��� (1���� 360���� ������)
        rotationSpeed = 360f / secondsPerDay;
    }

    void Update()
    {
        // �� �����Ӹ��� ���� ȸ����Ŵ
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
    }
}