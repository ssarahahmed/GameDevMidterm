using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour
{
   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
    
    }
  

    public void goToGame(){

       
        UnityEngine.SceneManagement.SceneManager.LoadScene("gameplay");
    }
}
