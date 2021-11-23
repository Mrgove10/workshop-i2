namespace Statics
{
    public class Actions
    {
        public string nom = "";
        public string Description = "";
        public int ImpactBudget =0;
        public int ImpactSecu =0;
        public int ImpactQuanti =0;

        public Actions(string nom, string description, int impactBudget, int impactSecu, int impactQuanti)
        {
            this.nom = nom;
            Description = description;
            ImpactBudget = impactBudget;
            ImpactSecu = impactSecu;
            ImpactQuanti = impactQuanti;
        }
    }
}