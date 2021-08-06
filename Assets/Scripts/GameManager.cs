using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void NextLevel()
    {
        Bank bank = FindObjectOfType<Bank>();

        if (bank.CurrentBalance >= 500)
        {
            Scene currentscene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentscene.buildIndex + 1);
        }
    }
}
