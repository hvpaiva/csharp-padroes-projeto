using Strategy.Behaviour;

namespace Strategy
{
    internal class Mage : Hero
    {
        public Mage()
        {
            Fly = new FlySuper();
            Jump = new JumpNormal();
            CastSpell = new SpellcasterElementar();
        }
    }
}