using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private int speed = 15;
    [SerializeField] private GameObject bullet;
    [SerializeField] private float fireRate = 0.2f;

    private float nextFireTime;
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A) && transform.position.x >= -8)
        {
            transform.position += new Vector3(-speed, 0, 0) * Time.fixedDeltaTime;
        }
        if (Input.GetKey(KeyCode.D) && transform.position.x <= 8)
        {
            transform.position += new Vector3(speed, 0, 0) * Time.fixedDeltaTime;
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + fireRate;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void Shoot()
    {
        GameObject bulletCreated = Instantiate(bullet);
        bulletCreated.transform.position = this.transform.position;
    }
}
