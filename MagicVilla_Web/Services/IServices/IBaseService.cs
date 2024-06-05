using System;
using MagicVilla_Web.Models;

namespace MagicVilla_Web.Services.IServices
{
	public interface IBaseService
	{
		APIResponse responseModel { get; set; }

		// send api calls to call our api: every time we call the api, we will path an api request model and return type will be generic
		Task<T> SendAsync<T>(APIRequest apiRequest);
	}
}

