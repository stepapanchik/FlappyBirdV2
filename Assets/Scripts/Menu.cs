using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject menuUI;

    void Start()
    {
        
    }

    public void StartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
        Score.score = 0;
    }
    


    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("exit");
    }


}
