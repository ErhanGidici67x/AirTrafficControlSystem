namespace AirTrafficControlSystem
{
    internal interface IATCMediator
    {
        public void registerFlight(Flight flight);
        public void deregisterFlight(Flight flight);
        public void requestLanding(Flight flight);
        public void grantLanding(Flight flight);
        public void denyLanding(Flight flight);
    }
}
