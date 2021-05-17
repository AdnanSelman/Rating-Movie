using MovieRatingTask.Core.Extensions;
using System;

namespace MovieRatingTask.Core.Core
{
    public class CommandResponse
    {
        public bool Succeeded => Errors.IsNullOrEmpty();

        public string[] Errors { get; protected set; }

        public string ExceptionMessage { get; protected set; }

        public string StackTrace { get; protected set; }

        public static CommandResponse Error(params string[] errors)
        {
            return new CommandResponse() { Errors = errors };
        }

        public static CommandResponse Error(Exception exception, params string[] errors)
        {
            return new CommandResponse() { ExceptionMessage = exception.Message, StackTrace = exception.StackTrace, Errors = errors };
        }
    }

    public class CommandResponse<TCommandResponse> : CommandResponse
    {
        public TCommandResponse Payload { get; set; }

        public new static CommandResponse<TCommandResponse> Error(params string[] errors)
        {
            return new CommandResponse<TCommandResponse> { Errors = errors };
        }

        public new static CommandResponse<TCommandResponse> Error(Exception exception, params string[] errors)
        {
            return new CommandResponse<TCommandResponse> { ExceptionMessage = exception.Message, StackTrace = exception.StackTrace, Errors = errors };
        }

        public static CommandResponse<TCommandResponse> Ok(TCommandResponse payload)
        {
            return new CommandResponse<TCommandResponse> { Payload = payload };
        }
    }
}