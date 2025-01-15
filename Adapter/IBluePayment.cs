namespace Adapter
{
    interface IBluePayment
    {
        Token AuthToken();

        void BluePayment();

        void BlueReceive();
    }
}
