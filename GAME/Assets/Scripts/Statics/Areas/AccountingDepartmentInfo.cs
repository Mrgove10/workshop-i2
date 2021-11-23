using System;
using System.Collections.Generic;
using Statics;

public class AccountingDepartmentInfo
{
    public string Nom = "Service Comptabilité";
    public string Description = "Le service comptabilité s'occupe des finances de l'entreprise, c'est grâce à leurs calculs que le DSI pilote l'organisation.";
    public List<Actions> ActionsList = new List<Actions>{
        new Actions(
            "Investir dans ce service en sous-traitant les calculs à un service cloud quantiques.",
            "L'investissement pourrait peut-être améliorer le résultat des calculs.",
            "/!\\ L'investissement a été vain, ce genre de calcul n'a pas besoin d'être quantique.",
            100, 100, 110
        ),
    };
}