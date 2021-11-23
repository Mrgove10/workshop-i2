using System;
using System.Collections.Generic;
using Statics;

public class SalesDepartmentInfo
{
    public string Nom = "Service commercial";
    public string Descripton = "Ce service regroupe tous les commerciaux de la banque, il sont nécessaire pour démarcher les nouveaux clients";
    public List<Actions> ActionsList = new List<Actions>{
        new Actions(
            "Ajouter un service cloud quantique pour trouver de nouveaux clients.",
            "La sous-traitance des calculs pourrait peut-être une solution pour rechercher de nouveaux clients",
            "L'investissement n'était pas abouti, il n'est pas nécessaire d'avoir un ordinateur quantique pour déterminer de potentiels clients",
            100, 100, 110
        )
    };
}