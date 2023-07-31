namespace Gb.Application.Models
{
    public sealed class ErrorResponse
    {
        public IEnumerable<ErrorModel> Errors { get; set; }

        public ErrorResponse(params ErrorModel[] errors)
        {
            Errors = errors;
        }

        public ErrorResponse(IEnumerable<ErrorModel> errors)
        {
            Errors = errors;
        }
    }
}