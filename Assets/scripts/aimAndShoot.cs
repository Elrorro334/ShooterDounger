using UnityEngine;
public class aimAndShoot : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    private Camera Cam;
    private Vector2 mouseWorldPosition, direction;
    [SerializeField] private GameObject arrowPrefab;
    [SerializeField] private Transform shootPosition;

    void Start()
    {
       Cam = Camera.main;
    }

    void aim()
    {
        mouseWorldPosition = Cam.ScreenToWorldPoint(Input.mousePosition);
        direction = (mouseWorldPosition - (Vector2)transform.position).normalized;
        transform.right = direction;
    }

    void shoot()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject arrow = Instantiate(arrowPrefab, shootPosition.position, transform.rotation);
            arrow.GetComponent<Arrow>().launch(direction);
        }
    }

    void Update()
    {
        transform.position = playerTransform.position;
        aim();
        shoot();
    }
}
