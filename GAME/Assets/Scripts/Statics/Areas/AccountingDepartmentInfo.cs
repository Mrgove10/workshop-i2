using System;
using System.Collections.Generic;
using Statics;

public static class AccountingDepartmentInfo
{
    public static string Nom = "Service Comptabilité";
    public static string Description = "Le service comptabilité s'occupe des finances de l'entreprise, c'est grâce à leurs calculs que le DSI pilote l'organisation.";
    public static List<Actions> ActionsList = new List<Actions>{
        new Actions(
            "Investir dans ce service en sous-traitant les calculs à un service cloud quantique. (12.000$ /mois)",
            "L'investissement pourrait peut-être améliorer le résultat des calculs.",
            "/!\\ L'investissement a été vain, ce genre de calcul n'a pas besoin d'être quantique.",
            12000,
            0,
            10,
            0
        ),
    };
}