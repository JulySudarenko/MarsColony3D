using Code.Configs;
using Code.UserInput;
using UnityEngine;

namespace Code.Controller
{
    public class StartController : MonoBehaviour
    {
        [SerializeField] private UnionData _unionData;

        private Controllers _controllers;

        private void Awake()
        {
            _controllers = new Controllers();
            
            var inputInitialization = new InputInitialization(_unionData.InputConfig);
            var inputController = new InputController(inputInitialization);
            
            
        }

        private void Start()
        {
            _controllers.Initialize();
        }


        private void Update()
        {
            _controllers.Execute();
        }

        private void FixedUpdate()
        {
            _controllers.FixedExecute();
        }

        private void OnDestroy()
        {
            _controllers.Cleanup();
        }
    }
}
