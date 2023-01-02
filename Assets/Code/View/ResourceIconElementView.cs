using UnityEngine;
using UnityEngine.UI;

namespace Code.View
{
    internal class ResourceIconElementView : MonoBehaviour
    {
        [SerializeField] private Image _icon;
        [SerializeField] private Image _countCircle;
        [SerializeField] private TextMesh _resourceCount;

        public void Init()
        {
            
        }
        
        private void SetIcons(Sprite icon, Sprite countIcon, int startCount)
        {
            _icon.sprite = icon;
            _countCircle.sprite = icon;
            _resourceCount.text = startCount.ToString();
        }

        private void ShowResourceCount(int count)
        {
            _resourceCount.text = count.ToString();
        }
    }
}
