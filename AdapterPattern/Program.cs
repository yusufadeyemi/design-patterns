// See https://aka.ms/new-console-template for more information
using AdapterPattern;

TwoPinPlug twoPinPlug = new TwoPinPlug("Y", "Y");
ThreePortSocketAdapter threePortSocketAdapter = new ThreePortSocketAdapter(twoPinPlug);
UKSocket socket = new UKSocket(threePortSocketAdapter);
socket.SwitchOn();
Console.ReadKey();