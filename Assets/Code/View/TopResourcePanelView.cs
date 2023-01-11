using UnityEngine;

namespace Code.View
{
    public class TopResourcePanelView : MonoBehaviour
    {
        [SerializeField] private Transform _topPanel;
        [SerializeField] private Transform _firstGroup;
        [SerializeField] private Transform _secondGroup;
        [SerializeField] private Transform _thirdGroup;
        [SerializeField] private Transform _fourthGroup;
        [SerializeField] private ResourceIconElementView[] _resourceIconElementViews;

        private void Init()
        {
        }
    }
}
