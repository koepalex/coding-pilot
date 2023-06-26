#pragma warning disable CS8618

namespace Koepalex.CodingPilot.Configuration;

/// <summary>
/// Configuration options for interacting with OpenAI.
/// </summary>
public class AzureOpenAiServiceOptions : OpenAiServiceOptions
{
    /// <summary>
    /// Gets or sets the Azure OpenAI Endpoint.
    /// </summary>
    public string Endpoint { get; set; }

    /// <summary>
    /// Gets or sets the Azure OpenAI Deployment Name.
    /// </summary>
    public string DeploymentName { get; set; }
}