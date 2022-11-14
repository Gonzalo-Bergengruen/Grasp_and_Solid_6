namespace Full_GRASP_And_SOLID
{
    public class ClientTimer : TimerClient
    {
        public Recipe recipe {get;set;}
        public ClientTimer(Recipe recipe, int timepo)
        {
            this.recipe = recipe;
            CountdownTimer countdownTimer = new CountdownTimer();
            countdownTimer.Register(timepo, this);
        }
        public void TimeOut()
        {
            this.recipe.Cooked = true;
        }
    }
}