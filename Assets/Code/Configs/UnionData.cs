using System.Diagnostics.Contracts;
using Code.Assistance;
using Code.UserInput;
using UnityEngine;

namespace Code.Configs
{
    [CreateAssetMenu(fileName = "UnionConfig", menuName = "Data/UnionConfig", order = 0)]
    internal class UnionData : ScriptableObject
    {
        [SerializeField] private string _resourcesFolder = "ResConfigs";
        [SerializeField] private string _inputConfigPath = "InputSettings";
        
        private ResourceConfig[] _resourcesConfigs;
        private InputConfig _inputConfig;
        
        public ResourceConfig[] AllResourcesConfigs
        {
            get
            {
                _resourcesConfigs = Assistant.LoadAll<ResourceConfig>(_resourcesFolder);
                return _resourcesConfigs;
            }
        }
        
        public InputConfig InputConfig
        {
            get
            {
                if (_inputConfig == null)
                {
                    _inputConfig = Assistant.Load<InputConfig>(_inputConfigPath);
                }
        
                return _inputConfig;
            }
        }
    }
}
