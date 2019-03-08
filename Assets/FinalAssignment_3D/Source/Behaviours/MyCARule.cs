using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using SpatialSlur;
using UnityEngine.UI;

namespace RC3
{
    /// <summary>
    /// Rule for Conway's game of life
    /// </summary>
    [RequireComponent(typeof(StackModel))]
    [RequireComponent(typeof(StackAnalyser))]
    public class MyCARule : MonoBehaviour, ICARule2D
    {
        private StackModel _model;
        private StackAnalyser _analyser;

        //setup some possible instruction sets
        private GOLInstructionSet _instSetDead = new GOLInstructionSet(3, 5, 5, 5);
        private GOLInstructionSet _instSetIncrease1 = new GOLInstructionSet(2, 3, 3, 4);
        private GOLInstructionSet _instSetIncrease2 = new GOLInstructionSet(3, 5, 3, 3);
        private GOLInstructionSet _instSetIncrease3 = new GOLInstructionSet(3, 4, 3, 4);
        private GOLInstructionSet _instSetIncrease4 = new GOLInstructionSet(1, 2, 3, 4);
        private GOLInstructionSet _instSetDecrease1 = new GOLInstructionSet(4, 7, 3, 3);
        private GOLInstructionSet _instSetDecrease2 = new GOLInstructionSet(2, 3, 3, 3);
        private GOLInstructionSet _instSetColumn = new GOLInstructionSet(0, 1, 3, 3);
        private GOLInstructionSet _instSetStable1 = new GOLInstructionSet(2, 3, 2, 3);
        private GOLInstructionSet _instSetStable2 = new GOLInstructionSet(1, 2, 2, 3);
        private GOLInstructionSet _instSetStable3 = new GOLInstructionSet(3, 3, 2, 2);
        private GOLInstructionSet _instSetStable4 = new GOLInstructionSet(1, 3, 3, 3);
        private GOLInstructionSet _instSetStable5 = new GOLInstructionSet(2, 4, 1, 1);
        private GOLInstructionSet _instSetVerticle = new GOLInstructionSet(2, 6, 4, 5);
        private GOLInstructionSet _instSetOriginalImage = new GOLInstructionSet(5, 8, 4, 4);
        private GOLInstructionSet _instSetStripeImage = new GOLInstructionSet(2, 7, 0, 0);


        /// <summary>
        /// 
        /// </summary>
        private void Start()
        {
            _model = GetComponent<StackModel>();
            _analyser = GetComponent<StackAnalyser>();

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <param name="current"></param>
        /// <returns></returns>
        public int NextAt(Index2 index, int[,] current)
        {
            //get current state
            int state = current[index.I, index.J];

            //get local neighborhood data
            int sumMO = GetNeighborSum(index, current, Neighborhoods.MooreR1);
            int sumVNPair = GetNeighborSum(index, current, Neighborhoods.VonNeumannPair1);

            //choose an instruction set
            GOLInstructionSet instructionSet = _instSetStable1;

            // collect relevant analysis results
            CellLayer[] layers = _model.Stack.Layers;
            int currentLayer = _model.CurrentLayer;
            
            float prevLayerDensity;
            int prevCellAge;

            // get attributes of corresponding cell on the previous layer (if it exists)
            if (currentLayer > 0)
            {
                var prevLayer = layers[currentLayer - 1];
                prevLayerDensity = prevLayer.Density;
                prevCellAge = prevLayer.Cells[index.I, index.J].Age;
            }
            else
            {
                prevLayerDensity = 1.0f;
                prevCellAge = 0;
            }

            Dropdown myDropdown = GameObject.Find("Rule").GetComponent<Dropdown>();

            if (myDropdown.value == 1)
            {
                instructionSet = _instSetStable2;
            }
            if (myDropdown.value == 2)
            {
                instructionSet = _instSetStable3;
            }
            if (myDropdown.value == 3)
            {
                instructionSet = _instSetStable4;
            }
            if (myDropdown.value == 4)
            {
                instructionSet = _instSetStable5;
            }

            //垂直生长&成柱子
            if (myDropdown.value == 5)
            {
                instructionSet = _instSetVerticle;
            }
            if (myDropdown.value == 6)
            {
                instructionSet = _instSetColumn;
            }

            //增长生长
            if (myDropdown.value == 7)
            {
                instructionSet = _instSetIncrease1;
            }
            if (myDropdown.value == 8)
            {
                instructionSet = _instSetIncrease2;
            }
            if (myDropdown.value == 9)
            {
                instructionSet = _instSetIncrease3;
            }
            if (myDropdown.value == 10)
            {
                instructionSet = _instSetIncrease4;
            }

            //减少生长
            if (myDropdown.value == 11)
            {
                instructionSet = _instSetDecrease1;
            }
            if (myDropdown.value == 12)
            {
                instructionSet = _instSetDecrease2;
            }

            //死亡
            if (myDropdown.value == 13)
            {
                instructionSet = _instSetDead;
            }

            //桌面
            if (myDropdown.value == 14)
            {
                instructionSet = _instSetOriginalImage;
            }

            if (myDropdown.value == 15)
            {
                instructionSet = _instSetStripeImage;
            }

            //line_outside
            if (myDropdown.value == 16)
            {
                instructionSet = _instSetIncrease4;//1234
                if (currentLayer >= 20)
                {
                    instructionSet = _instSetDecrease2;//2333
                }
                if (currentLayer >= 40)
                {
                    instructionSet = _instSetStable3;//3322
                }
                if (prevLayerDensity < 0.08)
                {
                    instructionSet = _instSetStable3;//3322
                }
                if (prevLayerDensity >= 0.08)
                {
                    instructionSet = _instSetDecrease2;//2333
                }
            }

            //自定义
            if (myDropdown.value == 0)
            {
                instructionSet = _instSetDecrease2;
            }

            int output = 0;

            //if current state is "alive"
            if (state == 1)
            {
                if (sumMO < instructionSet.getInstruction(0))
                {
                    output = 0;
                }

                if (sumMO >= instructionSet.getInstruction(0) && sumMO <= instructionSet.getInstruction(1))
                {
                    output = 1;
                }

                if (sumMO > instructionSet.getInstruction(1))
                {
                    output = 0;
                }
            }

            //if current state is "dead"
            if (state == 0)
            {
                if (sumMO >= instructionSet.getInstruction(2) && sumMO <= instructionSet.getInstruction(3))
                {
                    output = 1;
                }
                else
                {
                    output = 0;
                }
            }

            return output;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i0"></param>
        /// <param name="j0"></param>
        /// <returns></returns>
        private int GetNeighborSum(Index2 index, int[,] current, Index2[] neighborhood)
        {
            int nrows = current.GetLength(0);
            int ncols = current.GetLength(1);
            int sum = 0;

            foreach (Index2 offset in neighborhood)
            {
                int i1 = Wrap(index.I + offset.I, nrows);
                int j1 = Wrap(index.J + offset.J, ncols);

                if (current[i1, j1] > 0)
                    sum++;
            }

            return sum;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="i"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        private static int Wrap(int i, int n)
        {
            i %= n;
            return (i < 0) ? i + n : i;
        }
    }
}