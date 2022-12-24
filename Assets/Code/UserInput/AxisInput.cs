using System;
using UnityEngine;


namespace Code.UserInput
{
    internal sealed class AxisInput : IUserInputProxy
    {
        public event Action<float> AxisOnChange = delegate(float f) { };

        private readonly string _axis;

        public AxisInput(string axis)
        {
            _axis = axis;
        }

        public void GetAxis()
        {
            AxisOnChange?.Invoke(Input.GetAxis(_axis));
        }
    }
}
