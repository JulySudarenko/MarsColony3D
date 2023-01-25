using Code.Assistance;
using UnityEngine;

namespace Code.Configs
{
    [CreateAssetMenu(fileName = "UnionData", menuName = "Data/UnionData", order = 0)]
    internal class UnionData : ScriptableObject
    {
        [SerializeField] private string _resourcesFolder = "ResConfigs";
        [SerializeField] private string _inputConfigPath = "InputSettings";
        [SerializeField] private string _uiConfigPath = "UIData";
        [SerializeField] private string _buildingsConfigPath = "BuildingsSettings";
        
        private ResourceConfig[] _resourcesConfigs;
        private InputConfig _inputConfig;
        private UIData _uiData;
        private BuildingSettings _buildingSettings;
        
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
        
        public UIData UIConfig
        {
            get
            {
                if (_uiData == null)
                {
                    _uiData = Assistant.Load<UIData>(_uiConfigPath);
                }
        
                return _uiData;
            }
        }
        
        public BuildingSettings BuildingsConfig
        {
            get
            {
                if (_buildingSettings == null)
                {
                    _buildingSettings = Assistant.Load<BuildingSettings>(_buildingsConfigPath);
                }
        
                return _buildingSettings;
            }
        }
    }
}
