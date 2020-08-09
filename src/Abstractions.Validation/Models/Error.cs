namespace Abstractions.Validation.Models
{
    /// <summary>
    /// Immutable representation of a validation error within a result.
    /// For more information see <see cref="Result"/>.
    /// </summary>
    public sealed class Error
    {
        /// <summary>
        /// The associated code of this specific error.
        /// </summary>
        public string Code { get; }
        
        /// <summary>
        /// A user friendly message of this specific error.
        /// </summary>
        public string Message { get; }
        
        /// <summary>
        /// The input value responsible for the validation error
        /// </summary>
        public object InputValue { get; }

        /// <summary>
        /// Constructs the error object
        /// </summary>
        /// <param name="code">see <see cref="Code"/></param>
        /// <param name="message">see <see cref="Message"/></param>
        /// <param name="inputValue">see <see cref="InputValue"/></param>
        public Error(string code, string message, object inputValue)
        {
            Code = code;
            Message = message;
            InputValue = inputValue;
        }
    }
}