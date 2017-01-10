namespace Common
{
    public class Ninja : INinja
    {
        public Ninja(string name, int skillLevel)
        {
            Name = name;
            Skills = skillLevel;
        }
        public string Name { get; set; }
        public int Skills { get; set; }
    }
}