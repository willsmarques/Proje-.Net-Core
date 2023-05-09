namespace SalesWebMvc.Services.Exceptions
{
	using System;
    public class NotFoundException : ApplicationException
    {

        public NotFoundException(string mensagem) : base(mensagem) 
        { 

        }

    }
  
}
