namespace Ucu.Poo.Defense
{
    public class Residue
    {
        public string Name { get; set; }

        public ResidueType Type { get; set; }
        public bool IsOrganic ;

        public Residue(string name, ResidueType type)
        {
            this.Name = name;
            this.Type = type;
            this.IsOrganic = type.IsOrganic;
            
        }

    }
}