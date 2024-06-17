using ApiCursosUeceMy.Domain.Services.Inputs;
using ApiCursosUeceMy.Domain.Services.Interface;
using ApiCursosUeceMy.Domain.Services.Results;
using System.Text.Json;

namespace ApiCursosUeceMy.Domain.Services.Streaming;

public class StreamServices : IStreamServices
{
    public readonly IConfiguration _configuration; 
    public StreamServices(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    public async Task<StreamResult> SalvarRecurso(StreamInput? streamInput)
    {
        HttpClient httpClient = new HttpClient();
        string data = JsonSerializer.Serialize(streamInput);
        var content = new StringContent(data);
        string uri = _configuration["streamService"] + "api/Streams/create";
        var response = await httpClient.PostAsync(uri, content);

        var result = await response.Content.ReadAsStringAsync();
        StreamResult obj = JsonSerializer.Deserialize<StreamResult>(result);
        
        return obj;
    }

    public async Task<StreamResult> BuscarRecurso(Guid IdRecurso)
    {
        HttpClient httpClient = new HttpClient();
        //string data = JsonSerializer.Serialize(streamInput);
        //var content = new StringContent(data);
        string uri = _configuration["streamService"] + $"api/Streams/getById?id={IdRecurso}";
        var response = await httpClient.GetAsync(uri);

        var result = await response.Content.ReadAsStringAsync();
        var obj = JsonSerializer.Deserialize<StreamResult>(result);

        return obj;
    }

}
