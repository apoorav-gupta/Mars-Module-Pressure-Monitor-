using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASA_Life_Support_System
{
    public class Sensor
    {
        double value;
        double hValue;
        double minAvgValue;
        double maxAvgValue;

        public Sensor(double v, double h, double min, double max)
        {
            value = v;
            hValue = h;
            minAvgValue = min;
            maxAvgValue = max;
        }

        public double getValue(){
            return value;
        }

        public void setMinAvgValue(double min)
        {
            minAvgValue = min;
        }
        public void setMaxAvgValue(double max)
        {
            maxAvgValue = max;
        }

        public void setValue(double reading)
        {
            value = Math.Round(reading, 2);
        }

        public void setHValue(double h)
        {
            hValue = h;
        }
        
        public void heightenedState(Monitor m)
        {
            if (m.getState() == "heightened")
            {
                if (m.getAverageValue() > maxAvgValue)
                    value = value - hValue;
                if (m.getAverageValue() < minAvgValue)
                    value = value + hValue;
            }

            
        }

        public void targetSet(Monitor m)
        {
            if (m.isSetTarget())
            {
                if (m.getAverageValue() > m.getTargetLevel())
                    value = value - hValue;
                if (m.getAverageValue() < m.getTargetLevel())
                    value = value + hValue;
            }
        }

        public void update(Monitor m)
        {
            heightenedState(m);
            targetSet(m);
        }

    }
}
