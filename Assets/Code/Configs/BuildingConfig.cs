using System.Collections.Generic;
using UnityEngine;
using System;

namespace Code.Configs
{
    [CreateAssetMenu(fileName = "BuildingConfig", menuName = "Data/BuildingConfig", order = 0)]
    internal class BuildingConfig : ScriptableObject
    {
        public Transform Prefab;
        public Transform Icon;
        [SerializeField] private BuildingsType _type;
        [SerializeField] private string _name;
        [SerializeField] private string _description;
        [SerializeField] private List<RequiredResourceProperties> _requiredResources;
        [SerializeField] private int _minWorkerAmount; // Минимальное количество персонала, необходимое для работы здания
        [SerializeField] private int _maxWorkerAmount; // Максимальное количество персонала, необходимое для работы здания
        [SerializeField] private int _energyPerPerson; // Потребляемая энергия одним работником
        [SerializeField] private int _energyForUpkeep; // Потребляемая энергия вне зависимости от работников

        public BuildingsType Type => _type;
    }
}