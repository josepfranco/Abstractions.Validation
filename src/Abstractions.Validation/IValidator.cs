using System.Threading;
using System.Threading.Tasks;
using Abstractions.Validation.Models;

namespace Abstractions.Validation
{
    /// <summary>
    /// Marks a service as being responsible for validating a certain data object.
    /// </summary>
    /// <typeparam name="TRecord">the type of the data object to validate</typeparam>
    public interface IValidator<in TRecord>
    {
        /// <summary>
        /// Asynchronously validates the data object, producing a validation result.
        /// For more information see <see cref="Result"/>.
        /// </summary>
        /// <param name="record">the data object to validate</param>
        /// <param name="token"> the cancellation token</param>
        /// <returns>a task with the validation result</returns>
        Task<Result> ValidateAsync(TRecord record, CancellationToken token = default);
    }
}