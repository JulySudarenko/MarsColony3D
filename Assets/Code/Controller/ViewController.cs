using Code.Configs;
using Code.Interfaces;
using Code.View;
using UnityEngine;

namespace Code.Controller
{
    internal class ViewController : IInitialize
    {
        private readonly UIData _uiData;
        private readonly UIData _buildingsConfigs;
        private BottomPanelView _bottomPanelView;

        public ViewController(UnionData unionData)
        {
            _uiData = unionData.UIConfig;
            //_buildingsConfigs = unionData.
        }
        
        public void Initialize()
        {
            var topPanel = Object.Instantiate(_uiData.TopResourcePanelView, _uiData.Canvas.transform);
            var bottomPanel = Object.Instantiate(_uiData.BottomPanelView, _uiData.Canvas.transform);
            _bottomPanelView = bottomPanel.GetComponent<BottomPanelView>();
            
        }
    }
}
