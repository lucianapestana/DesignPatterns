﻿using Builder.Builders;
using Builder.Components;

namespace Builder.Directors
{
    class Director
    {
        IBuilder builder;

        public Director(IBuilder builder)
        {
            this.builder = builder;
        }

        public void ConstructSedanCar()
        {
            builder.SetVehicleType(VehicleType.SEDAN);
            builder.SetEngine(new Engine(2000));
            builder.SetSeatle(5);
            builder.SetTransmission(Transmission.AUTOMATIC);
        }

        public void ConstructTruck()
        {
            builder.SetVehicleType(VehicleType.TRUCK);
            builder.SetEngine(new Engine(4000));
            builder.SetSeatle(2);
            builder.SetTransmission(Transmission.MANUAL);
        }

        public void ConstructSUV()
        {
            builder.SetVehicleType(VehicleType.SUV);
            builder.SetEngine(new Engine(2600));
            builder.SetTransmission(Transmission.AUTOMATIC_SEQUENTIAL);
            builder.SetAirbags(new Airbags(2));
        }
    }
}
