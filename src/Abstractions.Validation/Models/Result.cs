using System.Collections.Generic;

namespace Abstractions.Validation.Models
{
    /// <summary>
    /// Immutable representation of a validation result.
    /// </summary>
    public sealed class Result
    {
        /// <summary>
        /// Whether the validation was successful or not.
        /// </summary>
        public bool IsValid { get; }
        
        /// <summary>
        /// The list of validation errors encountered by the validator.
        /// If <see cref="IsValid"/> is true, then this property is empty.
        /// For more information see <see cref="Error"/>.
        /// </summary>
        public IEnumerable<Error> Errors { get; }

        /// <summary>
        /// Constructs a validation result.
        /// </summary>
        /// <param name="isValid">see <see cref="IsValid"/></param>
        /// <param name="errors">see <see cref="Errors"/></param>
        public Result(bool isValid, IEnumerable<Error> errors)
        {
            IsValid = isValid;
            Errors = errors;
        }
    }
}