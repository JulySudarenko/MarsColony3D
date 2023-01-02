using Code.Interfaces;


namespace Code.UserInput
{
    internal sealed class InputController : IExecute
    {
        // private readonly IUserInputProxy _inputHorizontal;
        // private readonly IUserInputProxy _inputVertical;
        private readonly IUserInputButtonProxy _inputMouseLeft;
        // private readonly IUserInputButtonProxy _inputJump;
        // private readonly IUserInputButtonProxy _inputWork;
        
        public InputController(InputInitialization input)
        {
            // _inputHorizontal = input.InputHorizontal;
            // _inputVertical = input.InputVertical;
            _inputMouseLeft = input.InputMouseLeft;
            // _inputJump = input.InputJump;
            // _inputWork = input.InputWork;
        }

        public void Execute()
        {
            // _inputHorizontal.GetAxis();
            // _inputVertical.GetAxis();
            _inputMouseLeft.GetButtonDown();
            _inputMouseLeft.GetButtonHold();
            _inputMouseLeft.GetButtonUp();
            // _inputWork.GetButtonDown();
            // _inputWork.GetButtonHold();
            // _inputWork.GetButtonUp();
            // _inputJump.GetButtonDown();
            // _inputJump.GetButtonHold();
            // _inputJump.GetButtonUp();
        }
    }
}
