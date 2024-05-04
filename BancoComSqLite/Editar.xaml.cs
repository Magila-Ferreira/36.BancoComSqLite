using BancoComSqLite.Modelos;
using BancoComSqLite.Repositorios;

namespace BancoComSqLite;

public partial class Editar : ContentPage
{

	private PacienteRepositorio _pacientes;

	public Editar()
	{
		_pacientes = new PacienteRepositorio();
		InitializeComponent();
	}

	public Editar(long id) : this() {
		Paciente p = _pacientes.buscaId(id);
		BindingContext = p;
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		_pacientes.update(BindingContext as Paciente);
		Navigation.PopAsync();
    }
}