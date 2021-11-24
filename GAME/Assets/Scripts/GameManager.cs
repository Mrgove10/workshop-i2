using System;
using NaughtyAttributes;
using Statics;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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
    public TMP_Text PopUpTitle;
    public TMP_Text PopUpDescription;

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

        switch (type)
        {
            case AreaTypes.OnlinePayement:
                PopUpTitle.text = OnlinePayementInfo.Nom;
                PopUpDescription.text = OnlinePayementInfo.Description;
            break;
            case AreaTypes.HrDepartment:
                PopUpTitle.text = HrDepartmentInfo.Nom;
                PopUpDescription.text = HrDepartmentInfo.Description;
            break;
            case AreaTypes.ItDepartment:
                PopUpTitle.text =ItDepartmentInfo.Nom;
                PopUpDescription.text = ItDepartmentInfo.Description;
            break;
            case AreaTypes.SalesDepartment:
                PopUpTitle.text =SalesDepartmentInfo.Nom;
                PopUpDescription.text = SalesDepartmentInfo.Description;
            break;
            case AreaTypes.DatabaseSecurity:
                PopUpTitle.text =DatabaseSecurityInfo.Nom;
                PopUpDescription.text = DatabaseSecurityInfo.Description;
            break;
            case AreaTypes.RealtimeFraudAnalysis:
                PopUpTitle.text =RealtimeFraudAnalysisInfo.Nom;
                PopUpDescription.text = RealtimeFraudAnalysisInfo.Description;
            break;
            case AreaTypes.HighSpeedTrading:
                PopUpTitle.text =HighSpeedTradingInfo.Nom;
                PopUpDescription.text = HighSpeedTradingInfo.Description;
            break;
            case AreaTypes.AccountingDepartment:
                PopUpTitle.text =AccountingDepartmentInfo.Nom;
                PopUpDescription.text = AccountingDepartmentInfo.Description;
            break;
            case AreaTypes.CryptoTrading:
                PopUpTitle.text = CryptoTradingInfo.Nom;
                PopUpDescription.text = CryptoTradingInfo.Description;
            break;
        }

        LaunchPopup();
    }

    private void UpdateUI()
    {
      //  BudgetBar.GetComponent<Text>().text = budget.ToString();
      // QuantiumBar.GetComponent<Text>().text = quantium.ToString();
       // SecurityBar.GetComponent<Text>().text = security.ToString();
    }
}

