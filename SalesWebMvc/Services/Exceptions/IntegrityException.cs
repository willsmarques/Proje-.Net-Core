namespace SalesWebMvc.Services.Exceptions
{
    using System;
    public class IntegrityException : ApplicationException
    {
        public IntegrityException(string message) :base(message) 
        { 

        
        }
    }
}
