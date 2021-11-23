using NaughtyAttributes;
using Statics;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [ReadOnly]
    public float quantium = 0;
    [ReadOnly]
    public float security = 0;
    [ReadOnly]
    public float budget = 0;

    public GameObject BudgetBar;
    public GameObject QuantiumBar;
    public GameObject SecurityBar;
    
    public GameObject popup;

    public Button popupCloseButton;
    // Start is called before the first frame update
    void Start()
    {
        // in case we forgot to uncheck it in ht editor
        ClosePopup();
        // add a listening on the close button
        popupCloseButton.onClick.AddListener(ClosePopup);
    }

    // Update is called once per frame
    void Update()
    {
        UpdateUI();
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
    
    private void UpdateUI()
    {
        BudgetBar.GetComponent<Text>().text = budget.ToString();
        QuantiumBar.GetComponent<Text>().text = quantium.ToString();
        SecurityBar.GetComponent<Text>().text = security.ToString();
    }
}

