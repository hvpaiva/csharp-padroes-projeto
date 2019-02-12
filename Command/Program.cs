using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var remote = new RemoteControl(3);
            
            var car = new Garage("Carro");
            var carDoorClose = new GarageCloseCommand(car);
            var carDoorOpen = new GarageOpenCommand(car);

            remote[0] = new OnOffStruct()
            {
                On = carDoorOpen,
                Off = carDoorClose
            };
            
            var bedroom = new Light("Quarto");
            var bedroomOn = new LightOnCommand(bedroom);
            var bedroomOff = new LightOffCommand(bedroom);

            remote[1] = new OnOffStruct()
            {
                On = bedroomOn,
                Off = bedroomOff
            };
            
            var garage = new Light("Garage");

            ICommand[] departureOn = {new LightOnCommand(garage), carDoorOpen};
            ICommand[] departureOff = {new LightOffCommand(garage), carDoorClose};

            remote[2] = new OnOffStruct()
            {
                On = new MacroCommand(departureOn),
                Off = new MacroCommand(departureOff)
            };
            
            //- Teste
            Log(remote);

        }

        private static void Log(RemoteControl remote)
        {
            remote.PushOn(0);
            remote.PushUndo();
            remote.PushOff(0);
            remote.PushUndo();
            
            Console.WriteLine();
            
            remote.PushOn(1);
            remote.PushUndo();
            remote.PushOff(1);
            remote.PushUndo();
            
            Console.WriteLine();
            
            remote.PushOn(2);
            remote.PushUndo();
            remote.PushOff(2);
            remote.PushUndo();
        }
    }
}