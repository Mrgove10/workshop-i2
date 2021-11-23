using System;
using System.Collections.Generic;
using Statics;

public class OnlinePayementInfo
{
    public string Nom = "Payements en Ligne";
    public string Descripton = "couocu je suis la discription";
    public List<Actions> ActionsList = new List<Actions>{ new Actions("nom", "desc", 100, 100, 110) };
}