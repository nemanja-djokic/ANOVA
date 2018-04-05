using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnovaTest
{
    class Alternative
    {
        private string _alternativeName;
        public float[] _alternativeValues;

        public string AlternativeName
        {
            get
            {
                return _alternativeName;
            }
        }

        public float[] AlternativeValues
        {
            get
            {
                return _alternativeValues;
            }
        }

        public Alternative(String alternativeName, int numOfMeasurements)
        {
            this._alternativeName = alternativeName;
            _alternativeValues = new float[numOfMeasurements];
        }
    }
}
