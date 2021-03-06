﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReliabilityAnalysis.Scheme.ElementsOfDataGrid
{
    /// <summary>
    /// Базовая интенсивность отказов
    /// </summary>
    [Serializable]
    public class LambdaBasic : ElementOfDataGrid 
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lambdaBasic">Базовая интенсивность отказов</param>
        public LambdaBasic(double lambdaBasic)
        {
            Param = "Базовая интенсивность отказов, 1/ч";
            Value = lambdaBasic;
        }

        public DataBase.Element Element
        {
            get => default(DataBase.Element);
            set
            {
            }
        }
    }

}
