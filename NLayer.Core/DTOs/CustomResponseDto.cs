using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{
    public class CustomResponseDto<T>
    {
        public T Data { get; set; }

        [JsonIgnore]
        public int StatusCode { get; set; }
        public List<String> Errors { get; set; }

        public static CustomResponseDto<T> Succsess(int statusCode, T data)
        {
            return new CustomResponseDto<T> { StatusCode = statusCode, Data = data };
        }
        /* Bezen ele olur ki, succsess olan zaman geriye data dondermek lazim deyil. Bu hallar ucun yazilib bu Succsess*/
        public static CustomResponseDto<T> Succsess(int statusCode)
        {
            return new CustomResponseDto<T> { StatusCode = statusCode};
        }


        public static CustomResponseDto<T> Fail(int statusCode,List<string> errors)
        {
            return new CustomResponseDto<T> { StatusCode = statusCode,Errors=errors };
        }
    }
}
