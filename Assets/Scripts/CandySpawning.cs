using UnityEngine;
using System.Collections;

public class MenuButton : MonoBehaviour
{
    Camera cam;
    public GameObject candyvariants;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            SpawnBall();
        }
    }
    void SpawnBall(){
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10f;
        Vector3 worldP = cam.ScreenToWorldPoint(mousePos);

        Instantiate(candyvariants, worldP, Quaternion.identity);
    }

}
