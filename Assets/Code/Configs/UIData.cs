using UnityEngine;

namespace Code.Configs
{
    [CreateAssetMenu(fileName = "UIData", menuName = "Data/UIData")]
    public class UIData : ScriptableObject//, ICanvas
    {
        // [SerializeField] private string _topPanelPath = "UI/TopPanel"; 
        // [SerializeField] private string _bottomPanelPath = "UI/BottomPanel"; 
        // private TopResourcePanelView _topResourcePanelView;
        // private BottomPanelView _bottomPanelView;        
        public Transform TopResourcePanelView;
        public Transform BottomPanelView;
        private Canvas _canvas;

        public Canvas Canvas
        {
            get
            {
                if (_canvas == null)
                {
                    _canvas = Object.FindObjectOfType<Canvas>();
                }
                return _canvas;
            }
        }
        //
        // public TopResourcePanelView TopResourcePanel
        // {
        //     get
        //     {
        //         if (_topResourcePanelView == null)
        //         {
        //             _topResourcePanelView =  Assistant.Load<TopResourcePanelView>(_topPanelPath);
        //             Debug.Log(_topResourcePanelView.name);
        //         }
        //
        //         return _topResourcePanelView;
        //     }
        // }
        //
        // public BottomPanelView BottomResourcePanel
        // {
        //     get
        //     {
        //         if (_bottomPanelView == null)
        //         {
        //             _bottomPanelView =  Assistant.Load<BottomPanelView>(_bottomPanelPath);
        //             Debug.Log(_bottomPanelView.name);
        //         }
        //
        //         return _bottomPanelView;
        //     }
        // }
    }
}
