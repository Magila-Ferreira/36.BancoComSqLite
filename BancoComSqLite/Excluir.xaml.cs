using BancoComSqLite.Modelos;
using BancoComSqLite.Repositorios;

namespace BancoComSqLite;

public partial class Excluir : ContentPage
{
	private PacienteRepositorio _pacientes;
	public Excluir()
	{
		_pacientes = new PacienteRepositorio();
		InitializeComponent();
	}

	public Excluir(long id) : this()
	{
		Paciente p = _pacientes.buscaId(id);
		BindingContext = p;
	}

	private async void Button_Clicked(object tsender, EventArgs e)
	{
		bool resposta = await DisplayAlert("Atenção", "Esta ação não pode ser desfeita\n" +
											"Deseja realmente excluir?", "Sim", "Não");

		if (resposta)
		{
			_pacientes.remove(BindingContext as Paciente);
			await DisplayAlert("Aviso", "A operação foi realizada.", "ok");
		} else {
			await DisplayAlert("Aviso", "A operação foi cancelada", "ok");
		}
		_ = Navigation.PopAsync();
	}
}