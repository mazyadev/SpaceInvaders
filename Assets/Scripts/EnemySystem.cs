using UnityEngine;

public class EnemySystem : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private float distance = 2f;
    private Vector3 startPosition;
    void Start()
    {
        startPosition = transform.position;
    }
    void Update()
    {
        float x = Mathf.Sin(Time.time * speed) * distance;
        transform.position = new Vector3(
            startPosition.x + x,
            transform.position.y,
            transform.position.z
        );
        transform.position += Vector3.down * 0.5f * Time.deltaTime;

        if (transform.position.y <= -5)
        {
            Time.timeScale = 0;
        }
    }
}
