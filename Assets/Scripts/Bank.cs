using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Bank : MonoBehaviour
{
    [SerializeField] int startingBalance = 150;
    [SerializeField] int currentBalance;
    [SerializeField] TextMeshProUGUI displayBalance;
    [SerializeField] TextMeshProUGUI warningMessage;

    public int CurrentBalance { get { return currentBalance; } }
    void Awake()
    {
        currentBalance = startingBalance;
        updateDisplay();
        warningMessage.gameObject.SetActive(false);
    }


    public void Deposit(int amount)
    {
        currentBalance += Mathf.Abs(amount);
        updateDisplay();
    }

    public void withDraw(int amount)
    {
        currentBalance -= Mathf.Abs(amount);
        updateDisplay();
        if (currentBalance <= 0)
        {
            Invoke("ReloadScence", 1f);

        }
    }

    void updateDisplay()
    {
        displayBalance.text = "Gold:" + currentBalance;
        FindObjectOfType<GameManager>().NextLevel();

        if (currentBalance <= 100)
        {
            warningMessage.gameObject.SetActive(true);
        }
        else
        {
            warningMessage.gameObject.SetActive(false);
        }
    }

    void ReloadScence()
    {
        Scene currentscene = SceneManager.GetActiveScene();
        SceneManager.LoadScene("LoseScreen");
    }




}
