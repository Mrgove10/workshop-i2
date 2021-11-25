using System;
using System.Collections.Generic;
using Statics;

public class HrDepartmentInfo
{
    public static string Nom = "Service des Ressources Humaines";
    public static string Description = "Ce service est responsable des ressouces humaines de l'organisation.";
    public static List<Actions> ActionsList = new List<Actions>{
        new Actions(
            "Améliorer la recherche d'informations sur un candidat grâce aux services cloud quantique (2.000$ /mois).",
            "L'investissement pourrait peut-être améliorer le recrutement, faire chuter le taux de turn-over et de potentielles failles humaines de sécurité.",
            "/!\\ L'investissement n'était pas utile, il vaux mieux investir dans de la formation et de la sensibilisation.",
            2000, 0, 10, 0
        )
    };
}