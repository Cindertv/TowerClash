using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 0.5f;
    public float speedMultiplier = 1;
    public float playerHeatlh { get; private set; }
    public Image uiPlayerHealth;
    private bool isAlive = true;
    Camera cam;

    void Start()
    {
        playerHeatlh = 100f;
        uiPlayerHealth.fillAmount = 1;
        cam = Camera.main;
    }

    void Update()
    {
        if (isAlive)
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            Plane floor = new Plane(Vector3.up, Vector3.zero);
            float rayDistance;
            if (floor.Raycast(ray, out rayDistance))
            {
                Vector3 point = ray.GetPoint(rayDistance);
                Lookat(point);
                Debug.DrawLine(ray.origin, point, Color.red);
            }

        }
    }
    public void TakeDamage(float ammount)
    {
        playerHeatlh -= ammount;

        if (playerHeatlh < 0 && isAlive)
        {
            isAlive = false;
            print("Player is dead");           
            return;
        }
        UpdateUI();

    }
    private void UpdateUI()
    {
        uiPlayerHealth.fillAmount = playerHeatlh / 100f;

    }
    public void AddHealth(float ammount)
    {
        if (isAlive)
        {
            playerHeatlh += ammount;
            UpdateUI();
        }
    }

    public void Lookat (Vector3 lookpoint)
    {
        Vector3 heightcontroller = new Vector3(lookpoint.x, transform.position.y, lookpoint.z);
        transform.LookAt(heightcontroller);
    }

}
