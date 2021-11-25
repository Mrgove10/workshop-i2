using System;
using System.Collections.Generic;
using Statics;


public static class OnlinePayementInfo
{
    public static string Nom = "Paiements en ligne";
    public static string Description = "Le service des paiements en lignes s'occupe en grande partie de réceptionner les tickets des clients. \nUne branche R&D a nouvellement été créée pour ce service. ";
    public static List<Actions> ActionsList = new List<Actions>{
        new Actions(
            "Investir dans la R&D en ajoutant un ordinateur quantique (20.000$ /mois).",
            "L'ajout d'un ordinateur quantique pourrait peut-être améliorer le chiffrement des transactions, donc, la sécurité des échanges.",
            "L'investissement a été utile, votre taux de cybersécurité a augmenté.",
            20000, 100, 20, 0
        )
    };
}
