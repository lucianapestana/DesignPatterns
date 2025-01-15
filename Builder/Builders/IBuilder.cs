using Builder.Components;
using Builder.Products;

namespace Builder.Builders
{
    interface IBuilder
    {
        void Reset();

        Vehicle GetVehicle();

        void SetSeatle(int seats);

        void SetEngine(Engine engine);

        void SetTransmission(Transmission transmission);

        void SetVehicleType(VehicleType vehicleType);

        void SetAirbags(Airbags airbags);
    }
}
