using UnityEngine;

namespace Code.Configs
{
    [CreateAssetMenu(fileName = "BuildingConfig", menuName = "Data/BuildingConfig", order = 0)]
    internal class BuildingConfig : ScriptableObject
    {
        public Transform Prefab;
        public Transform Icon;
        [SerializeField] private BuildingsType _type;

        public BuildingsType Type => _type;
    }
}