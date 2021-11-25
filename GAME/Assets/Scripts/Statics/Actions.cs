namespace Statics
{
    public class Actions
    {
        public string Nom = "";
        public string Description = "";
        public string ImpactString = "";
        public int CoutInvestissement = 0;
        public int ImpactBudget = 0;
        public int ImpactSecu = 0;
        public int ImpactQuanti = 0;

        public Actions(
            string nom,
            string description,
            string impactString,
            int coutinvest,
            int impactSecu,
            int impactQuanti,
            int impactBudget
        ) {
            Nom = nom;
            Description = description;
            ImpactString = impactString;
            CoutInvestissement = coutinvest;
            ImpactSecu = impactSecu;
            ImpactQuanti = impactQuanti;
            ImpactBudget = impactBudget;
        }
    }
}