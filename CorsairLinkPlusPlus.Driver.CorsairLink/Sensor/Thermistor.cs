﻿using CorsairLinkPlusPlus.Common.Sensor;
using CorsairLinkPlusPlus.Common.Utility;
using CorsairLinkPlusPlus.Driver.CorsairLink.Node;

namespace CorsairLinkPlusPlus.Driver.CorsairLink.Sensor
{
    public abstract class Thermistor : BaseSensorDevice, IThermistor
    {
        internal Thermistor(BaseLinkDevice device, int id)
            : base(device, id)
        {

        }

        public override SensorType SensorType
        {
            get
            {
                return SensorType.Temperature;
            }
        }

        public override Unit Unit
        {
            get
            {
                return Unit.DegreeCelsius;
            }
        }
    }
}
