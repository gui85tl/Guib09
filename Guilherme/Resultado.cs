namespace Guilherme;
public class resultado
{
public Results results{get;set;}
}
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