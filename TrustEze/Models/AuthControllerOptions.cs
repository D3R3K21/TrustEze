﻿namespace TrustEze.Models
{
    public class AuthControllerOptions
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string CallbackUri { get; set; }
        public string CognitoUri { get; set; }
    }
}