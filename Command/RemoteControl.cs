namespace Command
{
    internal class RemoteControl
    {
        private readonly ICommand[] _offCommands;
        private readonly ICommand[] _onCommands;
        private ICommand _undoCommand;

        public RemoteControl(int slots)
        {
            _onCommands = new ICommand[slots];
            _offCommands = new ICommand[slots];
            
            var none = new NoCommand();

            _undoCommand = none;

            for (var i = 0; i < slots; i++)
            {
                _onCommands[i] = none;
                _offCommands[i] = none;
            }
        }

        public OnOffStruct this[int i]
        {
            set
            {
                _onCommands[i] = value.On;
                _offCommands[i] = value.Off;
            }
        }

        public void PushOn(int slot)
        {
            _onCommands[slot].Execute();
            _undoCommand = _onCommands[slot];
        }

        public void PushOff(int slot)
        {
            _offCommands[slot].Execute();
            _undoCommand = _offCommands[slot];
        }

        public void PushUndo()
        {
            _undoCommand.Undo();
        }
    }
}