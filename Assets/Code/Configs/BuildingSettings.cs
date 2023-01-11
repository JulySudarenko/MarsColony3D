using Code.Assistance;
using UnityEngine;

namespace Code.Configs
{
    [CreateAssetMenu(fileName = "BuildingSettings", menuName = "Data/BuildingSettings", order = 0)]
    internal class BuildingSettings : ScriptableObject
    {
        public Transform Terrain;
        
        [SerializeField] private string _buildingsConfigsFolder = "BuildingsConfigs";
        [SerializeField] private Color _freePlaceColor = Color.green;
        [SerializeField] private Color _busyPlaceColor = Color.red;
        [SerializeField] private Color _gizmoColorEven = new Color(0.88f, 0f, 1f, 0.3f);
        [SerializeField] private Color _gizmoColorNotEven = new Color(1f, 0.68f, 0f, 0.3f);

        private BuildingConfig[] _buildingsConfigs;

        public BuildingConfig[] AllBuildingsConfigs
        {
            get
            {
                _buildingsConfigs = Assistant.LoadAll<BuildingConfig>(_buildingsConfigsFolder);
                return _buildingsConfigs;
            }
        }

        public Color FreePlaceColor => _freePlaceColor;

        public Color BusyPlaceColor => _busyPlaceColor;

        public Color GizmoColorEven => _gizmoColorEven;

        public Color GizmoColorNotEven => _gizmoColorNotEven;
    }
}
