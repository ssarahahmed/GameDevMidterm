using UnityEngine;

public class Restart : MonoBehaviour
{

    public void goToMainMenu(){
         UnityEngine.SceneManagement.SceneManager.LoadScene("mainMenu");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
