using System;
using System.Collections.Generic;
using Statics;

public class RealtimeFraudAnalysisInfo
{
    public static string Nom = "Analyse de fraude en temps réel";
    public static string Description = "Ce service contrôle les transactions pour vérifier leur légitimité.";
    public static List<Actions> ActionsList = new List<Actions>{
        new Actions(
            "Sous traiter les calculs à un service cloud quantique.",
            "La sous-traitance des calculs pourrait peut-être augmenter l'efficience des algorithmes et réduire les fraudes",
            "L'investissement a été utile, votre taux de cybersécurité a augmenté.",
            100, 100, 110
        ),
        new Actions(
            "Améliorer l'algoritme de traitement des données.",
            "Améliorer l'algorithme existant, qui fonctionne bien afin d'augmenter son efficacité",
            "L'algorithme est plus rapide, mais ne fonctionnes plus aussi bien qu'avant, dommage",
            100, 100, 110
        )
    };
}