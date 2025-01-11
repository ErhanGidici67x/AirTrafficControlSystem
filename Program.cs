using AirTrafficControlSystem;

IATCMediator mediator = new ATCCentral();

Flight flight1 = new Flight(1);
Flight flight2 = new Flight(2);

mediator.registerFlight(flight1);
mediator.registerFlight(flight2);

flight1.requestLanding();
flight2.requestLanding();

flight2.land();
flight1.denyLanding();
flight2.denyLanding();
flight1.notifyLandingRequest(flight2);

Console.WriteLine("Hello, World!");
