using System;
using System.Collections.Generic;
using Statics;

public class CryptoTradingInfo
{
    public string Nom = "Trading de cryptomonnaies";
    public string Description = "Ce service permet de spéculer et réguler sur les marchés financier digitaux (cryptomonnaies).";
    public List<Actions> ActionsList = new List<Actions>{
        new Actions(
            "Investir dans ce service en sous-traitant les calculs à un service cloud quantiques.",
            "L'investissement pourrait peut-être améliorer les prédictions de la fluctuation du marché.",
            "L'investissement était nécessaire et rentable, votre budget augmente.",
            100, 100, 110
        ),
    };
}