using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpatialSlur;

namespace RC3
{
    /// <summary>
    /// 
    /// </summary>
    public class ModelManager : MonoBehaviour
    {
        [SerializeField] private ModelInitializer _initializer;
        [SerializeField] private Cell _cellPrefab;
        [SerializeField] private int _countX = 10;
        [SerializeField] private int _countY = 10;
        [SerializeField] private int _ageDisplayMin = 0;
        [SerializeField] private int _ageDisplayMax = 10;
        [SerializeField] private Material _ageMaterial;
        MaterialPropertyBlock _properties;

        IEnumerator changeColor;
     

        private Cell[,] _cells;
        private GameOfLife2D _model;
        private int _stepCount;

        //data structure
        List<int> aliveCellsCounts = new List<int>();
        List<int> cellsAge = new List<int>();
        int aliveCellsCount = 0;


        /// <summary>
        /// 
        /// </summary>
        private void Start()
        {

            // create cell array
            _cells = new Cell[_countY, _countX];

            _properties = new MaterialPropertyBlock();

            // instantiate cell prefabs and store in array
            for (int y = 0; y < _countY; y++)
            {
                for (int x = 0; x < _countX; x++)
                {
                    Cell cell = Instantiate(_cellPrefab, transform);

                    cell.transform.localPosition = new Vector3(x, y, 0);
                    _cells[y, x] = cell;
                }
            }


            //Debug.Log("a");


            //Debug.Log("b");
            // create model
            _model = new GameOfLife2D(_countY, _countX);

            // initialize model
            _initializer.Initialize(_model.CurrentState);

        }


        /// <summary>
        /// 
        /// </summary>
        private void Update()
        {
            
            _model.Step();
            _stepCount++;
            // Debug.Log($"{_stepCount} steps taken!");

            int[,] state = _model.CurrentState;



            // update cells based on current state of model
            for (int y = 0; y < _countY; y++)
            {
                for (int x = 0; x < _countX; x++)
                {
                    _cells[y, x].State = state[y, x];

                    aliveCellsCount += _cells[y, x].State;

                    _cells[y, x].Age = state[y, x] > 0 ? _cells[y, x].Age + 1 : 0;
                }
            }

           
            // update cells age



            Debug.Log($"count:  " + aliveCellsCount);

            aliveCellsCounts.Add(aliveCellsCount);
            aliveCellsCount = 0;




            changeColor = DisplayColor();
            StartCoroutine(changeColor);

            if (Time.time > 5)
            {

                StopCoroutine(DisplayColor());

                StopAllCoroutines();

            }

        }

        private IEnumerator DisplayColor()
        {
            while (true)
            {
                foreach (var cell in _cells)
                {
                    if (cell.State == 0)
                        continue;

                    MeshRenderer renderer = cell.Renderer;
                    renderer.sharedMaterial = _ageMaterial;
                    const string propName = "_Value";
                    {
                        renderer.GetPropertyBlock(_properties);

                        // normalize age
                        float value = SlurMath.Normalize(cell.Age, _ageDisplayMin, _ageDisplayMax);
                        _properties.SetFloat(propName, value);

                        renderer.SetPropertyBlock(_properties);
                    }

                  //  cell.GetComponent<MeshRenderer>().material.color = new Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value);

                }
                yield return new WaitForSeconds(0.1f);

            }

        }

        void OnGUI()
        {

            GUI.Label(new Rect(830, 110, 300, 20), "Alive Cells Counds: " + aliveCellsCounts[_stepCount - 1].ToString());


            // Debug.Log($"{_stepCount} steps taken!");

            GUI.Label(new Rect(830, 130, 300, 20), _stepCount.ToString() + "  steps taken!");
        }
    }
}
