using StateDesignPattern.ConcreteState;

namespace StateDesignPattern
{
    public class Player
    {
        public IState PlayerState { get; set; }

        public Player()
        {
            this.PlayerState = new HealthyState();
        }

        public void Bullethit(int bullets)
        {
            if (bullets < 5)
            {
                this.PlayerState = new HealthyState();
            }
            else if (bullets > 5 && bullets <= 10)
            {
                this.PlayerState = new HurtState();
            }
            else
            {
                this.PlayerState = new DeadState();
            }


            PlayerState.ExecuteState(this);
        }
    }
}