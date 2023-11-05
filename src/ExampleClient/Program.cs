// See https://aka.ms/new-console-template for more information

using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using AasCore.Aas3_0;
using Microsoft.IdentityModel.Tokens;

Console.WriteLine("AAS Example Client V3");
Console.WriteLine();

// Find full API at https://v3.admin-shell-io.com/swagger
// GET shells, which is with pagenation
Console.WriteLine("GET https://v3.admin-shell-io.com/shells");

var requestPath = "https://v3.admin-shell-io.com/shells";

var handler = new HttpClientHandler();

if (!requestPath.Contains("localhost")) handler.DefaultProxyCredentials = CredentialCache.DefaultCredentials;

var client = new HttpClient(handler);

var error = false;
var response = new HttpResponseMessage();

var task = Task.Run(async () => { response = await client.GetAsync(requestPath); });
task.Wait();
var json = response.Content.ReadAsStringAsync().Result;
if (!string.IsNullOrEmpty(json))
{
    var mStrm = new MemoryStream(Encoding.UTF8.GetBytes(json));
    var node = JsonSerializer.DeserializeAsync<JsonNode>(mStrm).Result;
    if (node is JsonObject jo)
        if (jo.ContainsKey("result"))
        {
            node = (JsonNode)jo["result"];
            if (node is JsonArray a)
                // iterate shells
                foreach (var n in a)
                {
                    if (n != null)
                        try
                        {
                            // Deserialize shell
                            var aas = Jsonization.Deserialize.AssetAdministrationShellFrom(n);
                            Console.WriteLine("Received AAS: " + aas.IdShort);

                            // Iterate submodels
                            if (aas.Submodels != null && aas.Submodels.Count > 0)
                                foreach (var smr in aas.Submodels)
                                {
                                    requestPath = "https://v3.admin-shell-io.com/submodels/" +
                                                  Base64UrlEncoder.Encode(smr.Keys[0].Value);
                                    Console.WriteLine("GET " + requestPath);

                                    task = Task.Run(async () => { response = await client.GetAsync(requestPath); });
                                    task.Wait();
                                    json = response.Content.ReadAsStringAsync().Result;
                                    if (!string.IsNullOrEmpty(json))
                                    {
                                        var mStrm2 = new MemoryStream(Encoding.UTF8.GetBytes(json));
                                        var node2 = JsonSerializer.DeserializeAsync<JsonNode>(mStrm2).Result;
                                        var submodel = Jsonization.Deserialize.SubmodelFrom(node2);
                                        Console.WriteLine("Received Submodel: " + submodel.IdShort);
                                        // Iterate submodel here
                                        // See VisitorThrough in AasCore
                                        // See VisitorAASX in entityFW.cs
                                    }
                                }
                        }
                        catch
                        {
                            var r = "ERROR GET; " + response.StatusCode;
                            r += " ; " + requestPath;
                            if (response.Content != null)
                                r += " ; " + response.Content.ReadAsStringAsync().Result;
                            Console.WriteLine(r);
                        }

                    Console.WriteLine();
                }
        }
}