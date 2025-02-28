using UnityEngine;

public class ClawBehavior : MonoBehaviour
{
    public float minX = -5f;
    public float maxX = 5f;
    public float speed = 10f;
    public Vector2 newPosition;
    public Vector3 mousePosG;
    public float fixedY;
    Camera cam;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam = Camera.main;
        fixedY = transform.position.y;
        

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosG = cam.ScreenToWorldPoint(Input.mousePosition);
        float clampedX = Mathf.Clamp(mousePosG.x, minX, maxX);
        Vector3 targetPosition = new Vector3(clampedX, fixedY, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * speed);
        //newPosition = Vector2.MoveTowards(transform.position, mousePosG, speed * Time.deltaTime);
        //transform.position = newPosition;
    }
}
