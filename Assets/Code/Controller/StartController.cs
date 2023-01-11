using Code.Configs;
using Code.UserInput;
using UnityEngine;

namespace Code.Controller
{
    public class StartController : MonoBehaviour
    {
        [SerializeField] private UnionData _unionData;

        private Controllers _controllers;

        private void Awake()
        {
            _controllers = new Controllers();
            
            var inputInitialization = new InputInitialization(_unionData.InputConfig);
            var inputController = new InputController(inputInitialization);

            var viewController = new ViewController(_unionData);

            _controllers.Add(inputController);
        }

        private void Start()
        {
            _controllers.Initialize();
        }


        private void Update()
        {
            _controllers.Execute();
        }

        private void FixedUpdate()
        {
            _controllers.FixedExecute();
        }

        private void OnDestroy()
        {
            _controllers.Cleanup();
        }
    }
    
    public class Building : MonoBehaviour
    {
        #region Field

        public Renderer MainRenderer;
        public Vector2Int Size = Vector2Int.one;

        #endregion


        #region UnityMethods
    
        private void OnDrawGizmos()
        {
            for (int x = 0; x < Size.x; x++)
            {
                for (int y = 0; y < Size.y; y++)
                {
                    if ((x + y) % 2 == 0)
                        Gizmos.color = new Color(0.88f, 0f, 1f, 0.3f);
                    else
                        Gizmos.color = new Color(1f, 0.68f, 0f, 0.3f);

                    Gizmos.DrawCube(transform.position + new Vector3(x, 0, y), new Vector3(1, 1f, 1));
                }
            }
        }

        #endregion


        #region Methods

        public void SetTransparent(bool available)
        {
            if (available)
            {
                MainRenderer.material.color = Color.green;
            }
            else
            {
                MainRenderer.material.color = Color.red;
            }
        }

        public void SetNormal()
        {
            MainRenderer.material.color = Color.white;
        }

        #endregion
    }
    
    public class BuildingsGrid : MonoBehaviour
{
    #region Field

    public Vector2Int GridSize = new Vector2Int(20, 10);

    private Building[,] _grid;
    private Building _flyingBuilding;
    private Camera _mainCamera;

    #endregion


    #region UnityMethods

    private void Awake()
    {
        _grid = new Building[GridSize.x, GridSize.y];
        _mainCamera = Camera.main;
    }

    private void Update()
    {
        if (_flyingBuilding != null)
            CreateBuilding();
    }

    #endregion


    #region Methods

    public void StartPlacingBuilding(Building buldingPrefab)
    {
        if (_flyingBuilding != null)
        {
            Destroy(_flyingBuilding.gameObject);
        }

        _flyingBuilding = Instantiate(buldingPrefab);
    }

    private void CreateBuilding()
    {
        Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
        Ray ray = _mainCamera.ScreenPointToRay(Input.mousePosition);

        if (groundPlane.Raycast(ray, out float position))
        {
            Vector3 worldPosition = ray.GetPoint(position);

            int x = Mathf.RoundToInt(worldPosition.x);
            int y = Mathf.RoundToInt(worldPosition.z);

            bool available = true;

            if (x < 0 || x > GridSize.x - _flyingBuilding.Size.x) available = false;
            if (y < 0 || y > GridSize.y - _flyingBuilding.Size.y) available = false;

            if(available && IsPlaceTaken(x,y)) available = false;

            _flyingBuilding.transform.position = new Vector3(x, 0, y);
            _flyingBuilding.SetTransparent(available);

            if (available && Input.GetMouseButtonDown(0))
            {
                PlaceFlyingBuilding(x, y);
            }
        }
    }

    private void PlaceFlyingBuilding(int placeX, int placeY)
    {
        for (int x = 0; x < _flyingBuilding.Size.x; x++)
        {
            for (int y = 0; y < _flyingBuilding.Size.y; y++)
            {
                _grid[placeX + x, placeY + y] = _flyingBuilding;
            }
        }

        _flyingBuilding.SetNormal();
        _flyingBuilding = null;
    }

    private bool IsPlaceTaken(int placeX, int placeY)
    {
        for (int x = 0; x < _flyingBuilding.Size.x; x++)
        {
            for (int y = 0; y < _flyingBuilding.Size.y; y++)
            {
                if (_grid[placeX + x, placeY + y] != null)
                    return true;
            }
        }

        return false;
    }
    #endregion
}
}
