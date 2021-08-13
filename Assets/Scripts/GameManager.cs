using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] int winAmount;
    public void NextLevel()
    {
        Bank bank = FindObjectOfType<Bank>();

        if (bank.CurrentBalance >= winAmount)
        {
            PlayerWon();
        }


    }

    void PlayerWon()
    {
        Scene currentscene = SceneManager.GetActiveScene();
        SceneManager.LoadScene("WinScreen");
    }

}
