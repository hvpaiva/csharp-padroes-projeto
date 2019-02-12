namespace Command
{
    internal class GarageCloseCommand : ICommand
    {
        private readonly Garage _garage;

        public GarageCloseCommand(Garage garage)
        {
            _garage = garage;
        }

        public void Execute()
        {
            _garage.Close();
        }

        public void Undo()
        {
            _garage.Open();
        }
    }
}