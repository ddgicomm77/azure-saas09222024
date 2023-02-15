﻿using Azure.Core;
using Microsoft.Identity.Web;

namespace ClientAssertionWithKeyVault.Interface;

public interface IClientAssertionSigningProvider
{
    Task<string> GetClientAssertion(
        CertificateDescription keyInfo,
        string audience,
        string clientId,
        TokenCredential credential,
        TimeSpan lifetime = default);


    Task<string> GetClientAssertion(
        string keyVaultUri,
        string certKeyName,
        string audience,
        string clientId,
        TokenCredential credential,
        TimeSpan lifetime = default);
}
