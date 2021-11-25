using System;
using System.Collections.Generic;
using Statics;

public static class ItDepartmentInfo
{
    public static string Nom = "Service Informatique";
    public static string Description = "Ce service est responsable du support et innovations techniques.";
    public static List<Actions> ActionsList = new List<Actions>{
        new Actions(
            "Utiliser les services clouds quantique pour accélerer le développement des applicatifs (15.000$ /mois).",
            "Un ordinateur plus rapide pourrait peut-être améliorer la productivité des développeurs.",
            "/!\\ L'investissement n'est pas du tout utile. Une machine plus puissante ne remplace pas l'ingéniosité et l'expertise des développeurs",
            -15000, 0, 10
        )
    };
}