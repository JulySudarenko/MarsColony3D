using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Code.Configs
{
    // Используется для указания типа ресурса и количества этого ресурса необходимого для постройки здания
    [System.Serializable]
    internal class RequiredResourceProperties
    {
        public ResourcesType Type;
        public int Amount;
    }
}