namespace AirTrafficControlSystem
{
    internal class Flight
    {
        private int id;
        private IATCMediator mediator;
        private bool landed = false;

        public Flight(int id)
        {
            this.id = id;
        }
        public int getId()
        {
            return id;
        }

        public void setMediator(IATCMediator mediator)
        {
            this.mediator = mediator;
        }

        public void requestLanding()
        {
            mediator.requestLanding(this);
        }

        public void land()
        {
            Console.WriteLine("Flight " + id + " landed");
            landed = true;
        }

        public void denyLanding()
        {
            Console.WriteLine("Flight " + id + " denied landing");
        }

        public bool isLanded()
        {
            return landed;
        }

        public void notifyLandingRequest(Flight flight)
        {
            if (isLanded())
            {
                mediator.denyLanding(flight);
            }
        }
    }
}
