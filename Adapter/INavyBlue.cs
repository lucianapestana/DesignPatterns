namespace Adapter
{
    interface INavyBlue
    {
        Token AuthToken();

        void SendNavyBluePayment();

        void ReceiveNavyBluePayment();
    }
}
