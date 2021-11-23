using NaughtyAttributes;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [ReadOnly]
    public float quantiq = 0;
    [ReadOnly]
    public float security = 0;
    [ReadOnly]
    public float budget = 0;

    public GameObject popup;

    public Button popupCloseButton;
    // Start is called before the first frame update
    void Start()
    {
        // in case we forgot to uncheck it in ht editor
        ClosePopup();
    }

    // Update is called once per frame
    void Update()
    {
        popupCloseButton.onClick.AddListener(ClosePopup);
    }

    private void LaunchPopup()
    {
        Debug.Log("Launching popup");
        popup.SetActive(true);
    }

    
    private void ClosePopup()
    {
        Debug.Log("Closing popup");
        popup.SetActive(false);
    }
    
    public void LaunchEffect(AreaTypes type)
    {
         LaunchPopup();
    }
}

