using UnityEngine.SceneManagement;
using UnityEngine;

public class WinLoseWindow : MonoBehaviour
{
    public void selectLevel()
    {
        SceneManager.LoadScene("LevelSelection");
    }
   
    public void returnToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

 
}
