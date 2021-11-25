using System;
using System.Collections.Generic;
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

    // Bar
    public GameObject BudgetBar;
    public GameObject QuantiumBar;
    public GameObject SecurityBar;

    // Popup
    public GameObject popup;
    public TMP_Text PopUpTitle;
    public TMP_Text PopUpDescription;
    public GameObject Action1;
    public GameObject Action2;
    public TMP_Text Action1Libelle;
    public TMP_Text Action2Libelle;
    public Button popupCloseButton;


    // Tooltip
    public GameObject Tooltip;
    public Button TooltipAction1;
    public Button TooltipAction2;
    public TMP_Text TooltipTxt;
    public string[] helpArray = new string[2] { "", "" };
    public Button TooltipCloseButton;



    // Start is called before the first frame update
    void Start()
    {

        // in case we forgot to uncheck it in ht editor
        ClosePopup();
        // add a listening on the close button
        popupCloseButton.onClick.AddListener(ClosePopup);


        Tooltip.SetActive(false);
        TooltipCloseButton.onClick.AddListener(CloseTooltip);

        TooltipAction1.onClick.AddListener(delegate { LaunchTooltip(0); });
        TooltipAction2.onClick.AddListener(delegate { LaunchTooltip(1); });
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

    private void SetPopupActions(List<Actions> actionsList)
    {
        Action1Libelle.text = actionsList[0].Nom;
        helpArray[0] = actionsList[0].Description;
        try
        {
            Action2Libelle.text = actionsList[1].Nom;
            helpArray[1] = actionsList[1].Description;
            Action2.SetActive(true);
        }
        catch (ArgumentOutOfRangeException)
        {
            Action2.SetActive(false);
        }
    }

    private void CloseTooltip()
    {
        Tooltip.SetActive(false);
    }

    private void LaunchTooltip(int index)
    {
        TooltipTxt.text = helpArray[index];
        Tooltip.SetActive(true);
    }

    public void LaunchEffect(AreaTypes type)
    {

        switch (type)
        {
            case AreaTypes.OnlinePayement:
                PopUpTitle.text = OnlinePayementInfo.Nom;
                PopUpDescription.text = OnlinePayementInfo.Description;
                SetPopupActions(OnlinePayementInfo.ActionsList);
                break;
            case AreaTypes.HrDepartment:
                PopUpTitle.text = HrDepartmentInfo.Nom;
                PopUpDescription.text = HrDepartmentInfo.Description;
                SetPopupActions(HrDepartmentInfo.ActionsList);
                break;
            case AreaTypes.ItDepartment:
                PopUpTitle.text = ItDepartmentInfo.Nom;
                PopUpDescription.text = ItDepartmentInfo.Description;
                SetPopupActions(ItDepartmentInfo.ActionsList);
                break;
            case AreaTypes.SalesDepartment:
                PopUpTitle.text = SalesDepartmentInfo.Nom;
                PopUpDescription.text = SalesDepartmentInfo.Description;
                SetPopupActions(SalesDepartmentInfo.ActionsList);
                break;
            case AreaTypes.DatabaseSecurity:
                PopUpTitle.text = DatabaseSecurityInfo.Nom;
                PopUpDescription.text = DatabaseSecurityInfo.Description;
                SetPopupActions(DatabaseSecurityInfo.ActionsList);
                break;
            case AreaTypes.RealtimeFraudAnalysis:
                PopUpTitle.text = RealtimeFraudAnalysisInfo.Nom;
                PopUpDescription.text = RealtimeFraudAnalysisInfo.Description;
                SetPopupActions(RealtimeFraudAnalysisInfo.ActionsList);
                break;
            case AreaTypes.HighSpeedTrading:
                PopUpTitle.text = HighSpeedTradingInfo.Nom;
                PopUpDescription.text = HighSpeedTradingInfo.Description;
                SetPopupActions(HighSpeedTradingInfo.ActionsList);
                break;
            case AreaTypes.AccountingDepartment:
                PopUpTitle.text = AccountingDepartmentInfo.Nom;
                PopUpDescription.text = AccountingDepartmentInfo.Description;
                SetPopupActions(AccountingDepartmentInfo.ActionsList);
                break;
            case AreaTypes.CryptoTrading:
                PopUpTitle.text = CryptoTradingInfo.Nom;
                PopUpDescription.text = CryptoTradingInfo.Description;
                SetPopupActions(CryptoTradingInfo.ActionsList);
                break;
        }

        LaunchPopup();
    }

    private void UpdateUI()
    {
        BudgetBar.GetComponentInChildren<TMP_Text>().text = budget.ToString();
        QuantiumBar.GetComponentInChildren<TMP_Text>().text = quantium.ToString();
        SecurityBar.GetComponentInChildren<TMP_Text>().text = security.ToString();
    }
}

