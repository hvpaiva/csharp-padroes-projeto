namespace Command
{
    internal class GarageOpenCommand : ICommand
    {
        private readonly Garage _garage;

        public GarageOpenCommand(Garage garage)
        {
            _garage = garage;
        }

        public void Execute()
        {
            _garage.Open();
        }

        public void Undo()
        {
            _garage.Close();
        }
    }
}