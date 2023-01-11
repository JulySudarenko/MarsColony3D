using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Code.View
{
    public class BottomPanelView : MonoBehaviour
    {
        [SerializeField] private Transform _bottomPanel;
        [SerializeField] private Transform _leftPanel;
        [SerializeField] private Transform _rightPanel;
        [SerializeField] private Transform _centralPanel;
        [SerializeField] private Transform _buildingsContent;
        [SerializeField] private Button _moveButton;
        [SerializeField] private Button _settingsButton;
        [SerializeField] private Button _buildButton;
        [SerializeField] private Button _buildElement;

        private List<Button> _buildingsElementsList;
        public Button BuildElementButton => _buildElement;
        public Button BuildButton => _buildButton;
        
        public void Init()
        {
            
        }

        private void SetBuildingElement(Sprite icon, Color color)
        {
            var newBuildingElement = Object.Instantiate(_buildElement.transform, _buildingsContent);
            //newBuildingElement.GetComponent<Image>().sprite = icon;
            newBuildingElement.GetComponent<Image>().color = color;
        }
    }
}
