using System.Collections.Generic;
using Code.Interfaces;

namespace Code.Controller
{
    internal sealed class Controllers : IInitialize, IFixedExecute, IExecute, ICleanup
    {
        private readonly List<IInitialize> _initializeControllers;
        private readonly List<IFixedExecute> _fixedControllers; 
        private readonly List<IExecute> _executeControllers;
        private readonly List<ICleanup> _cleanupControllers;

        internal Controllers()
        {
            _initializeControllers = new List<IInitialize>();
            _fixedControllers = new List<IFixedExecute>();
            _executeControllers = new List<IExecute>();
            _cleanupControllers = new List<ICleanup>();
        }

        internal Controllers Add(IController controller)
        {
            if (controller is IInitialize initializeController)
            {
                _initializeControllers.Add(initializeController);
            }
            
            if (controller is IFixedExecute fixedController)
            {
                _fixedControllers.Add(fixedController);
            }

            if (controller is IExecute executeController)
            {
                _executeControllers.Add(executeController);
            }

            if (controller is ICleanup cleanupController)
            {
                _cleanupControllers.Add(cleanupController);
            }

            return this;
        }

        public void Initialize()
        {
            for (var index = 0; index < _initializeControllers.Count; ++index)
            {
                _initializeControllers[index].Initialize();
            }
        }

        public void FixedExecute()
        {
            for (var index = 0; index < _fixedControllers.Count; ++index)
            {
                _fixedControllers[index].FixedExecute();
            }
        }

        public void Execute()
        {
            for (var index = 0; index < _executeControllers.Count; ++index)
            {
                _executeControllers[index].Execute();
            }
        }

        public void Cleanup()
        {
            for (var index = 0; index < _cleanupControllers.Count; ++index)
            {
                _cleanupControllers[index].Cleanup();
            }
        }
    }
}
