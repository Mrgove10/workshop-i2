using System;
using System.Collections.Generic;
using Statics;

public static class CryptoTradingInfo
{
    public static string Nom = "Trading de cryptomonnaies";
    public static string Description = "Ce service permet de spéculer et réguler sur les marchés financier digitaux (cryptomonnaies).";
    public static List<Actions> ActionsList = new List<Actions>{
        new Actions(
            "Investir dans ce service en sous-traitant les calculs à un service cloud quantique (70.000$ /mois).",
            "L'investissement pourrait peut-être améliorer les prédictions de la fluctuation du marché.",
            "L'investissement était nécessaire et rentable, votre budget augmente.",
            20000, 0, 50
        ),
    };
}