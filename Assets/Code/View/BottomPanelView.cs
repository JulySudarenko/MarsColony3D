using UnityEngine;
using UnityEngine.UI;

namespace Code.View
{
    internal class BottomPanelView : MonoBehaviour
    {
        [SerializeField] private Transform _bottomPanel;
        [SerializeField] private Transform _leftPanel;
        [SerializeField] private Transform _rightPanel;
        [SerializeField] private Transform _centralPanel;
        [SerializeField] private Button _move;
        [SerializeField] private Button _settings;
        [SerializeField] private Button _build;
    }
}
