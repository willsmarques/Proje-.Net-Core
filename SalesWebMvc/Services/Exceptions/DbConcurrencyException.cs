namespace SalesWebMvc.Services.Exceptions
{
    using System;
    public class DbConcurrencyException : ApplicationException
    {
        public DbConcurrencyException(string menssage) : base(menssage) 
        { 
        
        }

    }
}
