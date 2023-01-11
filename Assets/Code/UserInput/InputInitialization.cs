 using Code.Configs;

 namespace Code.UserInput
{
    public sealed class InputInitialization
    {
        // private readonly IUserInputProxy _inputHorizontal;
        // private readonly IUserInputProxy _inputVertical;
        // private readonly IUserInputButtonProxy _inputJump;
        // private readonly IUserInputButtonProxy _inputWork;
        private readonly IUserInputButtonProxy _inputMouseLeft;


        public InputInitialization(InputConfig config)
        {
            // _inputHorizontal = new AxisInput(config.Horizontal);
            // _inputVertical = new AxisInput(config.Vertical);
            // _inputJump = new ButtonInput(config.Jump);
            // _inputWork = new ButtonInput(config.Work);
            _inputMouseLeft  = new ButtonInput(config.MouseLeftInput);
        }

        // public IUserInputProxy InputHorizontal => _inputHorizontal;
        // public IUserInputProxy InputVertical => _inputVertical;
        // public IUserInputButtonProxy InputJump => _inputJump;
        // public IUserInputButtonProxy InputWork => _inputWork;
        public IUserInputButtonProxy InputMouseLeft => _inputMouseLeft;
    }
}
