using System;
using System.Collections.Generic;
using Statics;

public static class DatabaseSecurityInfo
{
    public static string Nom = "Sécurisation des bases de données";
    public static string Description = "Ce service est responsable de l'intégrité et la sécurisation des données du SI.";
    public static List<Actions> ActionsList = new List<Actions>{
        new Actions(
            "Sous-traiter les chiffrement à un service cloud quantique (35.000$ /mois).",
            "L'investissement pourrait peut-être améliorer le chiffrement des données et la sécurisation des accès.",
            "/!\\ L'investissement n'était pas utile, il aurait été préférable de modifier l'algorithme de chiffrement des données (Exemple: AES qui n'est pas sensible à l'informatique quantique).",
            35000,
            -10,
            10,
            0
        ),
        new Actions(
            "Modifier l'algorithme de chiffrement des données. (1.000$ /mois)",
            "L'investissement pourrait peut-être améliorer la sécurité des données face aux ordinateurs quantiques.",
            "L'investissement a été payant, et à moindre coûts.",
            -1000,
            100,
            0,
            0
        )
    };
}