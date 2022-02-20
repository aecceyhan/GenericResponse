using System;

namespace Ceyhan.GenericResponse
{
    public class GenericResponse<T> 
    {
        public bool Success { get; protected set; }
        public string Message { get; protected set; }
        public T GenericModel { get; private set; }


        /// <summary>
        /// Return successful response
        /// </summary>
        /// <param name="t">Can be any object</param>
        /// <returns>Generic Response</returns>
        public GenericResponse(T t) : this(true, string.Empty, t)
        {
        }


        /// <summary>
        /// Return error message
        /// </summary>
        /// <param name="message">Error Message</param>
        /// <returns>Error message</returns>
        public GenericResponse(string message) : this(false, message, default)
        { }


        /// <summary>
        /// Retruns generic response
        /// </summary>
        /// <param name="success">Is this actions successful?</param>
        /// <param name="message">A text message</param>
        /// <param name="t">Can be any object</param>
        public GenericResponse(bool success, string message, T t)
        {
            Success = success;
            Message = message;
            GenericModel = t;
        }
    }

}
