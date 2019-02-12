using Strategy.Behaviour;

namespace Strategy
{
    internal class Warrior : Hero
    {
        public Warrior()
        {
            Fly = new FlyNope();
            Jump = new JumpSuper();
            CastSpell = new SpellcasterNope();
        }
    }
}