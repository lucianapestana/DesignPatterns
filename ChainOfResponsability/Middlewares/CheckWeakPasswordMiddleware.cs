using System;

namespace ChainOfResponsability.Middlewares
{
    class CheckWeakPasswordMiddleware : Middleware
    {
        public override bool Check(string email, string password)
        {
            if (password.Equals("123456"))
            {
                Console.WriteLine("ATENÇÃO: Considere usar uma senha mais segura.");
            }

            return CheckNext(email, password);
        }
    }
}
