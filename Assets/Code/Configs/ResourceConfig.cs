using UnityEngine;

namespace Code.Configs
{
    [CreateAssetMenu(fileName = "ResourceConfig", menuName = "Data/ResourceConfig", order = 0)]
    internal class ResourceConfig : ScriptableObject
    {
        public Sprite TopIcon;
        public Sprite TopTextIcon;
        [SerializeField] private ResourcesType _type;
        [SerializeField] private int _startCount;

        public int StartCount => _startCount;
    }
}
