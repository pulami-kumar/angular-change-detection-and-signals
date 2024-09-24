﻿namespace angular_signal_api.Domain.Enum
{
    public enum ResultStatusEnum
    {
        Success = 200,
        Created = 201,
        NoContent = 204,
        Fail = 400,
        Forbidden = 403,
        BadRequest = 404,
        Duplicate = 409,
        UnsupportedMediaType = 415,
        ServerError = 500
    }
}