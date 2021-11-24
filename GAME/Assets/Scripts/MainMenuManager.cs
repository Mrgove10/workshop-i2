using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    public Button StartButton;

    void Start()
    {
        StartButton.onClick.AddListener(Launch);
    }

    void Launch(){
        Debug.Log("Launching Main Scene");
        SceneManager.LoadScene("MainScene");
    }
}
