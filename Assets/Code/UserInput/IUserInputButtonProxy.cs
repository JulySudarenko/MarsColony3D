using System;

namespace Code.UserInput
{
    public interface IUserInputButtonProxy
    {
        event Action<bool> OnButtonDown;
        event Action<bool> OnButtonHold;
        event Action<bool> OnButtonUp;

        void GetButtonDown();
        void GetButtonHold();
        void GetButtonUp();
    }
}
