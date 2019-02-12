using Strategy.Behaviour;

namespace Strategy
{
    internal class Hero
    {
        private IFlyBehaviour _fly;
        private IJumpBehaviour _jump;
        private ISpellcasterBehaviour _cast;

        public IFlyBehaviour Fly
        {
            set { _fly = value; }
        }

        public IJumpBehaviour Jump
        {
            set { _jump = value; }
        }

        public ISpellcasterBehaviour CastSpell
        {
            set { _cast = value; }
        }

        public void PerformFly()
        {
            _fly.Fly();
        }

        public void PerformJump()
        {
            _jump.Jump();
        }

        public void PerformCast()
        {
            _cast.Cast();
        }
        
        public void Perform()
        {
            PerformFly();
            PerformCast();
            PerformJump();
        }

    }
}