using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;



public class LevelSelection : MonoBehaviour
{
    [SerializeField] public bool isplayable;

    public void PressSelection(string _levelname)
    {
        if (isplayable == true)
        {
            SceneManager.LoadScene(_levelname);
        }
    }
}
