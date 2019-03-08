using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

using SpatialSlur;

namespace RC3
{
    /// <summary>
    /// 
    /// </summary>
    [RequireComponent(typeof(StackModel))]
    public class StackAnalyser : MonoBehaviour
    {
        private StackModel _model;
        private float _densitySum;
        private int _currentLayer; // index of the most recently analysed layer
        private int _maxAge = 0;

        //data structure
        List<CellLayer> _stackLayers=new List<CellLayer>();
        List<float> _layerDensity=new List<float>();

        /// <summary>
        /// 
        /// </summary>
        private void Start()
        {
            _model = GetComponent<StackModel>();
            ResetAnalysis();
        }


        /// <summary>
        /// 
        /// </summary>
        private void LateUpdate()
        {
            // reset analysis if necessary
            if (_currentLayer > _model.CurrentLayer)
                ResetAnalysis();

            // update analysis if model has been updated
            if (_currentLayer < _model.CurrentLayer)
                UpdateAnalysis();
        }


        /// <summary>
        /// Returns the current mean density of the stack
        /// </summary>
        public float MeanStackDensity
        {
            get { return _densitySum / (_model.CurrentLayer + 1); }
        }


        /// <summary>
        /// 
        /// </summary>
        public void UpdateAnalysis()
        {
            int currentLayer = _model.CurrentLayer;
            CellLayer layer = _model.Stack.Layers[currentLayer];

            _stackLayers.Add(layer);

            //update layer current density
            var density = CalculateDensity(layer);

            _layerDensity.Add(density);

            layer.Density = density;
            _densitySum += density; // add to running sum

            //update oldest cell age
            foreach (var cell in layer.Cells)
            {
                _maxAge = Math.Max(cell.Age, _maxAge); //get the oldest age
            }
            
            _currentLayer = currentLayer;
        }


        /// <summary>
        /// Calculate the density of alive cells for the given layer
        /// </summary>
        /// <returns></returns>
        private float CalculateDensity(CellLayer layer)
        {
            var cells = layer.Cells;
            int aliveCount = 0;

            foreach (var cell in cells)
                aliveCount += cell.State;

            return (float)aliveCount / cells.Length;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private void ResetAnalysis()
        {
            _densitySum = 0.0f;
            _currentLayer = -1;
            _maxAge = 0;
            _stackLayers.Clear();
            _layerDensity.Clear();
        }

        void OnGUI()
        {
            
            GUI.Label(new Rect(830, 110, 300, 20), "Mean Density: " + MeanStackDensity.ToString());
            GUI.Label(new Rect(830, 130, 300, 20), "Max Age: " + _maxAge.ToString());
            GUI.Label(new Rect(830, 150, 300, 20), "Current Step: " + _stackLayers.Count.ToString() + "/" + _model.Stack.LayerCount.ToString());
        }
    }
}
