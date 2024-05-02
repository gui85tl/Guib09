using System.Reflection.Emit;
using Windows.ApplicationModel.AppService;

namespace Guilherme;

public class MainPage : ContentPage
{
	resultado resposta;

	public MainPage()
	{
		Guilherme();
	}

	void TesalLayout()
	{
		results.temp=25;
		results.description="Tempo Nublado"
		results.time="20"
		
	}
  
}

       void PreencherTela()
	   {

		Labeltemp.Text= resposta.results.temp.Temp ToString();
		
		