namespace Statics
{
    public class Actions
    {
        public string Nom = "";
        public string Description = "";
        public string ImpactString = "";
        public int ImpactBudget = 0;
        public int ImpactSecu = 0;
        public int ImpactQuanti = 0;

        public Actions(string nom, string description, string impactString, int impactBudget, int impactSecu, int impactQuanti)
        {
            Nom = nom;
            Description = description;
            ImpactBudget = impactBudget;
            ImpactString = impactString;
            ImpactSecu = impactSecu;
            ImpactQuanti = impactQuanti;
        }
    }
}