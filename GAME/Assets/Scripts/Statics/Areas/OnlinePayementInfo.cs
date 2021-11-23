using System;
using System.Collections.Generic;
using Statics;

public class OnlinePayementInfo
{
    public string Nom = "Paiements en ligne";
    public string Description = "Le service des paiements en lignes s'occupe en grande partie de réceptionner les tickets des clients. \nUne branche R&D a nouvellement été créée pour ce service.";
    public List<Actions> ActionsList = new List<Actions>{
        new Actions(
            "Investir dans la R&D en ajoutant un ordinateur quantique",
            "L'ajout d'un ordinateur quantique pourrait peut-être améliorer le chiffrement des transactions, donc, la sécurité des échanges.",
            "L'investissement a été utile, votre taux de cybersécurité a augmenté.",
            100, 100, 110
        )
    };
}