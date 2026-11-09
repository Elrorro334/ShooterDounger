using UnityEngine;

public class aimAndShoot : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    private Camera Cam;
    private Vector2 mouseWorldPosition;

    void Start()
    {
       Cam = Camera.main;
    }

  
    void Update()
    {
        transform.position = playerTransform.position;
        mouseWorldPosition = Cam.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log(mouseWorldPosition);
    }
}
