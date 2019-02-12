namespace Bridge
{
    public interface IEnchantment
    {
        void OnActivate(string weaponName);
        void Apply(string weaponName);
        void OnDeactivate(string weaponName);
    }
}