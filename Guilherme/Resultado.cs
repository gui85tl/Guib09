using System.Net;
using System.Text.Json;
using Network;

async void AtualizaTempo()
{
    try
    {
        var navegador = new HttpClient();
        var navegador = await navegador.GetAsync(url);
        if (response.IsSucessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            resposta = JsonSerializer.Deserialize<Resposta>(content);
        }

        PreencherTela();
    }
    catch(Exception e)
    {

    }

}