namespace Adapter
{
    interface IOrangePayment
    {
        Token AuthToken();

        void SendPayment();

        void ReceivePayment();
    }
}
